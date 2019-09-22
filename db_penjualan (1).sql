-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 31, 2019 at 04:25 PM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.2.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_penjualan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_barang`
--

CREATE TABLE `tb_barang` (
  `kode_barang` varchar(20) NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `harga` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_barang`
--

INSERT INTO `tb_barang` (`kode_barang`, `nama_barang`, `harga`) VALUES
('AC31201', 'LAPTOP Acer', 5000000),
('LE02', 'LAPTOP ASUS', 3120000),
('LHP01', 'LAPTOP HP', 5100000),
('LN01', 'LAPTOP LENOVO', 4019000),
('MN_091', 'LAPTOP Apple', 11000000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_login`
--

CREATE TABLE `tb_login` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `nama_pengguna` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_login`
--

INSERT INTO `tb_login` (`username`, `password`, `nama_pengguna`) VALUES
('bisa', '1234', 'Ramadhan'),
('kamu', 'juga', 'Putra');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pelanggan`
--

CREATE TABLE `tb_pelanggan` (
  `kode_pelanggan` varchar(20) NOT NULL,
  `nama_pelanggan` varchar(20) NOT NULL,
  `alamat` varchar(25) NOT NULL,
  `nomor_hp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_pelanggan`
--

INSERT INTO `tb_pelanggan` (`kode_pelanggan`, `nama_pelanggan`, `alamat`, `nomor_hp`) VALUES
('NM001', 'REZEKI', 'Medan', '08113298765'),
('NM002', 'DIN', 'Jakarta', '08596783241'),
('NM003', 'BINTANG', 'Balige', '082567493723'),
('NM004', 'Amirul', 'Brayan', '1997-04-14'),
('NM005', 'ADINDA', 'Marelan', '1899-08-03');

-- --------------------------------------------------------

--
-- Table structure for table `tb_penjualan`
--

CREATE TABLE `tb_penjualan` (
  `kode_penjualan` varchar(20) NOT NULL,
  `kode_barang` varchar(20) NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `harga` int(20) NOT NULL,
  `kode_petugas` varchar(20) NOT NULL,
  `nama_petugas` varchar(20) NOT NULL,
  `kode_pelanggan` varchar(20) NOT NULL,
  `nama_pelanggan` varchar(20) NOT NULL,
  `jumlah` int(20) NOT NULL,
  `total` int(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_penjualan`
--

INSERT INTO `tb_penjualan` (`kode_penjualan`, `kode_barang`, `nama_barang`, `harga`, `kode_petugas`, `nama_petugas`, `kode_pelanggan`, `nama_pelanggan`, `jumlah`, `total`) VALUES
('1', 'AC31201', 'LAPTOP Acer', 5000000, 'PT04', 'Miranda', 'NM005', 'ADINDA', 3, 15000000),
('2', 'LHP01', 'LAPTOP HP', 5100000, 'PT03', 'DINDA', 'NM001', 'REZEKI', 4, 20400000),
('3', 'LE02', 'LAPTOP ASUS', 3120000, 'PT01', 'Amirul', 'NM001', 'REZEKI', 3, 9360000),
('5', 'LHP01', 'LAPTOP HP', 5100000, 'PT02', 'ADINDA', 'PT09', 'Amirul', 5, 25500000),
('7', 'LE02', 'LAPTOP ASUS', 3120000, 'PT03', 'DINDA', 'NM003', 'BINTANG', 6, 18720000),
('8', 'LE02', 'LAPTOP ASUS', 3120000, 'PT01', 'Amirul', 'NM002', 'DIN', 7, 21840000),
('9', 'LE02', 'LAPTOP ASUS', 3120000, 'PT02', 'ADINDA', 'NM002', 'DIN', 2, 6240000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_petugas`
--

CREATE TABLE `tb_petugas` (
  `kode_petugas` varchar(20) NOT NULL,
  `nama_petugas` varchar(20) NOT NULL,
  `alamat_petugas` varchar(25) NOT NULL,
  `Tanggal_lahir` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_petugas`
--

INSERT INTO `tb_petugas` (`kode_petugas`, `nama_petugas`, `alamat_petugas`, `Tanggal_lahir`) VALUES
('PT01', 'Amirul', 'Brayanio', '1997-04-16'),
('PT02', 'ADINDA', 'Marelan', '1899-08-30'),
('PT03', 'DINDA', 'Marelan', '1899-08-16'),
('PT04', 'Miranda', 'Bandung', '1999-08-14'),
('PT05', 'Amirul', 'Brayanio', '1997-04-24');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_barang`
--
ALTER TABLE `tb_barang`
  ADD PRIMARY KEY (`kode_barang`);

--
-- Indexes for table `tb_login`
--
ALTER TABLE `tb_login`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `tb_pelanggan`
--
ALTER TABLE `tb_pelanggan`
  ADD PRIMARY KEY (`kode_pelanggan`);

--
-- Indexes for table `tb_penjualan`
--
ALTER TABLE `tb_penjualan`
  ADD PRIMARY KEY (`kode_penjualan`);

--
-- Indexes for table `tb_petugas`
--
ALTER TABLE `tb_petugas`
  ADD PRIMARY KEY (`kode_petugas`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
