# Streaming-Platform-Architecture

Ce projet est un squelette d'architecture de classe pour une future application de streaming vidéo. Il fournit une structure de base avec des classes représentant les principales entités et fonctionnalités du système, mais ne contient pas encore de logique métier détaillée.

L'objectif de ce projet est de servir de point de départ pour le développement ultérieur de l'application de streaming. Les différentes classes telles que `User`, `Content`, `FavoriteList`, `SafePayment`, `UsersCreditCard` et `WatchTime` sont fournies avec des propriétés et relations de base, permettant ainsi aux développeurs de construire et d'étendre facilement l'application selon leurs besoins spécifiques.


## Technologies utilisées

- [C#](https://docs.microsoft.com/fr-fr/dotnet/csharp/) - Langage de programmation utilisé pour développer l'application.
- [.NET](https://dotnet.microsoft.com/) - Plateforme utilisée pour le développement d'applications.
- [Entity Framework](https://docs.microsoft.com/fr-fr/ef/) - Outil de mappage objet-relationnel utilisé pour la gestion de la base de données.
- [SQL Server](https://www.microsoft.com/fr-fr/sql-server/) - Base de données utilisée pour stocker les informations des utilisateurs et du contenu.
- [ASP.NET Core](https://docs.microsoft.com/fr-fr/aspnet/core/?view=aspnetcore-5.0) - Framework web utilisé pour créer les API et gérer les requêtes HTTP.

## Structure du projet

Le projet est organisé en plusieurs classes représentant différentes entités :

- `User` : Représente un utilisateur avec des propriétés telles que l'ID, le nom, l'email, etc.
- `Content` : Représente un contenu vidéo avec des propriétés telles que l'ID, le type de contenu, le nom, la description, etc.
- `FavoriteList` : Représente une liste de favoris d'un profil avec une référence à un profil et une liste de contenus.
- `SafePayment` : Représente un paiement sécurisé avec des informations telles que l'ID, les détails, le montant, etc.
- `UsersCreditCard` : Représente les informations de carte de crédit d'un utilisateur.
- `WatchTime` : Représente le temps passé à regarder du contenu avec des références à un utilisateur et à un contenu.

## Installation

Pas d'installation requise pour ce projet.

## Auteur

Ce projet a été développé par moi meme.

N'hésitez pas à contribuer à ce projet en créant des pull requests ou en signalant des problèmes dans la section des issues.

**Note**: N'oubliez pas de mettre à jour toutes les sections appropriées, telles que les technologies utilisées, l'installation, etc., en fonction des besoins réels de votre projet.
Veuillez noter que ce projet ne comprend pas encore d'implémentation détaillée des fonctionnalités. Son but principal est de fournir une structure initiale pour faciliter le développement futur de l'application de streaming.
