CREATE TABLE Playlists (
    playlistID INT IDENTITY(1,1) PRIMARY KEY,
    playlistName VARCHAR(100) NOT NULL,
    userID INT,
    description VARCHAR(150),
    creatingDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(userID)
);