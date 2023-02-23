# tampilkan seluruh DB 
SHOW DATABASES;

# buat database
CREATE DATABASE db_smp11;

#gunakan DB
USE db_smp11;


#tampilkan seluruh table
SHOW TABLES; 

#hapus database
DROP DATABASE db_smp11;

#buat table
CREATE TABLE siswa(

	#didalam sini bagian field.
    nama_siswa VARCHAR(100) NOT NULL,
    nisn INT(10) NOT NULL
    
)ENGINE = INNODB;




