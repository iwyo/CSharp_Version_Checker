
![Logo](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/th5xamgrr6se0x5ro4g6.png)


# C# Version Checker CS for multiple apps

This CS retrieves the link and version number of the corresponding program from the previously entered PasteBin structure. I wrote it for myself because I have always been interested in how to write a simple and easy-to-use automatic update search code. This is my first solution, but maybe I will find a better solution in the future. If you are interested, feel free to download it and have fun with it. 

## Step-by-Step Tutorial

PasteBin:

First you have to go to https://pastebin.com. You need to make an account or if you have one just login. Now you need to make a new text documentum for the apps. You have to create an empty document where you will list the programs, their version and their link. For this, I link the test I created as a reference: https://pastebin.com/raw/vgpT0guy. The list should be made based on this. The first element will always be the ID of the program. Then comes the main version number of the program, separated by a semicolon. This is followed by the additional version number and then the link. You also need a semicolon after the link. If you have it and filled it out, choose a category for it at the bottom of the PasteBin page, set it so that the document never expires and that it is unlisted. This is important because no one can see it, only the one who has a link to it or the creator.


Importing and using the CS:

Open our project and download the CS file and add it to the project. Right-click on the project and add an existing element and browse the CS file. Let's go into the file and copy the pastebin link to our own.:
```
string PastebinLink = "YOURLINK";
```

Add the imported CS file to our main program.:

```
using VersionChecker;
```

If we have added it, let's call it.:
```
VersionCheck vs = new VersionCheck();
```

Call the **GerVersionLink** function and enter the previously entered program ID in string format.:
```
vs.GetVersionLink("Test");
```

Then we are ready. There are public ints and string that we can use.
```
MainVersion: This returns the main version number in int.
SubVersion: This returns the sub version number in int.
Program_Link: This returns the typed link to the program in string.
```

Example Console app:
```
using VersionChecker;

VersionCheck vs = new VersionCheck();
vs.GetVersionLink("Test");
Console.WriteLine(vs.MainVersion.ToString() + vs.SubVersion.ToString() + vs.Program_Link);
```


## Feedback

This is my first Github post. Plese be kind with me. ^^
Also if you have any feedback, please write me a pm.

