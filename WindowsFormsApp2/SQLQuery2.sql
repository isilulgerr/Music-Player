CREATE TABLE Userlikedtrack (
    likedID INT IDENTITY(1,1) PRIMARY KEY,
    userID INT,
    trackID INT,
    likedAt DATETIME,
    likedstatus VARCHAR(10),
    FOREIGN KEY (UserID) REFERENCES Users(userID),
    FOREIGN KEY (TrackID) REFERENCES Tracks(trackID)
);