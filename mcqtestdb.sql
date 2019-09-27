-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Sep 27, 2019 at 02:55 PM
-- Server version: 5.7.26
-- PHP Version: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mcqtestdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `studentanswer`
--

DROP TABLE IF EXISTS `studentanswer`;
CREATE TABLE IF NOT EXISTS `studentanswer` (
  `username` varchar(10) NOT NULL,
  `testId` int(4) NOT NULL,
  `questionNum` int(2) NOT NULL,
  `answerChar` char(1) NOT NULL,
  PRIMARY KEY (`username`,`testId`,`questionNum`),
  KEY `testId` (`testId`),
  KEY `questionNum` (`questionNum`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studentanswer`
--

INSERT INTO `studentanswer` (`username`, `testId`, `questionNum`, `answerChar`) VALUES
('18016900', 1, 3, 'c'),
('18016900', 1, 2, 'a'),
('18016900', 1, 1, 'b'),
('18016900', 3, 1, 'a'),
('18016900', 3, 2, 'b'),
('18016900', 3, 3, 'c'),
('18016900', 5, 4, 'b'),
('18016900', 5, 3, 'b'),
('18016900', 5, 2, 'c'),
('18016900', 5, 1, 'b'),
('18016901', 5, 1, 'b'),
('18016901', 5, 2, 'a'),
('18016901', 5, 3, 'c'),
('18016901', 5, 4, 'b');

-- --------------------------------------------------------

--
-- Table structure for table `studenttest`
--

DROP TABLE IF EXISTS `studenttest`;
CREATE TABLE IF NOT EXISTS `studenttest` (
  `username` varchar(10) NOT NULL,
  `testId` int(4) NOT NULL,
  `markObtained` int(3) NOT NULL,
  `percentageObtained` int(3) NOT NULL,
  `attempts` int(2) DEFAULT '0',
  PRIMARY KEY (`username`,`testId`),
  KEY `testId` (`testId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studenttest`
--

INSERT INTO `studenttest` (`username`, `testId`, `markObtained`, `percentageObtained`, `attempts`) VALUES
('18016900', 1, 3, 100, 2),
('18016900', 3, 2, 66, 1),
('18016900', 5, 2, 50, 2),
('18016901', 5, 1, 25, 1);

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

DROP TABLE IF EXISTS `test`;
CREATE TABLE IF NOT EXISTS `test` (
  `testId` int(4) NOT NULL AUTO_INCREMENT,
  `testName` varchar(50) NOT NULL,
  `attempts` int(1) NOT NULL,
  PRIMARY KEY (`testId`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `test`
--

INSERT INTO `test` (`testId`, `testName`, `attempts`) VALUES
(1, 'ACC_Test_1', 3),
(3, 'Prog Test 1', 1),
(5, 'Arrays', -1);

-- --------------------------------------------------------

--
-- Table structure for table `testanswer`
--

DROP TABLE IF EXISTS `testanswer`;
CREATE TABLE IF NOT EXISTS `testanswer` (
  `testId` int(4) NOT NULL,
  `questionNum` int(2) NOT NULL,
  `answerChar` char(1) NOT NULL,
  `answerText` varchar(255) NOT NULL,
  PRIMARY KEY (`testId`,`questionNum`,`answerChar`),
  KEY `questionNum` (`questionNum`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `testanswer`
--

INSERT INTO `testanswer` (`testId`, `questionNum`, `answerChar`, `answerText`) VALUES
(1, 1, 'a', 'A naming word'),
(1, 1, 'b', 'A resource owned or controlled by the co...'),
(1, 1, 'c', 'A shareholders interest in the company'),
(1, 2, 'a', 'a full 12 months'),
(1, 2, 'b', 'a full 18 months'),
(1, 2, 'c', 'depends on the company'),
(1, 3, 'a', 'appreciates'),
(1, 3, 'b', 'stays the same'),
(1, 3, 'c', 'depreciates'),
(3, 1, 'c', 'null'),
(3, 1, 'b', 'An empty space, i.e '),
(3, 1, 'a', '0'),
(3, 2, 'a', 'dict.1'),
(3, 2, 'c', 'dict[1]'),
(3, 2, 'b', 'dict.pull(1)'),
(3, 3, 'a', 'Is nullable'),
(3, 3, 'b', 'Is a reference type'),
(3, 3, 'c', 'Takes only upto 255 characters'),
(5, 3, 'b', '0'),
(5, 3, 'a', '-1'),
(5, 2, 'c', 'it depends'),
(5, 2, 'b', 'false'),
(5, 2, 'a', 'true'),
(5, 1, 'c', 'as many as you need'),
(5, 1, 'b', '2'),
(5, 1, 'a', '1'),
(5, 3, 'c', '1'),
(5, 4, 'a', 'primitive type'),
(5, 4, 'b', 'reference type'),
(5, 4, 'c', 'depends on the array type');

-- --------------------------------------------------------

--
-- Table structure for table `testquestion`
--

DROP TABLE IF EXISTS `testquestion`;
CREATE TABLE IF NOT EXISTS `testquestion` (
  `testId` int(4) NOT NULL,
  `questionNum` int(2) NOT NULL,
  `questionText` varchar(500) NOT NULL,
  `correctAnswer` char(1) NOT NULL,
  PRIMARY KEY (`testId`,`questionNum`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `testquestion`
--

INSERT INTO `testquestion` (`testId`, `questionNum`, `questionText`, `correctAnswer`) VALUES
(1, 1, 'What is an asset?', 'b'),
(1, 2, 'How long is a financial year?', 'a'),
(1, 3, 'With regards to the value of a vehicle, it', 'c'),
(3, 1, 'What is the default value of an integer datatype?', 'a'),
(3, 2, 'How do you access the value of this variable:\nDictionary<int, int> dict = new Dictionary(){{1, 1997}}', 'c'),
(3, 3, 'Which is not true with regards to string datatype', 'c'),
(5, 2, 'An array can only be of primitive data types', 'b'),
(5, 1, 'How many dimenssions can an array have?', 'c'),
(5, 3, 'The 1st element of the array as an index of', 'b'),
(5, 4, 'An array is a...', 'b');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(10) NOT NULL,
  `firstName` varchar(30) NOT NULL,
  `surname` varchar(30) NOT NULL,
  `uPassword` varchar(100) NOT NULL,
  `userType` char(1) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `firstName`, `surname`, `uPassword`, `userType`) VALUES
('1001001', 'Registra', 'Office', 'pass73', 'r'),
('10177', 'Jimmy', 'Winfrey', 'password', 'l'),
('18016900', 'Goofy', 'McNoodles', 'password', 's'),
('18016901', 'Sheldon', 'Cooper', 'password', 's');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
