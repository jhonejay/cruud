-- phpMyAdmin SQL Dump
-- version 3.5.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Sep 12, 2017 at 02:30 AM
-- Server version: 5.5.25a
-- PHP Version: 5.4.4

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `seminar`
--

-- --------------------------------------------------------

--
-- Table structure for table `loantype`
--

CREATE TABLE IF NOT EXISTS `loantype` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(50) NOT NULL,
  `term` int(10) NOT NULL,
  `interest` decimal(10,2) NOT NULL,
  `paymentterm` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `loantype`
--

INSERT INTO `loantype` (`id`, `description`, `term`, `interest`, `paymentterm`) VALUES
(2, '11', 11, 4.00, '11'),
(3, '66', 66, 66.00, '66'),
(4, '33', 33, 33.00, '33'),
(6, '88', 88, 88.00, '88');

-- --------------------------------------------------------

--
-- Table structure for table `prepaidcards`
--

CREATE TABLE IF NOT EXISTS `prepaidcards` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cableType` varchar(30) NOT NULL,
  `amount` decimal(11,2) NOT NULL,
  `pin` varchar(30) NOT NULL,
  `status` varchar(30) NOT NULL,
  `date_registered` varchar(30) NOT NULL,
  `date_expired` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `prepaidcards`
--

INSERT INTO `prepaidcards` (`id`, `cableType`, `amount`, `pin`, `status`, `date_registered`, `date_expired`) VALUES
(4, 'GSAT', 500.00, '363463', 'Pending', '2017-03-16 15:43:05.943199', '2017-03-16 15:43:05.941199'),
(5, 'SKY', 2300.00, '23423215', 'Pending', '2017-03-16 15:43:05 ', '2017-03-16 15:43:05 ');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
