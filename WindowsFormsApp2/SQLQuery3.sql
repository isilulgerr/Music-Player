CREATE TABLE Tracks (
    trackID INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    artistID INT,
    albumID INT,
    duration DATETIME,
    lyrics VARCHAR(300),
    FOREIGN KEY (ArtistID) REFERENCES Artists(artistID),
    FOREIGN KEY (AlbumID) REFERENCES Albums(albumID)
);