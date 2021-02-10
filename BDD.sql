Drop table if exists Projet;
Drop table if exists Manager;
Drop table if exists Client;
Drop table if exists Commercial;
Drop table if exists StatutProjet;

CREATE TABLE Manager
(
    idManager INT PRIMARY KEY NOT NULL,
    nomManager VARCHAR(100),
    prenomManager VARCHAR(100),
    userManager VARCHAR(255)
)

CREATE TABLE Client
(
    idClient INT PRIMARY KEY NOT NULL,
    nomClient VARCHAR(100),
    prenomClient VARCHAR(100)
)

CREATE TABLE Commercial
(
    idCommercial INT PRIMARY KEY NOT NULL,
    nomCommercial VARCHAR(100),
    prenomCommercial VARCHAR(100)
)

CREATE TABLE StatutProjet
(
    idStatutProjet INT PRIMARY KEY NOT NULL,
    libelleStatutProjet VARCHAR(100)
)

CREATE TABLE Projet
(
    idProjet INT PRIMARY KEY NOT NULL,
    nomProjet VARCHAR(100),
    dateCreation VARCHAR(255),
	dateFinalisation Date,
	villeProjet VARCHAR(100),
	idStatutProjet int,
	idCommercial int,
	idClient int
	constraint FK_ProjetClient foreign key (idClient) references CLIENT(idClient),
	constraint FK_ProjetCommercial foreign key (idCommercial) references Commercial(idCommercial),
	constraint FK_ProjetStatutProjet foreign key (idStatutProjet) references StatutProjet(idStatutProjet)
)
