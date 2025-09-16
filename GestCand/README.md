# GestCand

GestCand est une application web de gestion des candidats développée avec ASP.NET Core Razor Pages et Bootstrap.

## Fonctionnalités
- Ajout, modification, suppression et affichage des candidats
- Visualisation des détails d'un candidat
- Interface moderne et responsive grâce à Bootstrap
- Stockage des données via Entity Framework Core et SQL Server

## Structure des données
Chaque candidat possède les informations suivantes :
- Nom
- Postnom
- Prénom
- Sexe
- Lieu de naissance
- Date de naissance
- Nationalité
- Adresse
- Téléphone

## Prérequis
- .NET 8 SDK
- SQL Server (local ou distant)

## Installation
1. Cloner le dépôt :
   ```bash
   git clone <url-du-repo>
   ```
2. Restaurer les packages NuGet :
   ```bash
   dotnet restore
   ```
3. Appliquer les migrations et créer la base de données :
   ```bash
   dotnet ef database update
   ```
4. Lancer l'application :
   ```bash
   dotnet run --project GestCand/GestCand.csproj
   ```

## Utilisation
- Accéder à la page d'accueil pour naviguer vers la liste des candidats
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
Ce projet est open source, licence à définir.
