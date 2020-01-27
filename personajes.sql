-- phpMyAdmin SQL Dump
-- version 4.6.6deb5
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 27-01-2020 a las 14:28:16
-- Versión del servidor: 10.0.28-MariaDB-2+b1
-- Versión de PHP: 7.3.11-1~deb10u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `personajes`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Inventario`
--

CREATE TABLE `Inventario` (
  `id` int(11) NOT NULL,
  `slot1` text COLLATE utf8_spanish_ci NOT NULL,
  `slot2` text COLLATE utf8_spanish_ci NOT NULL,
  `slot3` text COLLATE utf8_spanish_ci NOT NULL,
  `slot4` text COLLATE utf8_spanish_ci NOT NULL,
  `slot5` text COLLATE utf8_spanish_ci NOT NULL,
  `slot6` text COLLATE utf8_spanish_ci NOT NULL,
  `slot7` text COLLATE utf8_spanish_ci NOT NULL,
  `slot8` text COLLATE utf8_spanish_ci NOT NULL,
  `slot9` text COLLATE utf8_spanish_ci NOT NULL,
  `slot10` text COLLATE utf8_spanish_ci NOT NULL,
  `slot11` text COLLATE utf8_spanish_ci NOT NULL,
  `slot12` text COLLATE utf8_spanish_ci NOT NULL,
  `slot13` text COLLATE utf8_spanish_ci NOT NULL,
  `slot14` text COLLATE utf8_spanish_ci NOT NULL,
  `slot15` text COLLATE utf8_spanish_ci NOT NULL,
  `slot16` text COLLATE utf8_spanish_ci NOT NULL,
  `slot17` text COLLATE utf8_spanish_ci NOT NULL,
  `slot18` text COLLATE utf8_spanish_ci NOT NULL,
  `slot19` text COLLATE utf8_spanish_ci NOT NULL,
  `slot20` text COLLATE utf8_spanish_ci NOT NULL,
  `Oro` int(11) NOT NULL,
  `Plata` int(11) NOT NULL,
  `Cobre` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `Inventario`
--

INSERT INTO `Inventario` (`id`, `slot1`, `slot2`, `slot3`, `slot4`, `slot5`, `slot6`, `slot7`, `slot8`, `slot9`, `slot10`, `slot11`, `slot12`, `slot13`, `slot14`, `slot15`, `slot16`, `slot17`, `slot18`, `slot19`, `slot20`, `Oro`, `Plata`, `Cobre`) VALUES
(0, 'Espada Corta (1d6, Cortante)', '10 x Dardos (1d4, Arrojadizo (12 Casillas))', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de cuerda', '', '', '', '', '', '', '', '', '', '', '', 5, 0, 0),
(1, 'Espada Corta (1d6, Cortante)', '10 x Dardos (1d4, Arrojadizo (12 Casillas))', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de cuerda', '', '', '', '', '', '', '', '', '', '', '', 10, 0, 0),
(2, 'Espada Larga (1d8 cortante)', 'Daga (1d4, Arrojadiza (12 Casillas))', 'Saco de dormir', '2 Trajes', '5 Velas', '1 Raciones', 'Odre (Botella de 1L de agua)', 'Kit de Disfraz (Maquillaje, tinte de pelo y accesorios de disfraz)', '', '', '', '', '', '', '', '', '', '', '', '', 15, 0, 0),
(3, 'Hacha de Batalla (1d8, Cortante)', 'Cimitarra (1d6, Contundente)', '2 Hachas de Mano (1d6 Cortante, Arrojadiza (12 Casillas))', 'Cota de Malla (CA 16 + Mod Con)', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de cuerda', '', '', '', '', '', '', '', '', '', 10, 0, 0),
(4, 'Bastón (1d6, Contundente)', 'Libro de Conjuros', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de cuerda', '', '', '', '', '', '', '', '', '', '', '', 0, 0, 0),
(5, 'Espada Larga (1d8, Cortante)', 'Escudo (+2 de AC mientras lo sujetes)', '5 Jabalinas (1d6 Cortante, Arrojadiza (24 casillas))', 'Cota de malla (AC 16 + Mod Con)', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de cuerda', 'Anillo de sello de tu casa y pergamino de pedigrí (Por ser un noble)', '', '', '', '', '', '', '', '', 25, 0, 0),
(6, '2 Espadas Cortas (1d6 Cortante)', 'Arco Grande (1d8 Perforante, A distancia())', 'Armadura de cuero (CA 11 + 2 Proficiencia + Mod Con)', '20 Flechas', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de cuerda', '', '', '', '', '', '', '', '', '', 5, 0, 0),
(7, 'Cimitarra (1d6, Contundente)', 'Escudo de Madera (CA +2)', 'Armadura de cuero (CA 11 + 2 Proficiencia + Mod Con)', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de cuerda', '', '', '', '', '', '', '', '', '', '', 5, 0, 0),
(8, 'Espada Corta (1d6, Cortante)', '2 Dagas (1d4 perforante, Arrojadiza (12 Casillas))', 'Armadura de cuero (CA 11 + 2 Proficiencia + Mod Con)', 'Herramientas de ladrón', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de Cuerda', '', '', '', '', '', '', '', '', '', 15, 0, 0),
(9, 'Gran Hacha (1d12 Cortante)', '2 Hachas de Mano (1d6 Cortante, Arrojadiza (12 Casillas))', '4 Jabalinas (1d6 Cortante, Arrojadiza (24 casillas))', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de Cuerda', '', '', '', '', '', '', '', '', '', '', 15, 0, 0),
(10, 'Maza (1d6 contundente)', 'Cota de Escamas (14 + Mod Des)', 'Escudo (CA + 2)', 'Ballesta Ligera (1d8 perforante)', '20 Virotes de Ballesta', 'Saco de Dormir', 'Equipo de cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de Cuerdas', '', '', '', '', '', '', '', '', 10, 0, 0),
(11, 'Bastón (1d6, Contundente)', '2 Dagas (1d4 Perforante, Arrojadiza (12 Casillas))', 'Saco de Dormir', 'Equipo de Cocina', 'Yesquero', '10 Antorchas', '10 Raciones', 'Odre (Botella de 1L de agua)', '50 Pies de Cuerda', '', '', '', '', '', '', '', '', '', '', '', 10, 0, 0),
(12, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0, 0, 0),
(13, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0, 0, 0),
(14, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `skills`
--

CREATE TABLE `skills` (
  `id` int(11) NOT NULL,
  `Acrobacia` int(11) NOT NULL,
  `Atletismo` int(11) NOT NULL,
  `ConArcano` int(11) NOT NULL,
  `Engano` int(11) NOT NULL,
  `Historia` int(11) NOT NULL,
  `Interpretacion` int(11) NOT NULL,
  `Intimidacion` int(11) NOT NULL,
  `Investigacion` int(11) NOT NULL,
  `JuegoManos` int(11) NOT NULL,
  `Medicina` int(11) NOT NULL,
  `Naturaleza` int(11) NOT NULL,
  `Percepcion` int(11) NOT NULL,
  `Perspicacia` int(11) NOT NULL,
  `Persuasion` int(11) NOT NULL,
  `Religion` int(11) NOT NULL,
  `Sigilo` int(11) NOT NULL,
  `Supervivencia` int(11) NOT NULL,
  `Trato Animales` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `skills`
--

INSERT INTO `skills` (`id`, `Acrobacia`, `Atletismo`, `ConArcano`, `Engano`, `Historia`, `Interpretacion`, `Intimidacion`, `Investigacion`, `JuegoManos`, `Medicina`, `Naturaleza`, `Percepcion`, `Perspicacia`, `Persuasion`, `Religion`, `Sigilo`, `Supervivencia`, `Trato Animales`) VALUES
(0, 3, 1, 2, -1, 2, -1, -1, 2, 3, 1, 2, 1, 1, -1, 2, 3, 1, 1),
(1, 5, 0, -1, 1, -1, 1, 1, -1, 3, 0, -1, 4, 2, 1, 1, 5, 2, 2),
(2, 4, 0, 0, 5, 0, 5, 5, 0, 4, 3, 0, 1, 3, 3, 0, 2, 1, 1),
(3, 2, 5, 0, -1, 0, -1, -1, 0, 2, 1, 0, 1, 1, -1, 0, 4, 3, 3),
(4, 2, 1, 5, -1, 5, -1, -1, 5, 2, 4, 3, 2, 2, -1, 3, 2, 2, 2),
(5, -1, 3, 1, 3, 3, 3, 3, 1, -1, 1, 1, 1, 3, 5, 3, -1, 1, 1),
(6, 4, 3, -1, 1, -1, 1, 1, -1, 4, 2, -1, 2, 4, 1, -1, 6, 4, 4),
(7, 2, -1, 0, 1, 0, 1, 1, 0, 2, 3, 0, 3, 3, 1, 0, 2, 3, 3),
(8, 4, 2, 1, 4, 1, 2, 2, 1, 8, -1, 1, 1, -1, 2, 1, 8, 1, 1),
(9, 2, 3, 0, 0, 0, 0, 0, 0, 2, 1, 0, 1, 1, 0, 0, 2, 1, 1),
(10, 0, 2, -1, 1, 2, 1, 1, -1, 0, 3, -1, 3, 6, 4, 2, 0, 3, 3),
(11, 1, 0, 2, 5, 0, 3, 5, 0, 1, 3, 0, 1, 0, 3, 2, 1, 1, 1),
(12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stats`
--

CREATE TABLE `stats` (
  `ID` int(11) NOT NULL,
  `Nombre` text COLLATE utf8_spanish_ci NOT NULL,
  `Clase` text COLLATE utf8_spanish_ci NOT NULL,
  `Nivel` int(11) NOT NULL,
  `PX` int(11) NOT NULL,
  `PXActuales` int(11) NOT NULL,
  `Iniciativa` int(11) NOT NULL,
  `Velocidad` int(11) NOT NULL,
  `CA` int(11) NOT NULL,
  `PV` bigint(20) NOT NULL,
  `PVActuales` int(11) NOT NULL,
  `Fuerza` int(11) NOT NULL,
  `Destreza` int(11) NOT NULL,
  `Constitucion` int(11) NOT NULL,
  `Inteligencia` int(11) NOT NULL,
  `Sabiduria` int(11) NOT NULL,
  `Carisma` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `stats`
--

INSERT INTO `stats` (`ID`, `Nombre`, `Clase`, `Nivel`, `PX`, `PXActuales`, `Iniciativa`, `Velocidad`, `CA`, `PV`, `PVActuales`, `Fuerza`, `Destreza`, `Constitucion`, `Inteligencia`, `Sabiduria`, `Carisma`) VALUES
(0, 'Dante', 'Monje', 1, 300, 0, 3, 30, 14, 9, 9, 12, 17, 12, 14, 13, 8),
(1, 'Balyarus', 'Monje', 1, 300, 0, 3, 35, 15, 10, 10, 10, 17, 14, 8, 14, 12),
(2, 'Galdor', 'Bardo', 1, 300, 0, 2, 30, 13, 10, 10, 10, 14, 14, 10, 12, 17),
(3, 'Rynmora', 'Guerrero', 1, 300, 0, 3, 25, 18, 13, 13, 16, 14, 16, 10, 12, 8),
(4, 'Ro', 'Mago', 1, 300, 0, 2, 30, 12, 8, 8, 12, 14, 16, 16, 12, 8),
(5, 'Gii', 'Paladín', 1, 300, 0, -1, 30, 18, 12, 12, 16, 8, 14, 12, 12, 16),
(6, 'Zalorin', 'Explorador', 1, 300, 0, 3, 25, 14, 11, 11, 12, 18, 12, 8, 14, 12),
(7, 'Raloris', 'Druida', 1, 300, 0, 2, 25, 15, 10, 10, 8, 14, 14, 10, 16, 13),
(8, 'Percan', 'Pícaro', 1, 300, 0, 3, 30, 15, 9, 9, 10, 18, 14, 12, 8, 14),
(9, 'Luzna', 'Barbaro', 1, 300, 0, 2, 30, 15, 14, 14, 16, 14, 16, 10, 12, 10),
(10, 'Regnum', 'Clérigo', 1, 300, 0, 0, 25, 14, 11, 11, 14, 10, 16, 8, 17, 12),
(11, 'Wrahadur', 'Hechicero', 1, 300, 0, 1, 30, 14, 9, 9, 10, 13, 14, 10, 12, 16),
(12, '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(13, '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(14, '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tirSalvacion`
--

CREATE TABLE `tirSalvacion` (
  `id` int(11) NOT NULL,
  `Fuerza` int(11) NOT NULL,
  `Destreza` int(11) NOT NULL,
  `Constitucion` int(11) NOT NULL,
  `Inteligencia` int(11) NOT NULL,
  `Sabiduria` int(11) NOT NULL,
  `Carisma` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `tirSalvacion`
--

INSERT INTO `tirSalvacion` (`id`, `Fuerza`, `Destreza`, `Constitucion`, `Inteligencia`, `Sabiduria`, `Carisma`) VALUES
(0, 3, 5, 1, 2, 1, -1),
(1, 2, 5, 2, -1, 2, 1),
(2, 0, 4, 2, 0, 1, 5),
(3, 5, 2, 5, 0, 1, 1),
(4, 1, 2, 3, 5, 4, -1),
(5, 3, -1, 2, 1, 3, 5),
(6, 3, 6, 1, -1, 2, 1),
(7, -1, 2, 2, 2, 5, 1),
(8, 0, 6, 2, 3, -1, 2),
(9, 5, 2, 5, 0, 1, 0),
(10, 2, 0, 3, -1, 6, 4),
(11, 0, 1, 4, 0, 1, 5),
(12, 0, 0, 0, 0, 0, 0),
(13, 0, 0, 0, 0, 0, 0),
(14, 0, 0, 0, 0, 0, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `Inventario`
--
ALTER TABLE `Inventario`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indices de la tabla `skills`
--
ALTER TABLE `skills`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indices de la tabla `stats`
--
ALTER TABLE `stats`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- Indices de la tabla `tirSalvacion`
--
ALTER TABLE `tirSalvacion`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
