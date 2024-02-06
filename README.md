# CRUD

        //CTRL . pour créer les constructeurs.
        //propfull
        //ctor


        // #region


# github commandes

echo "# priserdv2" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin git@github.com:wnx82/cv_angular.git
git push -u origin main


git remote -v
git remote remove origin

git commit --amend
git push --force


git --version


enlever les nodes modules

git rm -r --cached node_modules
git commit -m "Remove node_modules"
git push


Create new Branch

git checkout -b newbranch
git push origin newbranch
git push --set-upstream origin newbranch


git clone -b branch link


http-server . -p 8083 -c-1 pour éviter le cache

dernière version
git reset --hard HEAD
git pull

pour avoir les logs
git log

pour tirer la dernire version
git stash
git pull


git checkout -b feat/addValidators
git branch
git status
git add .
git commit -m "feat(validator)"
git push


git fetch --all
git checkout .
git status


git branch video-11
git branch

git branch --all
git checkout video


git push origin main



git checkout b7c9c544f3d8c1b143f78ebd3063073c307940f9


  // ! sudo chmod -R 766 /root/personal-projects/gdp-back/public/images
  
Créer une branche
git checkout -b feat/passportStrategy
git push --set-upstream origin feat/passportStrategy

RESET
git reset --hard

pour mettre à jour la branche main
git checkout main
git merge <nom-de-votre-branche>
git push origin main

Restaurer une version de git différente:
git checkout 77616401baf1ef2e591214afdf470aa5bae10c52

pour créer une nouvelle branche
git switch -c feat/sendMailValidation
pour annuler
git switch -


Ajouter un dossier dans le gitignore et mettre à jour
git rm -r mon_dossier
git add .
git commit -m "update remove dir"
git push


push sans commit
git add .
git commit --amend --no-edit
git push --force

# Packages Nuget

1.	Blazored.Toast: Une bibliothèque permettant d'afficher des notifications toast dans une application Blazor.
2.	Blazorise: Un composant de la bibliothèque qui offre un ensemble de composants d'interface utilisateur pour Blazor avec support pour différents CSS frameworks.
3.	Blazorise.Icons.FontAwesome: Extension de Blazorise qui permet d'utiliser les icônes FontAwesome dans une application Blazor.
4.	FontAwesome: Une police d'icônes populaire utilisée pour ajouter des icônes vectorielles et sociales à votre site web ou votre application.
5.	Microsoft.AspNet.WebApi.Client: Fournit des fonctionnalités pour appeler des API HTTP dans une application ASP.NET.
6.	Microsoft.AspNetCore.Components.Forms: Fournit des composants et des fonctionnalités pour créer des formulaires dans une application Blazor.
7.	Microsoft.AspNetCore.Components.WebAssembly: Permet de construire des applications Blazor qui s'exécutent dans le navigateur à l'aide de WebAssembly.
8.	Microsoft.AspNetCore.Components.Authorization: Ce package fournit des fonctionnalités d'autorisation pour les applications Blazor. Il permet d'intégrer un système d'autorisation basé sur des rôles et des revendications, facilitant ainsi la gestion des droits d'accès des utilisateurs dans votre application.
9.	Microsoft.EntityFrameworkCore: Un ORM (Object-Relational Mapper) qui permet d'interagir avec la base de données en utilisant des objets .NET.
10.	Microsoft.EntityFrameworkCore.SqlServer: Le provider pour utiliser Entity Framework Core avec SQL Server.
11.	Microsoft.EntityFrameworkCore.Tools: Des outils supplémentaires pour travailler avec Entity Framework Core depuis la ligne de commande.
12.	Microsoft.VisualStudio.Web.CodeGeneration.Design: Utilisé pour la génération de code dans les projets ASP.NET Core.
13.	NewtonSoft.Json: Une bibliothèque populaire pour travailler avec JSON en .NET.
14.	Syncfusion.Blazor: Un ensemble de composants UI pour Blazor, permettant de créer des applications riches et interactives.
15.	System.ComponentModel.Annotations: Fournit des attributs qui sont utilisés pour définir des métadonnées pour les classes de modèle d'objet.
16.	System.Net.Http.Json: Permet l'envoi et la réception de requêtes HTTP avec du contenu JSON dans .NET Core.

# Blazor Crud 
https://github.com/AnkitSharma-007/ASPCore.BlazorCrud


# service informatique

Le pôle « PAO » (publication assistée par ordinateur) travaille en support aux services communaux pour l’élaboration de documents de publication et communication (affiches, livrets, flyers…), voire même pour l’impression.  La PAO gère également l’édition de statistiques ou de listings spécifiques nécessaires aux actions ciblés de certains partenaires communaux ou para-communaux.

Le pôle « Système » assure l’appui technique nécessaire au bon fonctionnement et à la continuité de l’infrastructure informatique mis à la disposition du personnel de l’Administration pour son travail quotidien.  Parmi ses missions, on retrouve : 
1.	la gestion de l’infrastructure matériel (serveurs, PC, imprimantes, …) et applicative (logiciels métiers externes), 
2.	la gestion du réseau informatique, 
3.	la téléphonie, 
4.	la mise en œuvre et le suivi de la sécurité informatique, 
5.	la gestion des pannes et incidents, 
6.	les maintenances correctives et préventives, 
7.	le prêt et installation de matériels pour des évènements ponctuels, l
8.	a réalisation d’études d’améliorations techniques, …
Le pôle « Programmation » assure l’analyse des besoins, le développement, l’exécution des tests et la maintenance de solutions logicielles spécifiques afin de répondre aux besoins des services de l’Administration, ainsi que la présentation et la formation des utilisateurs finaux.
Enfin, le « Service Imprimerie » est également rattaché au Service Informatique.  En collaboration avec le pôle « PAO », l’imprimerie assure les impressions de documents, ainsi que leur massicotage et pliage éventuels.  Il en va de même pour le pliage et l’enveloppage des courriers.
La gestion des stocks de consommables et des incidents sur imprimantes lui revient également.
