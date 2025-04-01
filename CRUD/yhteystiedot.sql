-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 17, 2025 at 07:38 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `opiskelijat`
--

-- --------------------------------------------------------

--
-- Table structure for table `yhteystiedot`
--

CREATE TABLE `yhteystiedot` (
  `Oid` int(11) NOT NULL,
  `etunimi` varchar(35) NOT NULL,
  `sukunimi` varchar(40) NOT NULL,
  `puhelin` varchar(20) NOT NULL,
  `sähköposti` varchar(65) NOT NULL,
  `opiskelijanumero` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `yhteystiedot`
--

INSERT INTO `yhteystiedot` (`Oid`, `etunimi`, `sukunimi`, `puhelin`, `sähköposti`, `opiskelijanumero`) VALUES
(1, 'Rina', 'Ratiyapinan', '123456789', 'rina.ratiyapinan@edu.keuda.fi', 54321),
(2, 'Miki', 'Parviainen', '987654321', 'miki.parviainen@edu.keuda.fi', 65432),
(4, 'Kaisa', 'MMMMMMM', '5555566666', 'kaisa.mmmmmm@edu.keuda.fi', 76543),
(6, 'Eeli', 'bbbbb', '54856325', 'eeli.bbbbb@edu.keuda.fi', 536241);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `yhteystiedot`
--
ALTER TABLE `yhteystiedot`
  ADD PRIMARY KEY (`Oid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `yhteystiedot`
--
ALTER TABLE `yhteystiedot`
  MODIFY `Oid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
