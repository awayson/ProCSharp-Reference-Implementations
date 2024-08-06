dotnet run /arg1 -arg2
$exitCode = $?
if ($exitCode -eq 0) {
   Write-Host "This application has succeeded!"
} 
else
{
   Write-Host "This application has failed!"
}
Write-Host "All Done."
