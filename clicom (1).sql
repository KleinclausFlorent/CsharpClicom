-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 05 mars 2019 à 10:56
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `clicom`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `NCLI` char(10) NOT NULL,
  `NOM` char(32) NOT NULL,
  `ADRESSE` char(60) NOT NULL,
  `LOCALITE` char(30) NOT NULL,
  `CAT` char(2) DEFAULT NULL,
  `COMPTE` decimal(9,2) NOT NULL,
  PRIMARY KEY (`NCLI`),
  KEY `CLINCLI` (`NCLI`),
  KEY `CLINOM` (`NOM`),
  KEY `CLILOC` (`LOCALITE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`NCLI`, `NOM`, `ADRESSE`, `LOCALITE`, `CAT`, `COMPTE`) VALUES
('B062', 'GOFFIN', '72, r. de la Gare', 'Namur', 'B2', '-3200.00'),
('B112', 'HANSENNE', '23, r. Dumont', 'Poitiers', 'C1', '-1250.00'),
('B332', 'MONTI', '112, r. Neuve', 'Genève', 'B2', '0.00'),
('B512', 'GILLET', '14, r. de l\'été', 'Toulouse', 'B1', '-8700.00'),
('C003', 'AVRON', '8, r. de la Cure', 'Toulouse', 'B1', '-1700.00'),
('C123', 'MERCIER', '25, r. Lamaître', 'Namur', 'C1', '-2300.00'),
('C400', 'FERARD', '65, r. du Tertre', 'Poitiers', 'B2', '350.00'),
('D063', 'MERCIER', '201, bvd du Nord', 'Toulouse', NULL, '-2250.00'),
('F010', 'TOUSSAINT', '5, r. Godefroid', 'Poitiers', 'C1', '0.00'),
('F011', 'PONCELET', '17, Clos des Erables', 'Toulouse', 'B2', '0.00'),
('F400', 'JACOB', '78, ch. du Moulin', 'Bruxelles', 'C2', '0.00'),
('K111', 'VANBIST', '180, r. Florimont', 'Lille', 'B1', '720.00'),
('K729', 'NEUMAN', '40, r. Bransart', 'Toulouse', NULL, '0.00'),
('L422', 'FRANCK', '60, r. de Wépion', 'Namur', 'C1', '0.00'),
('S127', 'VANDERKA', '3, av. des Roses', 'Namur', 'C1', '-4580.00'),
('S712', 'GUILLAUME', '14a, ch. des Roses', 'Paris', 'B1', '0.00');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `NCOM` char(12) NOT NULL,
  `NCLI` char(10) NOT NULL,
  `DATECOM` date NOT NULL,
  PRIMARY KEY (`NCOM`),
  KEY `COMNCOM` (`NCOM`),
  KEY `COMNOM` (`NCLI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`NCOM`, `NCLI`, `DATECOM`) VALUES
('30178', 'K111', '2008-12-21'),
('30179', 'C400', '2008-12-22'),
('30182', 'S127', '2008-12-23'),
('30184', 'C400', '2008-12-23'),
('30185', 'F011', '2009-01-02'),
('30186', 'C400', '2009-01-02'),
('30188', 'B512', '2009-01-03');

-- --------------------------------------------------------

--
-- Structure de la table `detail`
--

DROP TABLE IF EXISTS `detail`;
CREATE TABLE IF NOT EXISTS `detail` (
  `NCOM` char(12) NOT NULL,
  `NPRO` char(15) NOT NULL,
  `QCOM` decimal(8,0) NOT NULL,
  PRIMARY KEY (`NCOM`,`NPRO`),
  KEY `DETCOMPRO` (`NCOM`,`NPRO`),
  KEY `DETPRO` (`NPRO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `detail`
--

INSERT INTO `detail` (`NCOM`, `NPRO`, `QCOM`) VALUES
('30178', 'CS464', '25'),
('30179', 'CS262', '60'),
('30179', 'PA60', '20'),
('30182', 'PA60', '30'),
('30184', 'CS464', '120'),
('30184', 'PA45', '20'),
('30185', 'CS464', '260'),
('30185', 'PA60', '15'),
('30185', 'PS222', '600'),
('30186', 'PA45', '3'),
('30188', 'CS464', '180'),
('30188', 'PA45', '2'),
('30188', 'PA60', '70'),
('30188', 'PH222', '92');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `NPRO` char(15) NOT NULL,
  `LIBELLE` char(60) NOT NULL,
  `PRIX` decimal(6,0) NOT NULL,
  `QSTOCK` decimal(8,0) NOT NULL,
  PRIMARY KEY (`NPRO`),
  KEY `PRONPRO` (`NPRO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`NPRO`, `LIBELLE`, `PRIX`, `QSTOCK`) VALUES
('CS262', 'CHEV. SAPIN 200x6x2', '75', '45'),
('CS264', 'CHEV. SAPIN 200x6x4', '120', '2690'),
('CS464', 'CHEV. SAPIN 400x6x2', '220', '450'),
('PA45', 'POINTE ACIER 45 (2K)', '105', '580'),
('PA60', 'POINTE ACIER 60 (1K)', '95', '134'),
('PH222', 'PL. HETRE 200*20*2', '230', '782'),
('PS222', 'PL. SAPIN 200*20*2', '185', '1220');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`NCLI`) REFERENCES `client` (`NCLI`);

--
-- Contraintes pour la table `detail`
--
ALTER TABLE `detail`
  ADD CONSTRAINT `detail_ibfk_1` FOREIGN KEY (`NCOM`) REFERENCES `commande` (`NCOM`),
  ADD CONSTRAINT `detail_ibfk_2` FOREIGN KEY (`NPRO`) REFERENCES `produit` (`NPRO`),
  ADD CONSTRAINT `detail_ibfk_3` FOREIGN KEY (`NCOM`) REFERENCES `commande` (`NCOM`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
