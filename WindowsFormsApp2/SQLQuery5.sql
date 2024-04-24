CREATE TABLE Artists (
    artistID INT IDENTITY(1,1) PRIMARY KEY,
    artistName VARCHAR(100),
    genre VARCHAR(50),
    allTimeListener INT,
    placementInWorld INT
);