CREATE TABLE Playlist_songs (
    playlistID INT,
    songID INT,
    FOREIGN KEY (PlaylistID) REFERENCES Playlists(playlistID),
    FOREIGN KEY (SongID) REFERENCES Tracks(trackID)
);