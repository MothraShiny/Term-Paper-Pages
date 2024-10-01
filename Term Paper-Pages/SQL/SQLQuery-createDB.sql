create table Pages (
Id int identity(1,1) NOT NULL,
NumberOfLetters int NOT NULL,
NumberOfVowels int NOT NULL,
NumberOfConsonants int NOT NULL,
FontSize int NOT NULL,
NumberOfParagraphs int NOT NULL,
PageNumber int NOT NULL,
NumberOfLines int NOT NULL,
PRIMARY KEY (Id)
);