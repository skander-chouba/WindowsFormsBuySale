-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 08, 2020 at 11:34 PM
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
-- Database: `venteachat`
--

-- --------------------------------------------------------

--
-- Table structure for table `advert`
--

DROP TABLE IF EXISTS `advert`;
CREATE TABLE IF NOT EXISTS `advert` (
  `id_ad` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `price` float NOT NULL,
  `phone_number` int(11) NOT NULL,
  `image` mediumblob NOT NULL,
  `description` varchar(500) NOT NULL,
  `namecat` varchar(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`id_ad`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `advert`
--

INSERT INTO `advert` (`id_ad`, `name`, `price`, `phone_number`, `image`, `description`, `namecat`, `status`) VALUES
(1, 'Test', 999999, 25597886, 0x89504e470d0a1a0a0000000d49484452000000320000003208060000001e3f88b1000000017352474200aece1ce90000000467414d410000b18f0bfc61050000046e494441546843ed9a47abd5501446afd87b6f439dd950fc05eac0decbc03653d1890d1d2858d09965262afe0b3b2a2a2a2a8add81dd896d200a16eced5be16eb8e42539e7e426f7c9e37db07837a7ed24a7edb3f32aad6ac1ea23e6883de2847824de8b1f55f84d1a7994992d7a8bff429dc4527146fc167f03f9254e892582b61aae2e6283782deca6be8ab3628be06d0f13bcf1f6a243f5f77041de56715e7c13569fb6d68bcea2219a2e9e0bbb819b62b9e82942d54bac10b784b5f74c4c15a58937754898c1db62b228426dc414714758fb0744e1c36db0e0c631f045ac166d45d16a27d60a8629b6e8ed41a2100d1574370d3f14a344d91a2d58e1b0896deea12e0d108f050d5e17fd44a3c4727e59d8c3e4ee19e6840da7aba29bf0152f60a7a0fee72afc26adbff01536af09eee186c835676c62339cfa92e0a9f9e2a3a06e121fc43ce12b46818d8afd24848825968a4cec9039b140fc11d43d2cc689ae55c68b23823cca843ccc18610b80f74ac990b27d82d5c9570c27eb894d24a468b3a00c3d1332ccd82ca9f754780d31766c2ab049852cb18c7fead1132e1d1594dd115df989a5f99ea0de3a12b2d451bc12149e444280ee0aea319c5c9a2028cb0210221bf26f4466afe0bc51901522549f04757d56b7ee82b2d409111e80ada48b4848135e2c8596455761a21ef82ab4bc6995a0dec9e82a416c40b8d5ac0e791cc0463d085ef477f15324dee75c41c3b8e22e5d1276234543db2e5d10949d195dc5b45790c979c2a55ac365e0d27641b9ddd1554c1c41c94c7cca987c0d86cab75d8ed49463196fa227824c4e762ef91a0c956fbb2304e5f0909be89d209349ef92192c0b97f0bf28f736ba8a8995804cced72ed51a2d0397d8b829c799bf89f23c4896e265f2d44953e683e4195a598a97c953274d389b944b1c5a7926bb0fa6a4bc345cca9cecb6fcce8aaeb2556bd48529292f0d976cf34e5c7e09639249f0cc251f83f13279eaa4c936c45dd1554cb6c99c8baeb2e563305e264f9d345d14949b115dc5843386d3c84a4004304b66b02cb2c46294e934a2d38286086366296eb868b2646efcf1e82a4576b0e298cb21264d3e06f3c8d52ef76461d58524a4a9f6a84b2c364d2e8379e56a178796fc17827bcd94452b78720efc4932836591243e4fdc17e4af21c125c24116eb25a09ca4e638586d14e413ac73f68689ef1354e2d84b40b9b93556d847a1d0e84ee5a0b037d0c8e0755cf85504e5b8977d24848ab811df27688040724810bb286193af00dc037fbd87545cbc0dfb4e41432121ce7ac5c67745609b393b50d4253eb258d732cc0828972de684d9c42b1f220a111f59883ed2300b004b74dad25c8f5862893ddbc46614d4dd13713167f83e810120d63b4d647900bea20d1c40db2780899d7b4ef888ef1376080362b12b459eff62601ee03b593c1718be13454344efb0599a3b0378a44400b7090e3e9ce2f8d2450c00f83d5290c7790257dce204f052b06397da0b69c2e8624140992380dd942fb8e278b13880cdf20049e26c80534718f39878200868f0d681dfa4713ce564c79ce8215ad50255a9fc038b4d5a4792d84d6b0000000049454e44ae426082, 'fuck yeah', 'Chouba', 'Accept');
INSERT INTO `advert` (`id_ad`, `name`, `price`, `phone_number`, `image`, `description`, `namecat`, `status`) VALUES

-- --------------------------------------------------------

--
-- Table structure for table `authentification`
--

DROP TABLE IF EXISTS `authentification`;
CREATE TABLE IF NOT EXISTS `authentification` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `emailaddress` varchar(100) NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `usertype` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `login` (`login`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `authentification`
--

INSERT INTO `authentification` (`id`, `firstname`, `lastname`, `emailaddress`, `login`, `password`, `usertype`) VALUES
(1, 'Skander', 'Chouba', 'skander.chouba@gmail.com', 'SChouba', '8191', 'user'),
(2, 'Skander', 'Chouba', 'skander.chouba@gmail.com', 'admin', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
CREATE TABLE IF NOT EXISTS `category` (
  `id_cat` int(11) NOT NULL,
  `name_cat` varchar(100) NOT NULL,
  PRIMARY KEY (`id_cat`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id_cat`, `name_cat`) VALUES
(1, 'Man of Wisdom'),
(2, 'Chouba');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;