


$Notepad    = 'C:\Windows\notepad.exe'
$MSBuildExe = 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\MSBuild.exe'

New-ShellVerb -KeyName 'MSBuild.Build' -VerbName 'Build' -Icon $MSBuildExe -Command "cmd.exe /k `"$MSBuildExe`" /m %1" -Verbose -Force

New-ShellVerb -KeyName 'MSBuild.Rebuild' -VerbName 'Rebuild' -Icon $MSBuildExe -Command "cmd.exe /k `"$MSBuildExe`" /m /t:Rebuild %1" -Verbose -Force

New-ShellVerb -KeyName 'MSBuild.Restore' -VerbName 'Restore' -Icon $MSBuildExe -Command "cmd.exe /k `"$MSBuildExe`" /m /t:Restore %1" -Verbose -Force

New-ShellVerb -KeyName 'MSBuild.Clean' -VerbName 'Clean' -Icon $MSBuildExe -Command "cmd.exe /k `"$MSBuildExe`" /m /t:Clean %1" -Verbose -Force

New-ShellVerb -KeyName 'MSBuild.Edit' -VerbName 'Edit' -Icon $Notepad -Command "notepad.exe %1" -Verbose -Force

