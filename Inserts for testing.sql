USE SputifyDb

GO



INSERT INTO Albums VALUES 
('Harvest'),
('Conversation pieces')

GO

INSERT INTO Songs VALUES
('Out on the weekend', 1, 1, 'C:\music\out on the weekend'),
('Harvest', 1, 2, 'C:\music\Harvest'),
('A man needs a maid', 1, 3, 'C:\music\A man needs a maid'),
('Heart of gold', 1, 4, 'C:\music\Heart of Gold'),
('Ull never be lonely again', 2, 1, 'C:\music\Ull never be lonely again')

GO

--SET IDENTITY_INSERT Collections OFF;

GO

INSERT INTO Collections VALUES
('default coll', 1, 4),
('default coll', 2, 2),
('default coll', 3, 1),
('default coll', 4, 3),
('mikkels favs', 1, 4),
('mikkels favs', 2, 2),
('mikkels favs', 3, 1),
('mikkels favs', 4, 3)

GO

INSERT INTO Playlists VALUES
('default playlist', 1),
('nondefault playlist', 2)


