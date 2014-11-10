using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PROCON.CONTROLADOR.SESION;

namespace PROCON.UTILIDADES
{
    class validaciones
    {
        //para validar celulares
        public static bool IsValidoCelular(string celular)
        {
            try
            {
                //si estan activadas las expresionesregulares, valida
                //sino devuelve todo como valido
                //a menos que exista un error
                if (sesion.ACTIVAREXPRESIONESREGULARESPARAVALIDAR == 1)
                {
                    return Regex.IsMatch(celular, @"^(0412|0426|0416|0414|0424)([0-9]{7})$");
                }
                else
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

        //validar correo
        public static bool IsValidoEmail(string strMailAddress)
        {
            try
            {
                //si estan activadas las expresionesregulares, valida
                //sino devuelve todo como valido
                //a menos que exista un error
                if (sesion.ACTIVAREXPRESIONESREGULARESPARAVALIDAR == 1)
                {
                    return Regex.IsMatch(strMailAddress, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
                }
                else
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }

        }

        //para validar celulares
        public static bool IsValidoMoneda(string moneda)
        {
            try
            {
                //si estan activadas las expresionesregulares, valida
                //sino devuelve todo como valido
                //a menos que exista un error
                if (sesion.ACTIVAREXPRESIONESREGULARESPARAVALIDAR == 1)
                {
                    return Regex.IsMatch(moneda, @"^((([1-9]+[0-9]*)|0)([,][0-9]{2})?)$");
                }
                else
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }


        }
    }
}
