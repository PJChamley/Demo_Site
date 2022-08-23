# Demo_Site

## Add Git Sub modules.
for more information See [7.11 Git Tools - Submodules](https://git-scm.com/book/en/v2/Git-Tools-Submodules)
This file is a simplified version of this link at time of creation.


*** If you add Sub Modules while Visual Studio is open you will need to close and relaunch it to see multiple repositries in the Git Sections ***


From VS Code or Terminal windows.
Change to 'src' folder under Repository folder.

*** Make sure you are in the SRC Folder when adding Git Sub Modules ***

Run:
```
git submodule add https://github.com/PJChamley/Demo_Common SubModules/Demo_Common
git submodule add https://github.com/PJChamley/Demo_Service1 SubModules/Demo_Service1
git submodule add https://github.com/PJChamley/Demo_Service2 SubModules/Demo_Service2
```

This is the result I had when adding the Sercice1 & Service2 repos as sub modules.

![image.png](/.readmemd/git.submodules/add.submodule.command.result.png)

By default, submodules will add the subproject into a directory named the same as the repository, in this case "Demo_Common". But as you can see we have told the submodules to be create under a folder structure this should keep multiple submodles in the same location and thing should be a bit cleaner.

If you run 'git status' at this point, you'll notice a few things.
```
git status
```
![image.png](/.readmemd/git.submodules/git.status.command.after.just.adding.submodule.png)


If all is clone correctly then Vissual Studio 2022 should show multiple Repo in the Git changes Windows

![image.png](/.readmemd/git.submodules/visualstudio.2022.MultipleRepoSupport.png)

You can manage each repo from the Git Repositories windows.
You may need to commit and push to multiple repo's. Typically this required using the Git Repository Windows as pushing to multiple repo see to be a bit hit and miss.

Quickest way to Git Repo Windows is to click the link show below.
![image.png](/.readmemd/git.submodules/visualstudio.2022.GitRepoLinkFromGitChanges.png)

First you should notice the new .gitmodules file. This is a configuration file that stores the mapping between the project's URL and the local subdirectory you've pulled it into:

![image.png](/.readmemd/git.submodules/.gitmodules.example.content.png)

If you have multiple submodules, you'll have multiple entries in this file. It's important to note that this file is version-controlled with your other files, like your .gitignore file. It's pushed and pulled with the rest of your project. This is how other people who clone this project know where to get the submodule projects from.



### Issue after Cloning Parent Repo. Sub Modules may not be clonned correctly.

![image.png](/.readmemd/git.submodules/git.error1.png)


### Check the folder and see if Sub Modules are empty or look wrong.

![image.png](/.readmemd/git.submodules/git.submodule.pull.not.worked.png)

Issue above looks to be empty directory.

The directory is there, but empty. 



## Possible Fix 1
You must run two commands: git submodule init to initialize your local configuration file, and git submodule update to fetch all the data from that project and check out the appropriate commit listed in your superproject:

open up Terminal windows and Navigate root folder of the .
Then Run the following git commands.


```
git clone --recurse-submodules https://github.com/PJChamley/Demo_Site
```

If this does not work, next thing to try in each of the submodules is the following commands.
You may need to run 


```
git submodule init
```
 ## Show result for command.

```
 git submodule update
```


# Remove Sub module

```
# Remove the submodule entry from .git/config
git submodule deinit -f path/to/submodule

# Remove the submodule directory from the superproject's .git/modules directory
rm -rf .git/modules/path/to/submodule

# Remove the entry in .gitmodules and remove the submodule directory located at path/to/submodule
git rm -f path/to/submodule


```

Now Commit changes and push to remote.
