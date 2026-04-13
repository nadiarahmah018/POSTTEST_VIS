-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 13 Apr 2026 pada 11.04
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
('1', 'I Wanna Be U', 'Kerajaan', 'SAM', 4.9, 'Hiatus'),
('2', 'Suddenly, I Became a Princess', 'Kerajaan', 'Spoon/Plutus', 4.8, 'Tamat');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbwebtoons`
--
ALTER TABLE `tbwebtoons`
  ADD PRIMARY KEY (`idwebtoon`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
