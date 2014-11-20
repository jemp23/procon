-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 20-11-2014 a las 03:27:23
-- Versión del servidor: 5.6.12-log
-- Versión de PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `procon`
--
CREATE DATABASE IF NOT EXISTS `procon` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `procon`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `desperdicio`
--

CREATE TABLE IF NOT EXISTS `desperdicio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `fkoperador` int(11) NOT NULL,
  `fkmaquina` int(11) NOT NULL,
  `cantidad` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `fkunidad_medida` int(11) NOT NULL,
  `fktipo_desperdicio` int(11) NOT NULL,
  `fkorden_produccion` int(11) NOT NULL,
  `fkusuario` int(11) NOT NULL,
  `fkempresa` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fkoperador` (`fkoperador`,`fkmaquina`,`fkunidad_medida`,`fktipo_desperdicio`,`fkorden_produccion`,`fkusuario`),
  KEY `fkempresa` (`fkempresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE IF NOT EXISTS `empresa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sede` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `nombre` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `rif` varchar(30) COLLATE utf8_spanish2_ci NOT NULL,
  `direccion` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `telefono` varchar(15) COLLATE utf8_spanish2_ci NOT NULL,
  `correo` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`id`, `sede`, `nombre`, `rif`, `direccion`, `telefono`, `correo`) VALUES
(1, 'UREÑA', 'INDUSTRIAS Y DISTRIBUCIONES CONDOR, C.A.', 'J09024103-5', 'UREÑA', '02760000000', 'JEMP23@GMAIL.COM');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maquinas`
--

CREATE TABLE IF NOT EXISTS `maquinas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numero` int(10) NOT NULL,
  `descripcion` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `fkempresa` int(11) NOT NULL,
  `fktipo_maquina` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fkempresa` (`fkempresa`,`fktipo_maquina`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `maquinas`
--

INSERT INTO `maquinas` (`id`, `numero`, `descripcion`, `fkempresa`, `fktipo_maquina`) VALUES
(1, 1, 'MAQUINA 1', 1, 2),
(2, 2, 'MAQUINA 2', 1, 2),
(3, 3, 'MAQUINA 3', 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulos`
--

CREATE TABLE IF NOT EXISTS `modulos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `direccion` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `imagen` varchar(50) COLLATE utf8_spanish2_ci DEFAULT '0',
  `interfaz` int(30) NOT NULL,
  `orden` int(5) NOT NULL,
  `superior` int(5) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `superior` (`superior`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=23 ;

--
-- Volcado de datos para la tabla `modulos`
--

INSERT INTO `modulos` (`id`, `descripcion`, `direccion`, `imagen`, `interfaz`, `orden`, `superior`) VALUES
(1, 'CONFIGURACION', '', '1', 1, 1, 0),
(2, 'PRODUCCION', 'PRODUCCION', '4', 1, 2, 0),
(3, 'CONTROL DE USUARIOS', 'USUARIO', '0', 1, 3, 9),
(4, 'CREAR ORDEN PRODUCCION', 'CREA', '0', 1, 4, 2),
(5, 'CMR', 'CMR', '0', 1, 5, 0),
(6, 'CREAR OPORTUNIDAD', 'OPORTUNIDAD', '0', 1, 6, 5),
(7, 'PRUEBA', 'PRUEBA', '0', 1, 7, 6),
(8, 'PRUEBA2', 'PRUEBA2', '0', 1, 8, 7),
(9, 'USUARIO', '', '5', 1, 3, 1),
(10, 'PERFIL DE USUARIOS', 'TIPOUSUARIO', '0', 1, 2, 9),
(11, 'MODULOS DEL SISTEMA', 'MODULOS', '0', 1, 1, 9),
(12, 'EMPRESAS', 'EMPRESA', '0', 1, 1, 1),
(13, 'PRODUCCION', '', '5', 1, 2, 1),
(21, 'OPERADORES', 'OPERADORES', '0', 1, 2, 2),
(22, 'REGISTRAR DESPERDICIO', 'DESPERDICIOS', '0', 1, 3, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `operador`
--

CREATE TABLE IF NOT EXISTS `operador` (
  `idOperador` int(11) NOT NULL AUTO_INCREMENT,
  `nombreOperador` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `telefonoOperador` varchar(11) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `estatus` int(2) NOT NULL DEFAULT '0',
  `fkSede` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idOperador`),
  UNIQUE KEY `idOperador` (`idOperador`),
  KEY `fkSede` (`fkSede`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci COMMENT='para el registro de los operadores' AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `operador`
--

INSERT INTO `operador` (`idOperador`, `nombreOperador`, `telefonoOperador`, `estatus`, `fkSede`) VALUES
(1, 'JOSE PEREZ', '', 0, 1),
(2, 'PRUEBA2', '', 0, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden_produccion`
--

CREATE TABLE IF NOT EXISTS `orden_produccion` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numero` varchar(30) COLLATE utf8_spanish2_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permisos`
--

CREATE TABLE IF NOT EXISTS `permisos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fk_tipousuario` int(11) NOT NULL,
  `fk_tipomodulo` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tipousuario` (`fk_tipousuario`,`fk_tipomodulo`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=28 ;

--
-- Volcado de datos para la tabla `permisos`
--

INSERT INTO `permisos` (`id`, `fk_tipousuario`, `fk_tipomodulo`) VALUES
(1, 1, 1),
(3, 1, 3),
(7, 2, 2),
(8, 2, 3),
(9, 2, 4),
(11, 2, 6),
(12, 2, 7),
(13, 2, 8),
(14, 2, 9),
(27, 2, 21),
(23, 6, 5),
(24, 6, 6),
(25, 6, 7),
(26, 6, 8);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_desperdicio`
--

CREATE TABLE IF NOT EXISTS `tipo_desperdicio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `tipo_desperdicio`
--

INSERT INTO `tipo_desperdicio` (`id`, `descripcion`) VALUES
(1, 'SELLADO'),
(2, 'EXTRUSION'),
(3, 'IMPRESION');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_usuario`
--

CREATE TABLE IF NOT EXISTS `tipo_usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `tipo_usuario`
--

INSERT INTO `tipo_usuario` (`id`, `descripcion`) VALUES
(1, 'SISTEMAS'),
(2, 'JEFE PRODUCCION'),
(3, 'OPERADOR'),
(4, 'DIRECTIVO'),
(5, 'JEFE ADMINISTRACION'),
(6, 'AISTENTE DE VENTAS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `unidadmedida`
--

CREATE TABLE IF NOT EXISTS `unidadmedida` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `apellidos` varchar(100) COLLATE utf8_spanish2_ci NOT NULL,
  `correo` varchar(100) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `celular` varchar(30) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `usuario` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `clave` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `remoto` varchar(30) COLLATE utf8_spanish2_ci NOT NULL,
  `foto` longblob,
  `nivel` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `nombres`, `apellidos`, `correo`, `celular`, `usuario`, `clave`, `remoto`, `foto`, `nivel`) VALUES
(1, 'SISTEMAS', 'SISTEMAS', '', '04126417057', 'S', 's', 'si', NULL, 100),
(2, 'JUAN ENRIQUE', 'MOTTA PINTO', 'jemp23@gmail.com', '04126417057', 'jemp23', '418447', '', NULL, 25),
(3, 'PRUEBA 3', 'PRUEBA 3', '', '04126417057', 'PP', 'PP', '', NULL, 4),
(4, 'VENTAS', 'VENTAS', '', '04120000000', 'VENTAS', 'VENTAS', '', NULL, 10),
(5, 'VENTAS', 'VENTAS', '', '04120000000', 'VENTAS', 'VENTAS', '', NULL, 10),
(6, 'PRUEBA', 'PRUEBA', '', '04140000000', 'P', 'P', '', NULL, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_sede`
--

CREATE TABLE IF NOT EXISTS `usuario_sede` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fkusuario` int(11) NOT NULL,
  `fkempresa` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fkusuario` (`fkusuario`,`fkempresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_tipousuario`
--

CREATE TABLE IF NOT EXISTS `usuario_tipousuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fkusuario` int(11) NOT NULL,
  `fktipo_usuario` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fkusuario` (`fkusuario`,`fktipo_usuario`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci AUTO_INCREMENT=24 ;

--
-- Volcado de datos para la tabla `usuario_tipousuario`
--

INSERT INTO `usuario_tipousuario` (`id`, `fkusuario`, `fktipo_usuario`) VALUES
(1, 1, 1),
(2, 1, 2),
(7, 1, 3),
(8, 1, 4),
(13, 2, 2),
(3, 2, 4),
(19, 3, 2),
(20, 3, 3),
(21, 3, 5),
(23, 5, 2),
(22, 5, 6);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
