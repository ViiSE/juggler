<p align="center"> 
<img src="https://user-images.githubusercontent.com/43209824/150384221-6087fedd-9e52-4a03-a0e4-4248be39a3d0.png"
     width="256" height="256">
</p>

[RU - Русский](https://github.com/ViiSE/juggler/blob/main/README-RU.md)

# Juggler
Hot swap JDK on Windows

## Why?
There was a need to use the JDK at the system level on the fly. For Linux and Mac OS, for example, there is a solution 
like [SDKMAN!](https://github.com/sdkman). Of course, it can be installed on Windows, for example, via mingw or git.
But SDKMAN! will only change the JDK at the mingw level, not at the Windows level. There is also a solution like 
[jabba](https://github.com/shyiko/jabba), but it also only changes the JDK at the session level. For these reasons 
Juggler was made.

## How it works?
Juggler modifies the `JAVA_HOME` and `PATH` environment variables. In `PATH` it sets a value that specifies at least 
one user-specified pattern (`Edit/Change JDK path patterns...` tab). If patterns is not specified, Juggler create the 
pattern `\java\jdk`. Notice that pattern and environment variable lowercase translation when searching.

## Functionality
 1. Creates and modifies the list of available JDKs: Each JDK has a path and an alias (name in human-readable format)
 2. Sets JDK that will be used by default from the list of available JDKs
 3. Creates and modifies the list of patterns used to find executable JDK folder in `PATH`
 4. Juggler minimizes to System Tray. To do this, you need to close the program through the system button `Close` 
    (red cross). In System Tray you can also change the JDK on the fly and perform actions with PATH and JAVA_HOME
 5. Get, save, restore JAVA_HOME and PATH and restore the registry key `HKEY_CLASSES_ROOT\jarfile\shell\open\command` by
    saved JAVA_HOME variable
 6. Changing the JDK also changes the value of the `HKEY_CLASSES_ROOT\jarfile\shell\open\command` registry key. The key
    is needed so that the jar file opens when the mouse is double-clicked

## Peculiarities
 1. Changing system environments requires administrator privileges. Therefore, the program is used in mode 
    `as administrator`
 2. Changing system environment variables is a rather long process (10-15 seconds). Why is that - I don't know. If you 
    knows, I will be grateful for the answer! For change environment variable I use
   `Environment.SetEnvironmentVariable("ENV_VAR", envVarValue, EnvironmentVariableTarget.Machine)`
 3. To save state, Juggler creates a `.juggler` folder in the user folder. In this folder in the `settings.json` file 
    the list of JDK is stored, including the default JDK, and the list of patterns used to find executable JDK folder in
    `PATH`

## How to use?
Extract the [archive](https://github.com/ViiSE/juggler/releases/latest) in any directory and run `Juggler.exe`.
