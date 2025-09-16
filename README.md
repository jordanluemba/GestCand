# GestCand

GestCand est une application web de gestion des candidats d�velopp�e avec ASP.NET Core Razor Pages et Bootstrap.

## Fonctionnalit�s
- Ajout, modification, suppression et affichage des candidats
- Visualisation des d�tails d'un candidat
- Interface moderne et responsive gr�ce � Bootstrap
- Stockage des donn�es via Entity Framework Core et SQL Server

## Structure des donn�es
Chaque candidat poss�de les informations suivantes :
- Nom
- Postnom
- Pr�nom
- Sexe
- Lieu de naissance
- Date de naissance
- Nationalit�
- Adresse
- T�l�phone

## Pr�requis
- .NET 8 SDK
- SQL Server (local ou distant)

## Installation
1. Cloner le d�p�t :
   ```bash
   git clone <url-du-repo>
   ```
2. Restaurer les packages NuGet :
   ```bash
   dotnet restore
   ```
3. Appliquer les migrations et cr�er la base de donn�es :
   ```bash
   dotnet ef database update
   ```
4. Lancer l'application :
   ```bash
   dotnet run --project GestCand/GestCand.csproj
   ```

## Utilisation
- Acc�der � la page d'accueil pour naviguer vers la liste des candidats
- Ajouter un candidat via le bouton "Ajouter un candidat"
- Modifier, consulter ou supprimer un candidat depuis la liste

## Technologies
- ASP.NET Core Razor Pages
- Bootstrap 5
- Entity Framework Core
- SQL Server

## Auteur
- LUEMBA Jordane

## Licence
Ce projet est open source, licence � d�finir.
