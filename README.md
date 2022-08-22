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
git submodule add https://github.com/PJChamley/Demo_Service1 SubModules/Demo_Service1
git submodule add https://github.com/PJChamley/Demo_Service2 SubModules/Demo_Service2
```

This is the result I had running the above command:

![image.png](/.readmemd/git.submodules/add.submodule.command.result.png)

By default, submodules will add the subproject into a directory named the same as the repository, in this case "Demo_Common". But as you can see we have told the submodules to be create under a folder structure this should keep multiple submodles in the same location and thing should be a bit cleaner.

If you run 'git status' at this point, you’ll notice a few things.
```
git status
```
![image.png](/.readmemd/git.submodules/git.status.command.after.just.adding.submodule.png)



First you should notice the new .gitmodules file. This is a configuration file that stores the mapping between the project’s URL and the local subdirectory you’ve pulled it into:

![image.png](/.readmemd/git.submodules/.gitmodules.example.content.png)

If you have multiple submodules, you’ll have multiple entries in this file. It’s important to note that this file is version-controlled with your other files, like your .gitignore file. It’s pushed and pulled with the rest of your project. This is how other people who clone this project know where to get the submodule projects from.