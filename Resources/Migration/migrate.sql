-- Tạo cơ sở dữ liệu
CREATE DATABASE IF NOT EXISTS company_catalogue;
USE company_catalogue;

-- Tạo bảng role
CREATE TABLE IF NOT EXISTS role (
    id INT AUTO_INCREMENT NOT NULL UNIQUE,
    name VARCHAR(50) NOT NULL UNIQUE,

    PRIMARY KEY (id)
);

-- Thêm vai trò vào bảng role
INSERT INTO role (name) VALUES ('intern'), ('alumnus'), ('admin');

-- Tạo bảng company
CREATE TABLE IF NOT EXISTS company (
    id INT AUTO_INCREMENT NOT NULL UNIQUE,
    name VARCHAR(255) NOT NULL UNIQUE,
    description TEXT,
    location VARCHAR(255),
    website VARCHAR(255),
    logo VARCHAR(255),
    industry VARCHAR(255),
    established DATE,
    other_details TEXT,

    PRIMARY KEY (id)
);

-- Tạo bảng user
CREATE TABLE IF NOT EXISTS user (
    id INT AUTO_INCREMENT NOT NULL UNIQUE,
    first_name VARCHAR(255),
    last_name VARCHAR(255),
    email VARCHAR(255) NOT NULL UNIQUE,
    password_hash TEXT NOT NULL,
    role_id INT,
    profile_picture TEXT,
    bio TEXT,

    PRIMARY KEY (id),

    FOREIGN KEY (role_id)
    REFERENCES role (id)
    ON UPDATE CASCADE ON DELETE SET NULL
);

-- Tạo bảng story
CREATE TABLE IF NOT EXISTS story (
    id INT AUTO_INCREMENT NOT NULL UNIQUE,
    company_id INT NOT NULL,
    user_id INT NOT NULL,
    title VARCHAR(300),
    content TEXT,
    posted DATETIME,
    likes INT DEFAULT 0,
    status ENUM('pending', 'published'),

    PRIMARY KEY (id),

    FOREIGN KEY (company_id)
    REFERENCES company (id)
    ON UPDATE CASCADE ON DELETE CASCADE,

    FOREIGN KEY (user_id)
    REFERENCES user (id)
    ON UPDATE CASCADE ON DELETE CASCADE
);

-- Tạo bảng comment
CREATE TABLE IF NOT EXISTS comment (
    id INT AUTO_INCREMENT NOT NULL UNIQUE,
    story_id INT NOT NULL,
    user_id INT NOT NULL,
    content TEXT,
    date_posted DATETIME,

    PRIMARY KEY (id),

    FOREIGN KEY (story_id)
    REFERENCES story (id)
    ON UPDATE CASCADE ON DELETE CASCADE,

    FOREIGN KEY (user_id)
    REFERENCES user (id)
    ON UPDATE CASCADE ON DELETE CASCADE
);

-- Tạo bảng tag
CREATE TABLE IF NOT EXISTS tag (
    id INT AUTO_INCREMENT NOT NULL UNIQUE,
    name VARCHAR(100),

    PRIMARY KEY (id)
);

-- Tạo bảng story_tag
CREATE TABLE IF NOT EXISTS story_tag (
    story_id INT NOT NULL,
    tag_id INT NOT NULL,

    FOREIGN KEY (story_id)
    REFERENCES story (id)
    ON UPDATE CASCADE ON DELETE CASCADE,

    FOREIGN KEY (tag_id)
    REFERENCES tag (id)
    ON UPDATE CASCADE ON DELETE CASCADE
);
