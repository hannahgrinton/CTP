-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jul 03, 2020 at 04:17 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbCTP`
--
USE dbCTP;
-- --------------------------------------------------------

--
-- Table structure for table `booklets`
--

CREATE TABLE `booklets` (
  `id` int(11) NOT NULL,
  `code` varchar(10) NOT NULL,
  `title` varchar(200) NOT NULL,
  `author` varchar(200) NOT NULL,
  `price` varchar(10) NOT NULL,
  `frontcover` varchar(100) NOT NULL,
  `backcover` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `booklets`
--

INSERT INTO `booklets` (`id`, `code`, `title`, `author`, `price`, `frontcover`, `backcover`) VALUES
(1, 'P-401', 'All Things That Pertain to Life and Godliness (39 pages)', 'Bruce Anstey', '3.95', 'booklet3cover.png', 'booklet3back.png'),
(2, 'P-402', 'Backsliding and Restoration (with chart - \"Ten Differences Between Priesthood and Advocacy\"(48 pages)', 'Bruce Anstey', '3.95', 'booklet27cover.png', 'booklet27back.png'),
(3, 'SB-403', 'Born Again (16 pages)', 'Bruce Anstey', '1.95', 'booklet78cover.png', 'booklet78back.png'),
(4, 'P-404', 'Christian Consecration (34 pages) ', 'Bruce Anstey', '3.95', 'booklet28cover.png', 'booklet28back.png'),
(5, 'P-405', 'Christian Perfection in Three Ways (39 pages)', 'Bruce Anstey', '3.95', 'booklet16cover.png', 'booklet16back.png'),
(6, 'P-406', 'Christian’s Three Enemies, The (39 pages)', 'Bruce Anstey', '3.95', 'booklet29cover.png', 'booklet29back.png'),
(7, 'P-407', 'Church Seen Under Twelve Figures in the N. T., The (15 pages)', 'Bruce Anstey', '1.95', 'booklet30cover.png', 'booklet30back.png'),
(8, 'P-408', 'Church Will Not Go Through the Tribulation (32 pages)', 'Bruce Anstey', '3.95', 'booklet31cover.png', 'booklet31back.png'),
(9, 'P-409', 'Companionship, Part 1 (36 pages)', 'Bruce Anstey', '3.95', 'booklet1cover.png', 'booklet1back.png'),
(10, 'P-410', 'Companionship, Part 2 (32 pages)', 'Bruce Anstey', '3.95', 'booklet2cover.png', 'booklet2back.png'),
(11, 'P-473', 'Covenant Theology or \"Is This Method of Interpretation Scripturally Sound?\" (15 pages)', 'Bruce Anstey', '1.95', 'booklet32cover.png', 'booklet32back.png'),
(12, 'P-411', 'Daniel-The Secret of Overcoming (36 pages)', 'Bruce Anstey', '3.95', 'booklet33cover.png', 'booklet33back.png'),
(13, 'P-412', 'Death, the Intermediate State and Resurrection, 2nd ed (31 pages)', 'Bruce Anstey', '2.95', 'booklet7cover.png', 'booklet7back.png'),
(14, 'P-413', 'Discipleship—its Terms, Tests, and Rewards (36 pages)', 'Bruce Anstey', '3.95', 'booklet8cover.png', 'booklet8back.png'),
(15, 'P-414', 'Dispensations and Ages (12 pages)', 'Bruce Anstey', '1.95', 'booklet13cover.png', 'booklet13back.png'),
(16, 'P-415', 'Esther, A Prophetic Application (12 pages)', 'Bruce Anstey', '1.95', 'booklet35cover.png', 'booklet35back.png'),
(17, 'P-416', 'Eternal Security of the Believer (52 pages)', 'Bruce Anstey', '3.95', 'booklet10cover.png', 'booklet10back.png'),
(18, 'SB-417', 'Eternal Sonship of Christ (27 pages)', 'Bruce Anstey', '2.95', 'booklet36cover.png', 'booklet36back.png'),
(19, 'SB-418', 'Everlasting Gospel, The (16 pages)', 'Bruce Anstey', '1.95', 'booklet37cover.png', 'booklet37back.png'),
(20, 'SB-419', 'Forsaking of Christ, The  (10 pages)', 'Bruce Anstey', '1.95', 'booklet79cover.png', 'booklet79back.png'),
(21, 'P-420', 'Four Reasons Why Christ Became a Man, Suffered and Died (10 pages)', 'Bruce Anstey', '1.95', 'booklet11cover.png', 'booklet11back.png'),
(22, 'P-421', 'Gap in Genesis 1 (22 pages)', 'Bruce Anstey', '2.95', 'booklet20cover.png', 'booklet20back.png'),
(23, 'P-422', 'Gap - Letters Between Two Brothers (14 pages)', 'Bruce Anstey', '1.95', 'booklet80cover.png', 'booklet80back.png'),
(24, 'SB-423', 'Gathered to the Lord\'s Name (8 pages)', 'Bruce Anstey', '1.95', 'booklet81cover.png', 'booklet81back.png'),
(25, 'SB-424', 'Glories of Christ, The (14 pages)', 'Bruce Anstey', '1.95', 'booklet39cover.png', 'booklet39back.png'),
(26, 'P-425', 'How God Makes Us Willing (32 pages)', 'Bruce Anstey', '3.95', 'booklet40cover.png', 'booklet40back.png'),
(27, 'P-426', 'How to Know the Will of God for Your Life, Part 1 (24 pages)', 'Bruce Anstey', '2.95', 'booklet22cover.png', 'booklet22back.png'),
(28, 'P-427', 'How to Know the Will of God for Your Life, Part 2 (31 pages)', 'Bruce Anstey', '2.95', 'booklet21cover.png', 'booklet21back.png'),
(29, 'P-428', 'Importance of Having a Right Spirit (27 pages)', 'Bruce Anstey', '2.95', 'booklet82cover.png', 'booklet82back.png'),
(30, 'SB-429', 'Joys of Christ (13 pages)', 'Bruce Anstey', '1.95', 'booklet42cover.png', 'booklet42back.png'),
(31, 'P-430', 'Judgment Seat of Christ (39 pages)', 'Bruce Anstey', '3.95', 'booklet23cover.png', 'booklet23back.png'),
(32, 'P-431', 'Key to Progress As Seen in the Life of Ruth (27 pages)', 'Bruce Anstey', '2.95', 'booklet5cover.png', 'booklet5back.png'),
(33, 'P-432', 'Kingdom of the Heavens - the Kingdom of God - with chart (36 pages)', 'Bruce Anstey', '3.95', 'booklet43cover.png', 'booklet43back.png'),
(34, 'P-433', 'The KLC Re-Union Principles Examined - a series of letters (20 pages)', 'Bruce Anstey', '1.95', 'booklet9cover.png', 'booklet9back.png'),
(35, 'P-436', 'Lessons From the Life of Samson (40 pages)', 'Bruce Anstey', '3.95', 'booklet18cover.png', 'booklet18back.png'),
(36, 'P-434', 'Lessons From the Lives of Abraham and Lot (21 pages)', 'Bruce Anstey', '2.95', 'booklet26cover.png', 'booklet26back.png'),
(37, 'P-435', 'Lessons From the Lives of David and Jonathan (32 pages)', 'Bruce Anstey', '3.95', 'booklet34cover.png', 'booklet34back.png'),
(38, 'P-437', 'Lord’s Coming and Its Practical Effects (33 pages)', 'Bruce Anstey', '3.95', 'booklet44cover.png', 'booklet44back.png'),
(39, 'C-438', 'Major Tenets of Paul\'s Gospel (Leaflet)', 'Bruce Anstey', '.95', 'booklet83cover.png', 'booklet83sample.png'),
(40, 'P-439', 'Making Room for God’s Blessing in Your Life (31 pages) ', 'Bruce Anstey', '2.95', 'booklet45cover.png', 'booklet45back.png'),
(41, 'SB-440', 'Moral Beauties of Christ -The Anti-type of the Meal Offering - Lev. 2 (8 pages)', 'Bruce Anstey', '1.95', 'booklet46cover.png', 'booklet46back.png'),
(42, 'SB-441', 'Mysteries of God (14 pages)', 'Bruce Anstey', '1.95', 'booklet47cover.png', 'booklet47back.png'),
(43, 'P-442', 'Nehemiah - Encouragement in Remnant Testimony Days - with charts (12 pages)', 'Bruce Anstey', '1.95', 'booklet48cover.png', 'booklet48back.png'),
(44, 'SB-443', 'New Creation Race (12 pages)', 'Bruce Anstey', '1.95', 'booklet49cover.png', 'booklet49back.png'),
(45, 'P-444', 'NIV—Tested for Doctrinal Accuracy (40 pages)', 'Bruce Anstey', '3.95', 'booklet50cover.png', 'booklet50back.png'),
(46, 'P-445', 'Normal Christian Desires and Exercises (29 pages)', 'Bruce Anstey', '2.95', 'booklet51cover.png', 'booklet51back.png'),
(47, 'P-446', 'Olivet Discourse (34 pages)', 'Bruce Anstey', '3.95', 'booklet52cover.png', 'booklet52back.png'),
(48, 'P-447', '\"On Eagles’ Wings\" (44 pages)', 'Bruce Anstey', '3.95', 'booklet53cover.png', 'booklet53back.png'),
(49, 'SB-448', 'Passion Psalms - Pertaining to the Sufferings of Christ on the Cross (11 pages)', 'Bruce Anstey', '1.95', 'booklet54cover.png', 'booklet54back.png'),
(50, 'P-449', 'Paul’s Twelve Men (28 pages)', 'Bruce Anstey', '2.95', 'booklet55cover.png', 'booklet55back.png'),
(51, 'P-475', 'Placement of Psalms in Prophecy (20 pages)', 'Bruce Anstey', '2.95', 'booklet57cover.png', 'booklet57back.png'),
(52, 'C-450', 'Placement of the Psalms (Leaflet)', 'Bruce Anstey', '.95', 'booklet56cover.png', 'booklet56chart.png'),
(53, 'P-451', 'Practical Salvation of the Assembly (24 pages)', 'Bruce Anstey', '2.95', 'booklet58cover.png', 'booklet58back.png'),
(54, 'P-452', 'Presence and Power of the Spirit of God (27 pages)', 'Bruce Anstey', '2.95', 'booklet59cover.png', 'booklet59back.png'),
(55, 'P-453', 'Proverbs, The Book with chart (48 pages)', 'Bruce Anstey', '3.95', 'booklet4cover.png', 'booklet4back.png'),
(56, 'P-454', 'Purchase and Redemption (22 pages)', 'Bruce Anstey', '2.95', 'booklet60cover.png', 'booklet60back.png'),
(57, 'P-455', 'Purpose of Trials (44 pages)', 'Bruce Anstey', '3.95', 'booklet61cover.png', 'booklet61back.png'),
(58, 'P-456', 'Qualifications for Service as Seen in Gideon (36 pages)', 'Bruce Anstey', '3.95', 'booklet38cover.png', 'booklet38back.png'),
(59, 'SB-457', 'Reconciliation (24 pages)', 'Bruce Anstey', '2.95', 'booklet62cover.png', 'booklet62back.png'),
(60, 'C-474', 'Revelation: A Brief Overview (Leaflet)', 'Bruce Anstey', '.95', 'booklet63cover.png', 'booklet63chart.png'),
(61, 'P-458', 'Romans, Outline - with chart (35 pages)', 'Bruce Anstey', '3.95', 'booklet17cover.png', 'booklet17back.png'),
(62, 'P-459', 'Satan’s Operations on the Lord’s People (36 pages)', 'Bruce Anstey', '3.95', 'booklet64cover.png', 'booklet64back.png'),
(63, 'P-460', 'Secret to a Happy, Fruitful Christian Life, Part 1 (30 pages)', 'Bruce Anstey', '2.95', 'booklet24cover.png', 'booklet24back.png'),
(64, 'P-461', 'Secret to a Happy, Fruitful Christian Life, Part 2 (29 pages)', 'Bruce Anstey', '2.95', 'booklet25cover.png', 'booklet25back.png'),
(65, 'P-462', 'Seventy Weeks of Daniel, the Indignation and the Remnant (16 pages)', 'Bruce Anstey', '1.95', 'booklet19cover.png', 'booklet19back.png'),
(66, 'SB-463', 'Sinless Humanity of Christ (20 pages)', 'Bruce Anstey', '1.95', 'booklet65cover.png', 'booklet65back.png'),
(67, 'SB-464', 'Sufferings of Christ (12 pages)', 'Bruce Anstey', '1.95', 'booklet84cover.png', 'booklet84back.png'),
(68, 'SB-465', 'Summary of the Lord\'s \"Upper Room\" Ministry (12 pages)', 'Bruce Anstey', '1.95', 'booklet66cover.png', 'booklet66back.png'),
(69, 'P-466', 'Ten Aspects of the Kingdom (15 pages)', 'Bruce Anstey', '1.95', 'booklet67cover.png', 'booklet67back.png'),
(70, 'P-467', 'Things Which Make For Peace (30 pages)', 'Bruce Anstey', '2.95', 'booklet68cover.png', 'booklet68back.png'),
(71, 'SB-468', 'Three Things We Must Not Lose Sight Of (9 pages)', 'Bruce Anstey', '1.95', 'booklet69cover.png', 'booklet69back.png'),
(72, 'P-469', 'Three Young Men Who Had a Fall (40 pages)', 'Bruce Anstey', '3.95', 'booklet70cover.png', 'booklet70back.png'),
(73, 'P-470', 'Transition from Judaism to Christianity in John\'s Gospel (26 pages)', 'Bruce Anstey', '2.95', 'booklet41cover.png', 'booklet41back.png'),
(74, 'P-471', '\"Two Days\" in Scripture (30 pages)', 'Bruce Anstey', '2.95', 'booklet71cover.png', 'booklet71back.png'),
(75, 'P-472', 'Who Should Partake of the Lord\'s Supper? (14 pages)', 'Bruce Anstey', '1.95', 'booklet86cover.png', 'booklet86back.png'),
(76, 'SB-501', 'The Place of His Appointment (24 pages)', 'F.C. Blount', '1.95', 'booklet72cover.png', 'booklet72back.png'),
(77, 'SB-502', 'Head Coverings - Questions and Answers Regarding the Use of Head Coverings (12 pages)', 'R. Boulard', '1.95', 'booklet6cover.png', 'booklet6back.png'),
(78, 'SB-503', 'New Birth, Salvation and Sealing (16 pages)', 'A.P. Cecil', '1.95', 'booklet89cover.png', 'booklet89back.png'),
(79, 'P-504', 'Covenant Theology Answered (44 pages)', 'D. Graham', '3.95', 'booklet73cover.png', 'booklet73back.png'),
(80, 'P-504', 'Three Sevens in Scripture - An Out line of the Moral and Dispensational Ways of God (34 pages)', 'D. Graham', '3.95', 'booklet87cover.png', 'booklet87back.png'),
(81, 'SB-506', 'Family - A Word to Parents (36 pages)', 'G. Hayhoe', '2.95', 'booklet74cover.png', 'booklet74back.png'),
(82, 'SB-507', 'Marriage Bond - And What Scripture Says About Divorce and Remarriage - (17 pages)', 'G. Hayhoe', '1.95', 'booklet88cover.png', 'booklet88back.png'),
(83, 'SB-508', 'Seven Pillars of a Godly Home - Necessary Things in Building a Christian Home - (36 pages)', 'G. Hayhoe', '2.95', 'booklet15cover.png', 'booklet15back.png'),
(84, 'SB-509', 'Sister\'s Place in the Home (28 pages)', 'G. Hayhoe', '2.95', 'booklet75cover.png', 'booklet75back.png'),
(85, 'SB-510', 'Understanding, Love and Respect in Marriage  (16 pages)', 'G. Hayhoe', '2.95', 'booklet76cover.png', 'booklet76back.png'),
(86, 'SB-511', 'Word on Courtships (28 pages)', 'G. Hayhoe', '2.95', 'booklet14cover.png', 'booklet14back.png'),
(87, 'SB-512', 'The New Birth - Faith\'s Connection with New Birth (9 pages)', 'A.J. Pollock', '1.95', 'booklet85cover.png', 'booklet85back.png'),
(88, 'SB-513', 'Jude, The Epistle of - An Expository Outline (18 pages)', 'H. Smith', '1.95', 'booklet12cover.png', 'booklet12back.png'),
(89, 'SB-514', 'Gathered Together (11 pages)', 'H. Smith', '1.95', 'booklet90cover.png', 'booklet90back.png'),
(90, 'SB-515', 'God Gathers Christians by the Spirit to His Divine Center -Reading Ottawa 1987 (30 pages)', 'Multiple Authors', '2.95', 'booklet77cover.png', 'booklet77back.png'),
(93, 'C-481', 'Daniel - Outline of the Book of Daniel the Prophet (Leaflet)', 'Bruce Anstey', '.95', 'booklet91cover.png', 'booklet91sample.png'),
(94, 'SB-482', 'Eternal Life - What is it? (8 pages)', 'Bruce Anstey', '1.67', 'booklet92cover.png', 'booklet92back.png'),
(95, 'SPB-475', 'Compañerismo 1 (38 pages)', 'Bruce Anstey', '3.95', 'booklet93cover.png', 'booklet93back.png'),
(96, 'SPB-476', 'Compañerismo 2 (31 pages)', 'Bruce Anstey', '3.95', 'booklet94cover.png', 'booklet94back.png'),
(97, 'SPB-477', 'Daniel (36 pages)', 'Bruce Anstey', '3.95', 'booklet95cover.png', 'booklet95back.png'),
(98, 'SPB-478 ', 'Sansón (44 pages)', 'Bruce Anstey', '3.95', 'booklet96cover.png', 'booklet96back.png'),
(99, 'SPB-483', 'La Venida Del Señor (El Rapto) (33 pages)\r\n', 'Bruce Anstey', '3.95', 'booklet97cover.png', 'booklet97back.png'),
(102, 'FB-479', 'Être Disciple, Conditions, Tests et Recompenses (30 pages)', 'Bruce Anstey', '2.95', 'booklet98cover.png', 'booklet98back.png'),
(103, 'C-480', 'Isaiah - Brief Outline of Each Chapter (Leaflet)', 'Bruce Anstey', '.95', 'booklet100cover.png', 'booklet100back.png');

-- --------------------------------------------------------

--
-- Table structure for table `ebooks`
--

CREATE TABLE `ebooks` (
  `id` int(11) NOT NULL,
  `version` varchar(10) NOT NULL,
  `title` varchar(200) NOT NULL,
  `author` varchar(200) NOT NULL,
  `imgFile` varchar(100) NOT NULL,
  `amazon` varchar(350) NOT NULL,
  `epub` varchar(200) NOT NULL,
  `mobi` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ebooks`
--

INSERT INTO `ebooks` (`id`, `version`, `title`, `author`, `imgFile`, `amazon`, `epub`, `mobi`) VALUES
(1, '1.5', 'Backsliding & Restoration', 'Bruce Anstey', 'Backsliding_Restoration.jpg', 'https://www.amazon.com/BACKSLIDING-RESTORATION-Relation-Priesthood-Advocacy-ebook/dp/B07NCDWMDT/ref=sr_1_5?crid=PQ0GHZERSPJ&dchild=1&keywords=bruce+anstey&qid=1590246186&sprefix=bruce+anstey+%2Caps%2C165&sr=8-5', 'Backsliding & Restoration E-Boo - Bruce Anstey.epub', 'Backsliding & Restoration E-Boo - Bruce Anstey.mobi'),
(2, '1.3', 'Church Seen Under Twelve Figures in the N. T., The', 'Bruce Anstey', 'Church12Fig.jpg', 'na', 'THE CHURCH - 12 Figures E-Book - Bruce Anstey.epub', 'THE CHURCH - 12 Figures E-Book - Bruce Anstey.mobi'),
(3, '1.3', 'Covenant Theology or \"Is This Method of Interpretation Scripturally Sound?\"', 'Bruce Anstey', 'Covenant.jpg', 'na', 'Covenant Theology - E-Book Vers - Bruce Anstey.epub', 'Covenant Theology - E-Book Vers - Bruce Anstey.mobi'),
(4, '1.1', 'Death, the Intermediate State and Resurrection & Final Destiny', 'Bruce Anstey', 'Death.jpg', 'https://www.amazon.com/DEATH-INTERMEDIATE-STATE-RESURRECTION-DESTINY-ebook/dp/B07ZCKC4KG/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Death%2C+the+Intermediate+State+and+Resurrection+%26+Final+Destiny&qid=1590247085&sr=8-1', 'Death, Intermediate State, Resu - Bruce Anstey.epub', 'Death, Intermediate State, Resu - Bruce Anstey.mobi'),
(5, '1.3', 'Definiciones Doctrinales', 'Bruce Anstey', 'DefinicionesDoctrinales.jpg', 'na', 'Definiciones Doctrinales - VERS - Bruce Anstey.epub', 'Definiciones Doctrinales - VERS - Bruce Anstey.mobi'),
(6, '1.1', 'Doctrinal Definitions', 'Bruce Anstey', 'doctrinal_definitions.jpg', 'https://www.amazon.com/DOCTRINAL-DEFINITIONS-Doctrinal-Expressions-Testament-ebook/dp/B07T1SQZQY/ref=sr_1_fkmr0_1?dchild=1&keywords=bruce+anstey+Definiciones+Doctrinales&qid=1590247438&sr=8-1-fkmr0', 'Doctrinal Definitions E-Book Ve - Bruce Anstey.epub', 'Doctrinal Definitions E-Book Ve - Bruce Anstey.mobi'),
(7, '1.0', 'Discipleship — its Terms, Tests, and Rewards', 'Bruce Anstey', 'Discipleship.jpg', 'na', 'Discipleship E-Book Version 1.0 - Bruce Anstey.epub', 'Discipleship E-Book Version 1.0 - Bruce Anstey.mobi'),
(8, '1.2', 'Esther - The Prophetic Interpretation', 'Bruce Anstey', 'Esther.jpg', 'na', 'Esther - The Prophetic Interpre - Bruce Anstey.epub', 'Esther - The Prophetic Interpre - Bruce Anstey.mobi'),
(9, '1.3', 'Eternal Security of the Believer', 'Bruce Anstey', 'Eternal_Security.jpg', 'https://www.amazon.com/ETERNAL-SECURITY-BELIEVER-Examination-Scriptures-ebook/dp/B07NPFL45F/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Eternal+Security+of+the+Believer&qid=1590247835&sr=8-1', 'Eternal Security E-Book Version - Bruce Anstey.epub', 'Eternal Security E-Book Version - Bruce Anstey.mobi'),
(10, '1.5', 'Forsaking of Christ, The', 'Bruce Anstey', 'forsaking_of_christ.jpg', 'https://www.amazon.com/Forsaking-Christ-Father-communion-forsaken-ebook/dp/B0846ZY971/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Forsaking&qid=1590248066&sr=8-1', 'The Forsaking of Christ - E-Boo - Bruce Anstey.epub', 'The Forsaking of Christ - E-Boo - Bruce Anstey.mobi'),
(11, '1.4', 'Gap in Genesis 1', 'Bruce Anstey', 'Gap_Genesis.jpg', 'https://www.amazon.com/Gap-Genesis-1-Theory-ebook/dp/B07N95TTSY/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Gap+in+Genesis+1&qid=1590248181&sr=8-1', 'The Gap in Genesis 1 - E-Book V - Bruce Anstey.epub', 'The Gap in Genesis 1 - E-Book V - Bruce Anstey.mobi'),
(12, '1.1', 'Qualifications for Service as Seen in Gideon', 'Bruce Anstey', 'Gideon.jpg', 'https://www.amazon.com/Gideon-Qualifications-Service-Seen-ebook/dp/B07ZCHNPS8/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Qualifications+for+Service+as+Seen+in+Gideon&qid=1590248274&sr=8-1', 'Gideon E-Book - Version 1.1 - Bruce Anstey.epub', 'Gideon E-Book - Version 1.1 - Bruce Anstey.mobi'),
(13, '1.5', 'God\'s Order for Christians Meeting Together For Worship and Ministry', 'Bruce Anstey', 'Christians_Meeting_Together.jpg', 'https://www.amazon.com/GODs-ORDER-Christians-together-Traditional-ebook/dp/B07N93WJCB/ref=sr_1_1?dchild=1&keywords=bruce+anstey+God%27s+Order+for+Christians+Meeting+Together+For+Worship+and+Ministry&qid=1590248370&sr=8-1', 'God\'s Order E-Book Version 1.5 - Bruce Anstey.epub', 'God\'s Order E-Book Version 1.5 - Bruce Anstey.mobi'),
(14, '1.4', 'Head Coverings - Questions and Answers Regarding the Use of Head Coverings', 'Robert Boulard', 'HeadCoverings.jpg', 'na', 'Head Coverings E-Book Version 1 - Robert Boulard.epub', 'Head Coverings E-Book Version 1 - Robert Boulard.mobi'),
(15, '1.4', 'Transition from Judaism to Christianity in John\'s Gospel', 'Bruce Anstey', 'JohnsGospel.jpg', 'na', 'John\'s Gospel - Transition E-Bo - Bruce Anstey.epub', 'John\'s Gospel - Transition E-Bo - Bruce Anstey.mobi'),
(16, '1.1', 'Olivet Discourse', 'Bruce Anstey', 'Olivet.jpg', 'https://www.amazon.com/OLIVET-DISCOURSE-Matthew-24-25-Christendom-ebook/dp/B08471PKQG/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Olivet+Discourse&qid=1590248737&sr=8-1', 'Olivet Discourse - E-Book Versi - Bruce Anstey.epub', 'Olivet Discourse - E-Book Versi - Bruce Anstey.mobi'),
(17, '1.2', '\"One Body\" in Practice', 'Bruce Anstey', 'One_Body_In_Practice.jpg', 'https://www.amazon.com/ONE-BODY-Practice-Gathering-Christians-ebook/dp/B07NCD3TH5/ref=sr_1_1?dchild=1&keywords=bruce+anstey+%22One+Body%22+in+Practice+-+Thoughts+on+the+Spirit%27s+Work+in+Gathering+Christians+unto+the+Name+of+the+Lord+Jesus+Christ+on+the+Ground+of+the+One+Body&qid=1590248827&sr=8-1', 'The One Body in Practice E-Book - Bruce Anstey.epub', 'The One Body in Practice E-Book - Bruce Anstey.mobi'),
(18, '1.4', 'Open Brethren -  Their Principles and Practices', 'Bruce Anstey', 'OpenBrethren.jpg', 'na', 'Open Brethren - Principles and - Bruce Anstey.epub', 'Open Brethren - Principles and - Bruce Anstey.mobi'),
(19, '1.5', '1st Corinthians - The Maintenance of Order in the Local Assembly', 'Bruce Anstey', '1st_Corinthians.jpg', 'https://www.amazon.com/First-Epistle-Paul-Corinthians-Maintenance-ebook/dp/B07N78BHNY/ref=sr_1_1?dchild=1&keywords=bruce+anstey+1st+Corinthians+-+The+Maintenance+of+Order+in+the+Local+Assembly&qid=1590249019&sr=8-1', 'Outline of 1st Corinthians E-Bo - Bruce Anstey.epub', 'Outline of 1st Corinthians E-Bo - Bruce Anstey.mobi'),
(20, '1.4', '1st John - Characteristics of Life Eternal in the Children of God in Times of Apostacy', 'Bruce Anstey', '1st_John.jpg', 'https://www.amazon.com/First-Epistle-JOHN-Characteristics-Episitles-ebook/dp/B07XGNNRXQ/ref=sr_1_1?dchild=1&keywords=bruce+anstey+1st+John&qid=1590249147&sr=8-1', 'Outline of 1st John - E-Book Ve - Bruce Anstey.epub', 'Outline of 1st John - E-Book Ve - Bruce Anstey.mobi'),
(21, '1.4', '1st Peter - New Christian Blessings, Relationships, and Trials in the Path of Faith', 'Bruce Anstey', '1st_Peter.jpg', 'https://www.amazon.com/First-Epistle-PETER-Christian-Relationships-ebook/dp/B07T1SRNYM/ref=sr_1_1?dchild=1&keywords=bruce+anstey+1st+Peter&qid=1590249221&sr=8-1', 'Outline of 1st Peter E-Book Ver - Bruce Anstey.epub', 'Outline of 1st Peter E-Book Ver - Bruce Anstey.mobi'),
(22, '1.7', '1st Thessalonians - The Care of New Converts and the Correction of Misunderstandings Regarding Future Events', 'Bruce Anstey', '1st_Thessalonians.jpg', 'https://www.amazon.com/First-Epistle-Paul-Thessolians-Misunderstandings-ebook/dp/B07Q168RTC/ref=sr_1_fkmr0_1?dchild=1&keywords=bruce+anstey+1st+Peter&qid=1590249287&sr=8-1-fkmr0', 'Outline of 1st Thessalonians E- - Bruce Anstey.epub', 'Outline of 1st Thessalonians E- - Bruce Anstey.mobi'),
(23, '1.5', '1st Timothy - The Order of God\'s House', 'Bruce Anstey', '1st_Timothy.jpg', 'https://www.amazon.com/First-Epistle-Paul-TIMOTHY-Order-ebook/dp/B07NPJFQ7C/ref=sr_1_1?dchild=1&keywords=bruce+anstey+1st+Timothy&qid=1590249353&sr=8-1', 'Outline of 1st Timothy E-Book V - Bruce Anstey.epub', 'Outline of 1st Timothy E-Book V - Bruce Anstey.mobi'),
(24, '1.3', '2nd Corinthians - The Characteristics of a True Christian Minister', 'Bruce Anstey', '2nd_Corinthians.jpg', 'https://www.amazon.com/Second-Epistle-Paul-Corinthians-Characteristics-ebook/dp/B07N7FQP3R/ref=sr_1_1?dchild=1&keywords=bruce+anstey+2nd+corinthians&qid=1590249501&sr=8-1', 'Outline of 2nd Corinthians Vers - Bruce Anstey.epub', 'Outline of 2nd Corinthians Vers - Bruce Anstey.mobi'),
(25, '1.2', '2nd John - The Refusal of False Teachers', 'Bruce Anstey', '2nd_John.jpg', 'https://www.amazon.com/Second-Epistle-JOHN-Teachers-Epistles-ebook/dp/B07XMDD8XP/ref=sr_1_1?dchild=1&keywords=bruce+anstey+2nd+john&qid=1590249530&sr=8-1', 'Outline of 2nd John - E-Book Ve - Bruce Anstey.epub', 'Outline of 2nd John - E-Book Ve - Bruce Anstey.mobi'),
(26, '1.4', '2nd Peter - The Divine Means of Being Kept In an Evil Day', 'Bruce Anstey', '2nd_Peter.jpg', 'https://www.amazon.com/Second-Epistle-PETER-Divine-Means-ebook/dp/B07T4XW7PB/ref=sr_1_fkmr1_2?dchild=1&keywords=bruce+anstey+2nd+peter&qid=1590249583&sr=8-2-fkmr1', 'Outline of 2nd Peter E-Book Ver - Bruce Anstey.epub', 'Outline of 2nd Peter E-Book Ver - Bruce Anstey.mobi'),
(27, '1.5', '2nd Thessalonians - The Dangers of Bad Eschatology (Future Events)', 'Bruce Anstey', '2nd_Thessalonians.jpg', 'https://www.amazon.com/Second-Epistle-Paul-THESSALONIANS-Eschatology-ebook/dp/B07PVTL5QL/ref=sr_1_1?dchild=1&keywords=bruce+anstey+2nd+thess&qid=1590249661&sr=8-1-spell', 'Outline of 2nd Thessalonians E- - Bruce Anstey.epub', 'Outline of 2nd Thessalonians E- - Bruce Anstey.mobi'),
(28, '1.2', '2nd Timothy - Encouragement in Service in a Time of Collective Failure', 'Bruce Anstey', '2nd_Timothy.jpg', 'https://www.amazon.com/Second-Epistle-Paul-TIMOTHY-Encouragement-ebook/dp/B07SZQ57C2/ref=sr_1_fkmr0_2?dchild=1&keywords=bruce+anstey+2nd+timothy&qid=1590249813&sr=8-2-fkmr0', 'Outline of 2nd Timothy E-Book V - Bruce Anstey.epub', 'Outline of 2nd Timothy E-Book V - Bruce Anstey.mobi'),
(29, '1.2', '3rd John - The Reception of True Servants of God', 'Bruce Anstey', '3rd_John.jpg', 'https://www.amazon.com/Third-Epistle-JOHN-Reception-Servants-ebook/dp/B07XJ8D4LQ/ref=sr_1_1?dchild=1&keywords=bruce+anstey+3rd+John&qid=1590249863&sr=8-1', 'Outline of 3rd John - E-Book Ve - Bruce Anstey.epub', 'Outline of 3rd John - E-Book Ve - Bruce Anstey.mobi'),
(30, '3.5', 'Colossians - The MYSTERY - \"Christ in You, the Hope of Glory\"', 'Bruce Anstey', 'Colossians.jpg', 'https://www.amazon.com/Outline-Pauls-Epistle-Colossians-MYSTERY-ebook/dp/B07N8W6Q5N/ref=sr_1_1?dchild=1&keywords=bruce+anstey+colossians&qid=1590249959&sr=8-1', 'Outline of Colossians E-Book Ve - Bruce Anstey.epub', 'Outline of Colossians E-Book Ve - Bruce Anstey.mobi'),
(31, '1.6', 'Ephesians - The MYSTERY - God\'s Purpose of the Ages and the Church', 'Bruce Anstey', 'Ephesians.jpg', 'https://www.amazon.com/Epistle-Paul-Ephesians-MYSTERY-Gods-Purpose-ebook/dp/B07RG68H9T/ref=sr_1_1?dchild=1&keywords=bruce+anstey+ephesias&qid=1590250020&sr=8-1-spell', 'Outline of Ephesians E-Book Ver - Bruce Anstey.epub', 'Outline of Ephesians E-Book Ver - Bruce Anstey.mobi'),
(32, '2.0', 'Galatians - the Peril of Legalism in Christianity', 'Bruce Anstey', 'Galatians.jpg', 'https://www.amazon.com/Epistle-Paul-Galatians-Legalism-Christianity-ebook/dp/B07R5L7H4M/ref=sr_1_1?dchild=1&keywords=bruce+anstey+galatians&qid=1590250093&sr=8-1', 'Outline of Galatians E-Book Ver - Bruce Anstey.epub', 'Outline of Galatians E-Book Ver - Bruce Anstey.mobi'),
(33, '1.4', 'Hebrews - New Living Way of Approach to God in Worship in Christianity', 'Bruce Anstey', 'Hebrews.jpg', 'https://www.amazon.com/Epistle-HEBREWS-Approach-Worship-Christianity-ebook/dp/B07T3VHVS1/ref=sr_1_1?dchild=1&keywords=bruce+anstey+hebrews&qid=1590250163&sr=8-1', 'Outline of Hebrews E-Book Versi - Bruce Anstey.epub', 'Outline of Hebrews E-Book Versi - Bruce Anstey.mobi'),
(34, '1.5', 'James - Reality of Faith Proved in the Circumstances of Everyday Living', 'Bruce Anstey', 'James.jpg', 'https://www.amazon.com/Epistle-James-Reality-Circumstances-Everyday-ebook/dp/B07NWFH6MF/ref=sr_1_1?dchild=1&keywords=bruce+anstey+james&qid=1590250270&sr=8-1', 'Outline of James E-Book Version - Bruce Anstey.epub', 'Outline of James E-Book Version - Bruce Anstey.mobi'),
(35, '1.3', 'Jude - The Apostasy of Christendom and the Path for the Faithful Amidst Those Conditions', 'Bruce Anstey', 'Jude.jpg', 'https://www.amazon.com/Epistle-JUDE-Apostasy-Christendom-Conditions-ebook/dp/B07XKC1JFL/ref=sr_1_1?dchild=1&keywords=bruce+anstey+jude&qid=1590250292&sr=8-1', 'Outline of Jude - E-Book Versio - Bruce Anstey.epub', 'Outline of Jude - E-Book Versio - Bruce Anstey.mobi'),
(36, '1.2', 'Philemon - Christian Grace and Courtesy', 'Bruce Anstey', 'Philemon.jpg', 'https://www.amazon.com/EPISTLE-PAUL-PHILEMON-Christian-Courtesy-ebook/dp/B07WTL1NKW/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Philemon&qid=1590250357&sr=8-1', 'Outline of Philemon - E-Book Ve - Bruce Anstey.epub', 'Outline of Philemon - E-Book Ve - Bruce Anstey.mobi'),
(37, '1.5', 'Philippians - The Epistle of Christian Devotedness and Joy', 'Bruce Anstey', 'Philippians.jpg', 'https://www.amazon.com/Outline-Pauls-Epistle-Philippians-Devotedness-ebook/dp/B07N8G89GZ/ref=sr_1_fkmr0_1?dchild=1&keywords=bruce+anstey+Phillipians&qid=1590250411&sr=8-1-fkmr0', 'Outline of Philippians E-Book V - Bruce Anstey.epub', 'Outline of Philippians E-Book V - Bruce Anstey.mobi'),
(38, '1.8', 'Proverbs - Divine Wisdom For Our Earthly Pathway', 'Bruce Anstey', 'Proverbs.jpg', 'https://www.amazon.com/Book-Proverbs-Divine-Earthly-Pathway-ebook/dp/B07WNL7CQ2/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Proverbs&qid=1590250480&sr=8-1', 'Outline of Proverbs - E-Book Ve - Bruce Anstey.epub', 'Outline of Proverbs - E-Book Ve - Bruce Anstey.mobi'),
(39, '1.9', 'Romans - God’s Righteousness Declared in the Gospel', 'Bruce Anstey', 'Romans.jpg', 'https://www.amazon.com/Outline-Pauls-Epistle-Romans-Righteousness-ebook/dp/B07N8FXYQJ/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Romans&qid=1590250535&sr=8-1', 'Outline of Romans E-Book Versio - Bruce Anstey.epub', 'Outline of Romans E-Book Versio - Bruce Anstey.mobi'),
(40, '1.7', 'Revelation - Things Which Must Shortly Come to Pass', 'Bruce Anstey', 'Revelation-bookcover.jpg', 'https://www.amazon.com/Book-Revelation-Things-Which-Shortly-ebook/dp/B07PJWTKK2/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Revelation&qid=1590250656&sr=8-1', 'Outline of The Book of Revelati - Bruce Anstey.epub', 'Outline of The Book of Revelati - Bruce Anstey.mobi'),
(41, '1.4', 'Titus - The Truth According to Godliness', 'Bruce Anstey', 'Titus.jpg', 'https://www.amazon.com/Epistle-Paul-Titus-According-Godliness-ebook/dp/B07WQZH26D/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Titus&qid=1590250702&sr=8-1', 'Outline of Titus - E-Book Versi - Bruce Anstey.epub', 'Outline of Titus - E-Book Versi - Bruce Anstey.mobi'),
(42, '1.0', 'Paul’s Twelve Men', 'Bruce Anstey', 'Pauls_Twelve_Men.jpg', 'https://www.amazon.com/Pauls-Twelve-Men-Scriptural-Application-ebook/dp/B07ZCJ97HY/ref=sr_1_3?dchild=1&keywords=bruce+anstey+Paul&qid=1590250755&sr=8-3', 'Paul\'s 12 Men - E-Book Version - Bruce Anstey.epub', 'Paul\'s 12 Men - E-Book Version - Bruce Anstey.mobi'),
(43, '2.1', 'Prophetic Events', 'Bruce Anstey', 'Prophetic_Events.jpg', 'https://www.amazon.com/Outline-Prophetic-Events-Chronologically-Arranged-ebook/dp/B07N7L2QJ4/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Prophetic+Events&qid=1590250868&sr=8-1', 'Prophetic Events - E-Book - Ver - Bruce Anstey.epub', 'Prophetic Events - E-Book - Ver - Bruce Anstey.mobi'),
(44, '1.1', 'Questions Young People Ask Vol.1', 'Bruce Anstey', 'Questions_Young_People_Ask_Vol_1.jpg', 'na', 'QUESTIONS - Volume 1 - E-Book V - Bruce Anstey.epub', 'QUESTIONS - Volume 1 - E-Book V - Bruce Anstey.mobi'),
(45, '1.2', 'Questions Young People Ask Vol.2', 'Bruce Anstey', 'Questions_Young_People_Ask_Vol_2.jpg', 'na', 'QUESTIONS - Volume 2 - E-Book V - Bruce Anstey.epub', 'QUESTIONS - Volume 2 - E-Book V - Bruce Anstey.mobi'),
(46, '1.7', 'The Search - For a Scripturally Gathered Assembly', 'Bruce Anstey', 'Scripturally_Gathered_Assembly.jpg', 'https://www.amazon.com/SEARCH-Scripturally-Gathered-Assembly-Scriptural-ebook/dp/B07NCC4PR2/ref=sr_1_1?dchild=1&keywords=bruce+anstey+The+Search+-+For+a+Scripturally+Gathered+Assembly&qid=1590251269&sr=8-1', 'The Search For a Scripturally G - Bruce Anstey.epub', 'The Search For a Scripturally G - Bruce Anstey.mobi'),
(47, '1.2', 'Ten Aspects of the Kingdom', 'Bruce Anstey', 'Ten_Aspects_of_the_Kingdom.jpg', 'https://www.amazon.com/TEN-ASPECTS-KINGDOM-GOD-Believers-ebook/dp/B07ZCJCQYY/ref=sr_1_1?dchild=1&keywords=bruce+anstey+Ten+Aspects&qid=1590251329&sr=8-1', 'Ten Aspects of the Kingdom - E- - Bruce Anstey.epub', 'Ten Aspects of the Kingdom - E- - Bruce Anstey.mobi');

-- --------------------------------------------------------

--
-- Table structure for table `expositions`
--

CREATE TABLE `expositions` (
  `id` int(11) NOT NULL,
  `code` varchar(10) NOT NULL,
  `title` varchar(200) NOT NULL,
  `author` varchar(200) NOT NULL,
  `price` varchar(10) NOT NULL,
  `frontcover` varchar(100) NOT NULL,
  `backcover` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `expositions`
--

INSERT INTO `expositions` (`id`, `code`, `title`, `author`, `price`, `frontcover`, `backcover`) VALUES
(1, 'RB-101', 'Psalms - Prophetic Outline of the (125 pages)', 'Bruce Anstey', '11.95', 'exp19cover.png', 'exp19back.png'),
(2, 'RB-102', 'Isaiah - Expounded (393 pages)', 'Bruce Anstey', '17.95', 'exp18cover.png', 'exp18back.png'),
(3, 'SVB-102', 'Isaiah - Wire Bound Study Version (393 pages)', 'Bruce Anstey', '25.95', 'exp21cover.png', 'exp21back.png'),
(4, 'RB-103', 'Minor Prophets - Volume 1, Hosea-Nahum (98 pages)', 'Bruce Anstey', '9.95', 'exp15cover.png', 'exp15back.png'),
(5, 'RB-201', 'Romans - God\'s Righteousness (315 pages) ', 'Bruce Anstey', '16.95', 'exp1cover.png', 'exp1back.png'),
(6, 'SVB-201', 'Romans - Wire Bound Study Version (315 pages)', 'Bruce Anstey', '23.95', 'exp22cover.png', 'exp22back.png'),
(7, 'RB-202', '1st Corinthians - The Maintenance of Order in the Local Assembly (156 pages)', 'Bruce Anstey', '11.95', 'exp2cover.png', 'exp2back.png'),
(8, 'RB-203', '2nd Corinthians - The Characteristics of a True Christian Minister (121 pages)', 'Bruce Anstey', '11.95', 'exp3cover.png', 'exp3back.png'),
(9, 'RB-204', 'Galatians - the Peril of Legalism in Christianity (104 pages)', 'Bruce Anstey', '11.95', 'exp4cover.png', 'exp4back.png'),
(10, 'RB-205', 'Ephesians - The MYSTERY-God\'s Purpose of the Ages and the Church (104 pages)', 'Bruce Anstey', '11.95', 'exp16cover.png', 'exp16back.png'),
(11, 'RB-206', 'Philippians - The Epistle of Christian Devotedness and Joy (102 pages)', 'Bruce Anstey', '11.95', 'exp20cover.png', 'exp20back.png'),
(12, 'RB-207', 'Colossians - The MYSTERY - \"Christ in You, the Hope of Glory\" (100 pages) ', 'Bruce Anstey', '11.95', 'exp5cover.png', 'exp5back.png'),
(23, 'RB-208', '1st - 2nd Thessalonians - Care of New Converts and Correction of Misunderstandings Regarding Future Events (119 pages)', 'Bruce Anstey', '11.95', 'exp6cover.png', 'exp6back.png'),
(24, 'RB-209', '1st Timothy - The Order of God\'s House (118 pages)', 'Bruce Anstey', '11.95', 'exp7cover.png', 'exp7back.png'),
(25, 'RB-210', '2nd Timothy - Encouragement in Service in a Time of Collective Failure (92 pages)', 'Bruce Anstey', '9.95', 'exp8cover.png', 'exp8back.png'),
(26, 'RB-216', 'Titus - Philemon -The Truth to Godliness and Christian Grace in Action (66 pages)', 'Bruce Anstey', '9.95', 'exp9cover.png', 'exp9back.png'),
(27, 'RB-211', 'Hebrews - New Living Way of Approach to God in Worship in Christianity (209 pages)', 'Bruce Anstey', '14.95', 'exp10cover.png', 'exp10back.png'),
(28, 'SVB-211', 'Hebrews - Wire Bound Study Version (209 pages)', 'Bruce Anstey', '19.95', 'exp17cover.png', 'exp17back.png'),
(29, 'RB-212', 'James - Reality of Faith Proved in the Circumstances of Everyday Living (98 pages)', 'Bruce Anstey', '11.95', 'exp11cover.png', 'exp11back.png'),
(30, 'RB-213', '1st - 2nd Peter - Ministry Pertaining to the Care of Jewish Converts (150 pages)', 'Bruce Anstey', '11.95', 'exp12cover.png', 'exp12back.png'),
(39, 'RB-214', 'John - Jude - Characteristics of Life Eternal in the Children of God in Times of Apostacy (156 pages)', 'Bruce Anstey', '11.95', 'exp13cover.png', 'exp13back.png'),
(40, 'RB-215', 'Revelation - Outline of the Book (142 pages)', 'Bruce Anstey', '11.95', 'exp14cover.png', 'exp14back.png'),
(42, 'SVB-202/3', '1st/2nd Corinthians - Wire Bound Study Version (280 pages)', 'Bruce Anstey', '23.95', 'exp23cover.png', 'exp23back.png'),
(43, 'RB-217', 'Acts - Divine Record of the First Thirty Years of Christianity (290 pages)', 'Bruce Anstey', '16.95', 'exp24cover.png', 'exp24back.png'),
(44, 'SVB-217', 'Acts - Wire Bound Study Version (290 pages)', 'Bruce Anstey', '23.95', 'exp25cover.png', 'exp25back.png');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `salt` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `username`, `password`, `salt`) VALUES
(1, 'CTP', 'i0H1zttdSUso2sF6IjaUwsRLoxqzN50uYJq+07dW5aI=', 'jQCOPj+U7xHAyXJBO3jNXw==');

-- --------------------------------------------------------

--
-- Table structure for table `ministry`
--

CREATE TABLE `ministry` (
  `id` int(11) NOT NULL,
  `code` varchar(10) NOT NULL,
  `title` varchar(200) NOT NULL,
  `author` varchar(200) NOT NULL,
  `price` varchar(10) NOT NULL,
  `frontcover` varchar(100) NOT NULL,
  `backcover` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ministry`
--

INSERT INTO `ministry` (`id`, `code`, `title`, `author`, `price`, `frontcover`, `backcover`) VALUES
(1, 'RB-301', 'Dispensationalism or a Covenantal Interpretation of Scripture (223 pages)', 'Bruce Anstey', '12.95', 'ministry1cover.png', 'ministry1back.png'),
(2, 'RB-302', 'Doctrinal Definitions - Handbook of Doctrinal Terms/Expressions (354 pages)', 'Bruce Anstey', '18.95', 'ministry2cover.png', 'ministry2back.png'),
(3, 'SVB-302', 'Doctrinal Definitions - Wire Bound Study Version (354 pages)', 'Bruce Anstey', '25.95', 'ministry3cover.png', 'ministry3back.png'),
(4, 'RB-312', 'Doctrine of Christ - the Greatness of His Person (91 pages)', 'Bruce Anstey', '9.95', 'ministry13cover.png', 'ministry13back.png'),
(5, 'RB-303', 'God\'s Order for Christians Meeting Together For Worship and Ministry (158 pages)', 'Bruce Anstey', '11.95', 'ministry4cover.png', 'ministry4back.png'),
(6, 'RB-304', 'New Birth, Salvation, and Eternal Life - \"What Saith the Scripture\"  (103 pages)', 'Bruce Anstey', '11.95', 'ministry14cover.png', 'ministry14back.png'),
(7, 'RB-305', '\"One Body\" in Practice - Thoughts on the Spirit\'s Work in Gathering Christians unto the Name of the Lord Jesus Christ on the Ground of the One Body  (144 pages)', 'Bruce Anstey', '11.95', 'ministry5cover.png', 'ministry5back.png'),
(8, 'RB-306', 'Open Brethren -  Their Principles and Practices (108 pages)', 'Bruce Anstey', '11.95', 'ministry6cover.png', 'ministry6back.png'),
(9, 'RB-307', 'Prophetic Events - An Outline (225 pages)', 'Bruce Anstey', '12.95', 'ministry8cover.png', 'ministry8back.png'),
(10, 'SVB-307', 'Prophetic Events - Wire Bound Study Version (225 pages)', 'Bruce Anstey', '19.95', 'ministry7cover.png', 'ministry7back.png'),
(11, 'RB-308', 'Questions - Young People Ask Regarding the True Ground of Gathering for Christians Vol.1 (105 pages)', 'Bruce Anstey', '11.95', 'ministry9cover.png', 'ministry9back.png'),
(12, 'RB-309', 'Questions - Young People Ask Regarding the True Ground of Gathering for Christians Vol.2  (94 pages)', 'Bruce Anstey', '11.95', 'ministry10cover.png', 'ministry10back.png'),
(13, 'RB-310', 'The Search - For a Scripturally Gathered Assembly (149 pages)', 'Bruce Anstey', '11.95', 'ministry11cover.png', 'ministry11back.png'),
(14, 'RB-311', 'Unsound Doctrinal Statements and Cliches (165 pages)', 'Bruce Anstey', '13.95', 'ministry12cover.png', 'ministry12back.png'),
(37, 'SPB-313', 'Definiciones Doctrinales (420 pages)', 'Bruce Anstey', '13.95', 'ministry15cover.png', 'ministry15back.png'),
(38, 'SVB-313', 'Definiciones Doctrinales - Wire Bound Study Version (420 pages)', 'Bruce Anstey', '17.95', 'ministry16cover.png', 'ministry16back.png');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `booklets`
--
ALTER TABLE `booklets`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ebooks`
--
ALTER TABLE `ebooks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `expositions`
--
ALTER TABLE `expositions`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ministry`
--
ALTER TABLE `ministry`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `booklets`
--
ALTER TABLE `booklets`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=104;

--
-- AUTO_INCREMENT for table `ebooks`
--
ALTER TABLE `ebooks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `expositions`
--
ALTER TABLE `expositions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `ministry`
--
ALTER TABLE `ministry`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
