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
