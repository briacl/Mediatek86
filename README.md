# Mediatek86 <!-- omit from toc -->

Une solution pour la médiathèque de Vienne…  
Ceci est un projet scolaire réalisé dans le cadre de la formation BTS-SIO première année.  

Briac LE MEILLAT  
<div class="page"/>

## Table des matières <!-- omit from toc -->

- [1. Description](#1-description)
- [2. Avertissement](#2-avertissement)
- [3. Licence](#3-licence)
  - [3.1. BddManager.cs](#31-bddmanagercs)
- [4. Installation](#4-installation)
  - [4.1. Prérequis](#41-prérequis)
  - [4.2. Installation](#42-installation)
- [5. Utilisation de l'application](#5-utilisation-de-lapplication)
- [6. Notice d'utilisation](#6-notice-dutilisation)
- [7. Documentation du code source](#7-documentation-du-code-source)
  - [7.1. SandCastle pour Visual Studio 2022](#71-sandcastle-pour-visual-studio-2022)
- [8. CI/CD](#8-cicd)
- [9. Architecture](#9-architecture)
- [10. Contexte de l'application](#10-contexte-de-lapplication)
- [11. Fonctionnalités](#11-fonctionnalités)
  - [11.1. Contrôle d'accès à la base de données](#111-contrôle-daccès-à-la-base-de-données)
  - [11.2. Contrôle d'accès à l'application](#112-contrôle-daccès-à-lapplication)
    - [11.2.1. Dépannage de la connexion ou modification des paramètres de connexion](#1121-dépannage-de-la-connexion-ou-modification-des-paramètres-de-connexion)
  - [11.3. Gestion du personnel](#113-gestion-du-personnel)
- [12. Processus de développement](#12-processus-de-développement)
  - [12.1. Installation des outils de développement](#121-installation-des-outils-de-développement)
  - [12.2. Conception de la base de données](#122-conception-de-la-base-de-données)
    - [12.2.1. Génération d'un jeu de données de test](#1221-génération-dun-jeu-de-données-de-test)
    - [12.2.2. Nettoyage de la base de données](#1222-nettoyage-de-la-base-de-données)
  - [12.3. Développement de l'application](#123-développement-de-lapplication)
    - [12.3.1. Installation des extensions Visual Studio](#1231-installation-des-extensions-visual-studio)
    - [12.3.2. Création du projet](#1232-création-du-projet)
      - [12.3.2.1. Installation des packages NuGet](#12321-installation-des-packages-nuget)
    - [12.3.3. Contrôle du code source](#1233-contrôle-du-code-source)
    - [12.3.4. Développement des classes métier](#1234-développement-des-classes-métier)
      - [12.3.4.1. Responsable](#12341-responsable)
      - [12.3.4.2. MyDbContext](#12342-mydbcontext)
    - [12.3.5. Développement des vues et des contrôleurs](#1235-développement-des-vues-et-des-contrôleurs)
      - [12.3.5.1. Affichage de la liste des employés](#12351-affichage-de-la-liste-des-employés)
      - [12.3.5.2. Affichage de la liste des absences](#12352-affichage-de-la-liste-des-absences)
      - [12.3.5.3. Gestion de la saisie des dates dans les formulaires](#12353-gestion-de-la-saisie-des-dates-dans-les-formulaires)
- [13. Tests](#13-tests)
  - [13.1. Scénario de test de l'authentification](#131-scénario-de-test-de-lauthentification)
  - [13.2. Scénario de test de la gestion du personnel](#132-scénario-de-test-de-la-gestion-du-personnel)
    - [13.2.1. Ajouter un employé](#1321-ajouter-un-employé)
    - [13.2.2. Modifier un employé](#1322-modifier-un-employé)
    - [13.2.3. Supprimer un employé](#1323-supprimer-un-employé)
  - [13.3. Scénario de test de la gestion des absences](#133-scénario-de-test-de-la-gestion-des-absences)
    - [13.3.1. Ajouter une absence](#1331-ajouter-une-absence)
      - [13.3.1.1. Vérification du chevauchement des dates](#13311-vérification-du-chevauchement-des-dates)
    - [13.3.2. Modifier une absence](#1332-modifier-une-absence)
    - [13.3.3. Supprimer une absence](#1333-supprimer-une-absence)
  
<div class="page"/>

## 1. Description

Une solution pour la médiathèque de Vienne

## 2. Avertissement

Ce projet est un projet scolaire réalisé dans le cadre de la formation BTS-SIO première année.  
Il est fourni tel quel et n'est pas destiné à être utilisé en production.  
L'application n'est pas conforme aux normes de sécurité et de qualité attendues pour une application professionnelle.  
Elle est diffusée ici à titre d'exemple pour illustrer les compétences acquises par l'auteur dans le cadre de sa formation.  
L'auteur ne fournit aucune garantie quant à son fonctionnement et ne pourra être tenu pour responsable de tout dommage causé par son utilisation.

## 3. Licence

Ce projet est sous licence MIT. 
Cela signifie que vous pouvez l'utiliser, le modifier et le distribuer comme bon vous semble, à condition de conserver la licence MIT dans les fichiers modifiés.

### 3.1. BddManager.cs

Le fichier BddManager.cs est une adaptation du code fourni par le professeur et n'est pas concerné par la licence MIT. Il reste la propriété de l'auteur original et ne doit pas être utilisé en dehors du cadre de ce projet.  
<div class="page"/>

## 4. Installation

### 4.1. Prérequis

Le projet nécessite le framework .NET 8.0 pour fonctionner. Il est disponible gratuitement sur le [site de Microsoft](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

### 4.2. Installation

Vous trouverez la dernière version de l'application dans la section [Releases](https://github.com/briacl/Mediatek86/releases).  
Il vous suffit de télécharger l'installeur et de l'exécuter pour installer l'application sur votre ordinateur.  
L'installeur va créer un raccourci sur le bureau et dans le menu Démarrer pour lancer l'application.

## 5. Utilisation de l'application

Pour comprendre comment utiliser l'application nous avons réalisé une courte vidéo de démonstration. Elle est disponible directement sur GitHub à l'adresse suivante : [Vidéo de démonstration]()

## 6. Notice d'utilisation

L'application est simple d'utilisation toutefois une documentation est disponible sous la forme d'un wiki disponible à cette adresse. [Wiki](https://github.com/briacl/Mediatek86/wiki)

## 7. Documentation du code source

Le code source est documenté en utilisant le format XMLDoc. Le compilateur C# génère automatiquement un fichier XML contenant la documentation du code source. Ce fichier est disponible dans le répertoire `bin\Debug` ou `bin\Release` après la compilation du projet.

### 7.1. SandCastle pour Visual Studio 2022

Conformément au cahier des charges, la documentation du code source est également générée avec SandCastle. 
Le projet SandCastle est disponible dans la solution sous le nom `Documentation`. 
Elle est déployée dans GitHub Pages à l'adresse suivante : [Documentation](https://briacl.github.io/Mediatek86/)  
Cela permet une consultation en ligne interactive et élégante de la documentation du code source.  

Accueil de la documentation:

![50-Sandcastle_accueil](https://github.com/briacl/Mediatek86/assets/102411894/88222170-3f73-4051-b0f5-bead11dcec51)

Vue type d'une classe:

![50-Sandcastle_vue_classe](https://github.com/briacl/Mediatek86/assets/102411894/c0bdf834-0a6c-4e94-93f4-fd83b57eade1)

Vue type d'une méthode:

![50-Sandcastle_vue_méthode](https://github.com/briacl/Mediatek86/assets/102411894/64a59555-e347-4188-b7d2-7550370efb34)

## 8. CI/CD

Le projet est configuré pour utiliser GitHub Actions pour la CI/CD.  
Le workflow est défini dans le fichier `.github/workflows/ci.yml`.  
La publication de la documentation est effectuée automatiquement à chaque push sur la branche `main` via le workflow `.github/workflows/static-pages.yaml` .

## 9. Architecture

Cette application est écrite en C# et utilise le framework .NET 8.0 accompagné de la couche interface utilisateur Microsoft WPF.  
Ses données sont stockées dans une base de données MySQL installée sur le poste de l'utilisateur.  
L'accès à la base de données se fait via Entity Framework Core et la classe d'accès BddManager.
<div class="page"/>

## 10. Contexte de l'application

Dans le cadre de la formation BTS-SIO Première année il est proposé de réaliser une application imaginaire pour la médiathèque de Vienne.  
Voici comment est présenté le projet.  

Nous avons été intégré dans l'entreprise `ESN InfoTech Services 86` en tant que développeur junior. L'entreprise nous a alors confié  la réalisation d'une application Windows pour la médiathèque de Vienne.  

Cette application doit permettre de gérer les absences du personnel dans une médiathèque.  

L'application est mono-utilisateur et doit permettre de :
- Consulter la liste des employés
- Ajouter un employé
- Modifier un employé
- Consulter la liste des absences
- Ajouter une absence
- Modifier une absence
- Supprimer une absence

## 11. Fonctionnalités

Une étude du cachier des charges fourni par l'entreprise nous a permis de définir les fonctionnalités suivantes :

### 11.1. Contrôle d'accès à la base de données

La connexion entre la base de données et l'application est sécurisée par un contrôle d'accès. Un utilisateur de la base de données doit être créé avec les droits nécessaires pour accéder à la base de données. La chaîne de connexion est stockée dans le fichier `App.config` situé dans le répertoire de l'application.  Notez que le fichier s'appelle `Mediatek86.dll.config` dans le répertoire `bin\Debug` ou `bin\Release` après la compilation du projet.

Voici par exemple une configuration valide pour la chaîne de connexion et les paramètres de runtime:

```xml
<?xml version="1.0" encoding="utf-8" ?>

<configuration>
	<configSections>
		<section name="system.data" type="System.Data.Common.DbProviderFactoriesConfigurationSection, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
		<section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral" requirePermission="false" />
	</configSections>
	<entityFramework codeConfigurationType="MySql.Data.EntityFramework.MySqlEFConfiguration, MySql.Data.EntityFramework">
		<defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework"/>
		<providers>
			<provider invariantName="MySql.Data.MySqlClient"
				type="MySql.Data.MySqlClient.MySqlProviderServices, MySql.Data.EntityFramework"/>
		</providers>
	</entityFramework>
	<connectionStrings>
		<add name="MyMediatek86DbContext"
			 providerName="MySql.Data.MySqlClient"
			 connectionString="server=localhost;database=mediatek86;user=mediatek86;password=mediatek86pwd" />
	</connectionStrings>
</configuration>
```

### 11.2. Contrôle d'accès à l'application

L'accès à l'application est sécurisé par un contrôle d'accès vérifiant les identifiants de l'utilisateur. Cette vérification est effectuée en comparant les identifiants saisis par l'utilisateur avec ceux stockés dans la base de données. Par souci de sécurité il a été convenu de ne pas stocker les mots de passe en clair dans la base de données. Les mots de passe sont donc hashés avant d'être stockés. Le hashage est effectué avec l'algorithme SHA256. Le hash est stocké sous forme de chaîne héxadécimale dans la base de données.

#### 11.2.1. Dépannage de la connexion ou modification des paramètres de connexion

Il n'a pas été prévu dans le cahier des charges de l'application de permettre à l'utilisateur de modifier les paramètres de connexion à l'application'. Cependant, il est possible de modifier les paramètres de connexion en modifiant le contenu de la base de données. Pour ce faire, il est nécessaire de se connecter à la base de données avec un outil tel que MySQL Workbench. Il est alors possible de modifier les paramètres de connexion dans la table `responsable` de la base de données.  

Voici comment créer l'utilisateur `admin` avec le mot de passe `adminpwd` :

```sql
INSERT INTO `responsable` (`login`, `pwd`) VALUES ('admin',  SHA2('adminpwd', 256));
```

Voici comment modifier le mot de passe de l'utilisateur `admin` pour le remplacer par `newpwd` :

```sql
UPDATE `responsable` SET `pwd` = SHA2('newpwd', 256) WHERE `login` = 'admin';
```

### 11.3. Gestion du personnel

L'application permet de consulter la liste des employés, d'ajouter un employé, de modifier un employé.    
Le fonctionnement est simple; sur la page d'accueil de l'application, la liste des employés est affichée.  
Un bouton `Ajouter` permet d'ajouter un employé.  
Après avoir sélectionné un employé dans la liste, le bouton `Modifier` permet de modifier les informations de l'employé.
Après avoir sélectionné un employé dans la liste, le bouton `Supprimer` permet de supprimer l'employé.
<div class="page"/>

## 12. Processus de développement

Le développement de l'application a été réalisé en plusieurs étapes. Qui on toutes été saisie dans un projet GitHub. Le projet est disponible à l'adresse suivante : [Mediatek86](https://github.com/users/briacl/projects/1)

### 12.1. Installation des outils de développement

- Installation de Visual Studio 2022
  - Les options C# et .NET 8.0 sont installées
- Installation de MariaDB 11.4.2 [depuis le site officiel](https://dlm.mariadb.com/3829198/MariaDB/mariadb-11.4.2/winx64-packages/mariadb-11.4.2-winx64.msi)
- Installation de Looping MCD 4.0 [depuis le site officiel](https://www.looping-mcd.fr/Looping.zip)

### 12.2. Conception de la base de données

Le modèle conceptuel de données a été réalisé avec Looping MCD 4.0. 

![mcd](https://github.com/briacl/Mediatek86/assets/102411894/e4a4c7c7-69c5-4664-a5f3-aad87b12d52b)

La table `responsable` a été créée dans Looping puis [le script de création des tables](https://github.com/briacl/Mediatek86/blob/main/Mediatek86/data/SQL/createDatabase.sql) a été généré et a été complété pour créer la base de données appelée `mediatek86` et peupler les tables `motif` et `service` dans le même script. 

Pour créer la base de données, il suffit de copier le contenu du script dans un éditeur de requêtes SQL tel que MySQL Workbench et de l'exécuter. 

Une fois la base de données créée, nous avons créé un utilisateur `mediatek86` avec le mot de passe `mediatek86pwd` et les droits nécessaires pour accéder à la base de données. Cela a été fait avec les commandes suivantes :

```sql
CREATE USER 'mediatek86'@'localhost' IDENTIFIED BY 'mediatek86pwd';
GRANT ALL PRIVILEGES ON mediatek86.*
TO 'mediatek86'@'localhost';
```

#### 12.2.1. Génération d'un jeu de données de test

Pour faciliter le développement de l'application, un jeu de données de test a été généré. Le jeu a été créé manuellement
Ce jeu peut être modifié ou complété en fonction des besoins de test.  
Il est consultable [ici](https://github.com/briacl/Mediatek86/blob/main/Mediatek86/data/SQL/createTests.sql)  
Nous avons décider d'utiliser des sous-requêtes pour insérer les données dans les tables `personnel` et `absence` afin de garantir l'intégrité référentielle et de permettre de passer plusieurs fois le jeu de tests sans risquer de conflits d'identifiants.

#### 12.2.2. Nettoyage de la base de données

Pour nettoyer la base de données et réinitialiser les données de test, il suffit d'exécuter les commande suivantes :

```sql
DELETE FROM `absence`;
DELETE FROM `personnel`;
```

### 12.3. Développement de l'application

#### 12.3.1. Installation des extensions Visual Studio

Pour faciliter le développement, nous avons installé les extensions suivantes :

- [SandCastle Help File Builder](https://github.com/EWSoftware/SHFB/releases/download/2024.2.18.0/SHFBInstaller_2024.2.18.0.zip) 2024.2.18.0

#### 12.3.2. Création du projet

Une solution vide a été créée dans Visual Studio 2022.
Le projet a été créé avec Visual Studio 2022 en utilisant le modèle `WPF App (.NET)`.  
Le projet a été nommé `Mediatek86` et a été enregistré dans le répertoire `C:\Users\Briacl\source\repos\Mediatek86`.  
Un projet supplémentaire a été ajouté pour la documentation du code source. Le projet a été nommé `Documentation` et a été enregistré dans le répertoire `C:\Users\Briacl\source\repos\Mediatek86\Documentation`.

##### 12.3.2.1. Installation des packages NuGet

Pour faciliter le développement, nous avons installé les packages NuGet suivants :

- [EntityFramework](https://www.nuget.org/packages/EntityFramework/6.4.4) 6.4.4
- [MySql.Data](https://www.nuget.org/packages/MySql.Data/8.4.0) 8.4.0
- [MySql.Data.EntityFramework](https://www.nuget.org/packages/MySql.Data.EntityFramework/8.4.0) 8.4.0

#### 12.3.3. Contrôle du code source

Pour sécuriser le code source, nous avons créer un [dépôt Git](https://github.com/briacl/Mediatek86) sur GitHub. 
Le code source est versionné et les modifications sont commentées pour faciliter la compréhension du code.
Pour se conformer aux standards de GitHub, nous avons ajouté un fichier `README.md` à la racine du dépôt. Ce fichier contient une description du projet, une licence, une documentation du code source et des informations sur le processus de développement. Ce fichier est écrit en Markdown pour faciliter la lecture sur le site GitHub. Une version PDF est également disponible pour une lecture hors ligne.  

Le dépôt a été initialisé avec un fichier `.gitignore` pour ignorer les fichiers temporaires et les fichiers de configuration de Visual Studio.
```ps
git init
git config --global user.email "briacl@cned"
git config --global user.name "briacl"
git add .
git commit -m "Initial commit"
git branch -M main
git remote add origin git@github.com:/briacl/Mediatek86.git
git push -u origin main
```

#### 12.3.4. Développement des classes métier

Les classes métier ont été développées en suivant le modèle MVC.  
Les classes `Personnel`, `Service`, `Motif`, `Responsable` et `Absence` ont été créées dans le [répertoire Models](https://github.com/briacl/Mediatek86/tree/main/Mediatek86/Models).  

##### 12.3.4.1. [Responsable](https://briacl.github.io/Mediatek86/html/T_Mediatek86_Models_Responsable.htm)

La classe `Responsable` est une classe métier qui représente un utilisateur de l'application.  
Elle inclut une [méthode](https://github.com/briacl/Mediatek86/blob/main/Mediatek86/Models/Responsable.cs#L30L39) `VerifierMotDePasse` qui permet de vérifier si le mot de passe saisi par l'utilisateur est correct.

##### 12.3.4.2. [MyDbContext](https://briacl.github.io/Mediatek86/html/T_Mediatek86_Data_MyDbContext.htm)

La classe `MyDbContext` est une classe qui hérite de `DbContext` et permet de faire correspondres les tables de la base de données avec les classes métiers. Elle met à profit les fonctionnalités d'Entity Framework et du connecteur natif Oracle MySql.Data pour simplifier l'accès aux données.  
Nous avons choisi cette approche car c'est aujourd'hui la méthode la plus couramment utilisée pour accéder aux bases de données dans les applications .NET. 
Elle permet de simplifier le code en utilisant des classes métiers pour manipuler les données au lieu d'écrire des requêtes SQL à la main. Cette approche ORM (Object-Relational Mapping) permet de réduire les erreurs et de faciliter la maintenance du code. Cela permet également de bénéficier des fonctionnalités avancées d'Entity Framework telles que le suivi des modifications, les migrations de base de données et les requêtes LINQ.

#### 12.3.5. Développement des vues et des contrôleurs

Les vues de l'application ont été créées en utilisant le designer de Visual Studio. Le choix du WPF a été fait pour sa facilité d'utilisation et sa compatibilité avec les applications Windows. De plus le WPF permet de créer des interfaces utilisateur riches et interactives. Même si l'application Mediatek86 est extrêmement simple, en théorie le WPF permet de créer des interfaces utilisateur modernes et ergonomiques.

Les vues ont été créées dans le répertoire [Views](https://github.com/briacl/Mediatek86/tree/main/Mediatek86/Views) . Chaque vue est un fichier XAML qui définit l'interface utilisateur de l'application. Elles sont associées à un contrôleur qui lui est associé. Les contrôleurs directement associés aux vues portent le même nom que la vue mais ont l'extension `.cs`. Les contrôleurs sont responsables de la logique métier de l'application. Ils interagissent avec les classes métier pour récupérer et enregistrer les données. Ils sont également responsables de la navigation entre les vues.

Le cahier des charges impose un confirmation de suppression ou de suppression pour éviter les suppressions accidentelles. Pour cela nous avons utilisé de simples MessageBox pour demander une confirmation à l'utilisateur. Par exemple pour la suppression d'un personnel :
    
```csharp
Personnel? currentPersonnel = myDataGrid.SelectedItem as Personnel;
            if (currentPersonnel == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.");
                return;
            }
```

##### 12.3.5.1. Affichage de la liste des employés

La liste des employés est affichée dans un DataGrid. Le DataGrid est un contrôle WPF qui permet d'afficher des données sous forme de tableau. Il est très flexible et permet de personnaliser l'affichage des données. Dans notre cas, nous avons utilisé un DataGrid pour afficher les employés. Chaque ligne du DataGrid correspond à un employé. Les colonnes du DataGrid correspondent aux propriétés de l'employé. Par exemple, la colonne `Nom` affiche le nom de l'employé, la colonne `Prénom` affiche le prénom de l'employé, etc.

##### 12.3.5.2. Affichage de la liste des absences

La liste des absences est affichée dans un DataGrid de la même manière que la liste des employés. Chaque ligne du DataGrid correspond à une absence. Les colonnes du DataGrid correspondent aux propriétés de l'absence. Par exemple, la colonne `Date` affiche la date de l'absence, la colonne `Motif` affiche le motif de l'absence, etc.

##### 12.3.5.3. Gestion de la saisie des dates dans les formulaires

Pour faciliter la saisie des dates dans les formulaires, nous avons utilisé un contrôle DatePicker. Le DatePicker est un contrôle WPF qui permet de sélectionner une date dans un calendrier. Il est très pratique pour les formulaires de saisie de dates. Dans notre cas, nous avons utilisé un DatePicker pour saisir la date de début et la date de fin d'une absence. L'utilisateur peut sélectionner une date en cliquant sur le calendrier et en choisissant une date dans le calendrier. La date sélectionnée est automatiquement mise à jour dans le champ de saisie de la date.

![DatePicker](https://github.com/briacl/Mediatek86/assets/102411894/7b93c849-b422-48cf-a4bd-c011c0d60ce6)

## 13. Tests

### 13.1. Scénario de test de l'authentification

Le scénario suivant permet de valider le fonctionnement de l'application : 
Au lancement de l'application la fenêtre de connexion s'affiche.   
![01-login](https://github.com/briacl/Mediatek86/assets/102411894/95a29104-4375-4b20-a81d-335b2d012d54)  

Volontairement on saisit un nom d'utilisateur incorrect cela est détecté par l'application.  
![02-login_incorrect](https://github.com/briacl/Mediatek86/assets/102411894/765e6c90-e824-49ca-bc3d-60cdce9fd737)

Volontairement on saisit un mot de passe incorrect mais un utilisateur valide cela est détecté par l'application.
![03-utilisateur_inconnu](https://github.com/briacl/Mediatek86/assets/102411894/61d9fc0e-d0de-46fa-bbe6-d7f766efc706)

On saisit un utilisateur et un mot de passe valide et on clique sur le bouton `Connexion`.  
La liste des employés s'affiche.  
![05-liste_personnels](https://github.com/briacl/Mediatek86/assets/102411894/b86c1249-44e3-4bb2-b5ce-882895a23abb)

### 13.2. Scénario de test de la gestion du personnel

#### 13.2.1. Ajouter un employé

À partir de la liste des employés, on clique sur le bouton `Ajouter` pour ajouter un employé. La fenêtre d'ajout d'un employé s'affiche. On saisit les informations de l'employé et on clique sur le bouton `Ajouter`.
  
![08-ajout_personnel](https://github.com/briacl/Mediatek86/assets/102411894/52d7b956-972e-4142-ad82-6c50fbba897e)

On véricie que l'employé a bien été ajouté en consultant la liste des employés. 

#### 13.2.2. Modifier un employé

Ensuite on clique sur le bouton `Modifier` pour modifier les informations de l'employé. On modifie les informations de l'employé et on clique sur le bouton `Enregistrer`.  

![09-personnel_ajoute](https://github.com/briacl/Mediatek86/assets/102411894/c48553d0-b9a7-49c6-ba94-0d3bd9cdfc07)

Conformément au cahier des charges, un message de confirmation s'affiche pour confirmer la modification de l'employé.  

![11-modification_personnel](https://github.com/briacl/Mediatek86/assets/102411894/3908ca70-8b66-490a-87d0-2b75d60152af)
![10-confirmation_modification](https://github.com/briacl/Mediatek86/assets/102411894/e85f8f16-99ac-4b54-9f6a-a90a6f31e5be).  

![12-modification_enregistree](https://github.com/briacl/Mediatek86/assets/102411894/cbfd8c0c-cc3f-428d-a787-35c1bc3d0b9f)

Après confirmation on vérifie que les modifications ont bien été enregistrées en consultant la liste des employés.  

![13-validation_modification](https://github.com/briacl/Mediatek86/assets/102411894/68e68c93-e713-4aef-a1ae-c25877564f01)

#### 13.2.3. Supprimer un employé

À partir de la liste des employés, on sélectionne un employé.  
On clique sur le bouton `Supprimer` pour supprimer un employé. Un message de confirmation s'affiche pour confirmer la suppression de l'employé. Conformément au cahier des charges, un message de confirmation s'affiche pour confirmer la suppression de l'employé.  
![14-confirmation_suppression](https://github.com/briacl/Mediatek86/assets/102411894/29738d83-0183-4b54-a7b4-eb56cbef3e0e)

Après confirmation on vérifie que l'employé a bien été supprimé en consultant la liste des employés.  

![06-Capture d’écran 2024-06-04 185459](https://github.com/briacl/Mediatek86/assets/102411894/a6796c6d-131b-41fc-88bb-d6320c975524)


### 13.3. Scénario de test de la gestion des absences

#### 13.3.1. Ajouter une absence

À partir de la liste des employés, on sélectionne un employé, on clique sur le bouton `Absences` pour consulter la liste des absences. La liste des absences s'affiche.  

![15-liste_absences](https://github.com/briacl/Mediatek86/assets/102411894/c0728719-f8f0-4f8c-93e0-282cee0cc5c3)

On clique sur le bouton `Ajouter` pour ajouter une absence. La fenêtre d'ajout d'une absence s'affiche.

![20-ajouter_absence](https://github.com/briacl/Mediatek86/assets/102411894/c8211447-c47c-46de-80cc-7810c57aef9e)

On saisit les informations de l'absence et on clique sur le bouton `Ajouter`.

![21-ajouter_absence_confirmation](https://github.com/briacl/Mediatek86/assets/102411894/ea0ef504-1a2f-4d59-8ff5-80fdd0fafdd9)

On contrôle alors que l'absence a bien été ajoutée en consultant la liste des absences.

![22-ajouter_absence_vérification](https://github.com/briacl/Mediatek86/assets/102411894/25124a50-4c1a-47c4-bbba-bd0cf0df5854)


##### 13.3.1.1. Vérification du chevauchement des dates

Pour éviter les chevauchements de dates, nous avons ajouté une vérification dans la méthode `Chevauche` de la classe `Absence`. Cette vérification consiste à vérifier si la date de début et la date de fin de l'absence à ajouter chevauchent les dates d'une autre absence pour le même employé. Si un chevauchement est détecté, un message d'erreur est renvoyé pour indiquer que l'absence ne peut pas être ajoutée.

On teste cette fonctionnalité en ajoutant une absence qui chevauche une autre absence pour le même employé. Un message d'erreur s'affiche pour indiquer que l'absence ne peut pas être ajoutée.

![24-absence_chevauchement](https://github.com/briacl/Mediatek86/assets/102411894/aa1d4182-b739-47af-9a33-0960a67c03c0)


#### 13.3.2. Modifier une absence

Sans sélectionner une absence, on clique sur le bouton `Modifier`. Un message d'erreur s'affiche pour indiquer qu'aucune absence n'a été sélectionnée. 

![16-liste_absences_defaut_selection](https://github.com/briacl/Mediatek86/assets/102411894/4d5c7303-4667-4325-a8e3-460c1f9a37c7)

On sélectionne une absence dans la liste des absences et on clique sur le bouton `Modifier`. La fenêtre de modification d'une absence s'affiche. On modifie les informations de l'absence et on clique sur le bouton `Modifier`.

![17-modifier_absence](https://github.com/briacl/Mediatek86/assets/102411894/539f5f12-2f74-4e3c-9ddc-67628ced56b1)

Une demande de confirmation s'affiche pour confirmer la modification de l'absence.

![18-modifier_absence_confirmation](https://github.com/briacl/Mediatek86/assets/102411894/a97ccf01-6e0e-46a3-85b3-fca57471455b)

Une fois la modification effectuée, un message de confirmation s'affiche pour indiquer que la modification a bien été enregistrée.

![19-modifier_absence_effectuee](https://github.com/briacl/Mediatek86/assets/102411894/86d7818a-62ab-4259-b523-cba79e24ba0b)

#### 13.3.3. Supprimer une absence

On sélectionne une absence dans la liste des absences et on clique sur le bouton `Supprimer`. Une demande de confirmation s'affiche pour confirmer la suppression de l'absence.

![23-supprimer_absence_confirmation](https://github.com/briacl/Mediatek86/assets/102411894/17fd0df2-03d4-4a9f-8a6d-3663b55c855f)

On vérifie que l'absence a bien été supprimée en consultant la liste des absences.
