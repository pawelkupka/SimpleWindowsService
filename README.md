# Simple Windows Service

Ten projekt to prosta aplikacja konsolowa, która będzie działać jako Windows Service. Można będzie ją zainstalować i odinstalować w Windows Services. Usługa po wystartowaniu będzie działać w nieskończoność i zapisywać co 1 sekundę jakieś dane do pliku tekstowego, dopóki nie zostanie wyłączona.


## Instalacja

- Skopiować pliki z katalogu bin z solucji do katalogu "C:\my-services\SimpleWindowsService"
- Otworzyć command prompt z prawami admina i wejść do "C:\my-services\SimpleWindowsService"
- Wpisać i uruchomić "SimpleWindowsService.exe install"
- Po zainstalowaniu uruchomić Windows Services z prawami admina i można już uruchomić usługę

## Odinstalowanie

- Otworzyć command prompt z prawami admina i wejść do katalogu "C:\my-services\SimpleWindowsService"
- Wpisać i uruchomić "SimpleWindowsService.exe uninstall"
