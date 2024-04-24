CREATE TABLE Albums (
    albumID INT IDENTITY(1,1) PRIMARY KEY,
    albumName VARCHAR(150) NOT NULL,
    albumYear DATE,
    artistID INT,
    FOREIGN KEY (ArtistID) REFERENCES Artists(artistID)
);