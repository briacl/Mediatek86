USE `mysql`;
CREATE USER IF NOT EXISTS 'mediatek86'@'localhost' IDENTIFIED BY 'mediatek86pwd';
GRANT ALL PRIVILEGES ON mediatek86.* TO 'mediatek86'@'localhost';
FLUSH PRIVILEGES;