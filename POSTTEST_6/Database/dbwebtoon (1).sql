-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Apr 2026 pada 13.15
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbwebtoon`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbgenre`
--

CREATE TABLE `tbgenre` (
  `genre` varchar(50) NOT NULL,
  `nama_genre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbgenre`
--

INSERT INTO `tbgenre` (`genre`, `nama_genre`) VALUES
('1', 'Romantis'),
('2', 'Kerajaan'),
('3', 'Thiller'),
('4', 'Slice Of Life'),
('5', 'Drama'),
('6', 'Horror'),
('7', 'Aksi'),
('8', 'Komedi'),
('9', 'Fantasi');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbwebtoons`
--

CREATE TABLE `tbwebtoons` (
  `idwebtoon` varchar(50) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `genre` varchar(50) NOT NULL,
  `author` varchar(100) NOT NULL,
  `rating` decimal(3,1) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbwebtoons`
--

INSERT INTO `tbwebtoons` (`idwebtoon`, `judul`, `genre`, `author`, `rating`, `status`) VALUES
('W1', 'I Wanna Be U', '2', 'SAM', 4.9, 'Hiatus'),
('W10', 'Mystique', '9', 'VAN JI', 4.8, 'Daily Pass'),
('W2', 'See You In My 19th Life', '1', 'Lee Hey', 3.0, 'Tamat'),
('W3', 'Girl\'s Word', '5', 'Morangg', 4.0, 'On Going'),
('W4', 'Kaos Hitam', '8', 'Toragi', 4.3, 'On Going'),
('W5', 'On the Way to Meet Mom', '5', 'Gomyang', 4.8, 'On Going'),
('W6', 'Like Mother, Like Daugther', '3', 'YIDAHM', 4.0, 'On Going'),
('W7', 'WEE!', '4', 'Amoeba UwU', 4.9, 'On Going'),
('W8', 'Survived Romance', '6', 'Lee Yeon', 3.7, 'Daily Pass'),
('W9', 'Plaything', '7', 'Q-Boy', 3.9, 'On Going');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbgenre`
--
ALTER TABLE `tbgenre`
  ADD PRIMARY KEY (`genre`);

--
-- Indeks untuk tabel `tbwebtoons`
--
ALTER TABLE `tbwebtoons`
  ADD PRIMARY KEY (`idwebtoon`),
  ADD KEY `fk` (`genre`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbwebtoons`
--
ALTER TABLE `tbwebtoons`
  ADD CONSTRAINT `fk` FOREIGN KEY (`genre`) REFERENCES `tbgenre` (`genre`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
