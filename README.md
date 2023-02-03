# Projekt-GameShop 
1. Opis  mojego projektu 
"Game-Shop", ten sklep  zrobieny dla pomocy przy wybrenie  gry dla komputera, konsolli, a jeżeli trzeba do i dla smartphona

2. Konfiguracja aplikacji
Żeby mozna było skorzystać z aplikacji potrzebno zrobić kolejnie kroki, taki jak:

1.Najpierw,  trzeba  wykorzystać 5 płkików migracjii .Niżej napisany jaki  trzeba 

One zanjdują się nagórze w pasku: Narzędziania > Menedrzer Pakietów NuGet > Zarządzanie Pakietami NuGet ... . > Przeglądaj.

Musimy wpisać w wyszukiewarce i zainstalować takie pakiety:

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.VisualStudio.Web.CodeGeneration.Design
2.Podrugie, musimy zrobić "Migracje":

Na dolnym pasku znajduje się przycisk, "Konsole menedżera pakietów" tam musimy wpisać, takie komendy:

(Te komedy, odpowiadają za migracje autoryzacje)

add-migration UserInit -context UserContext
update-database -context UserContext
(Te komedy, odpowiadają za migracje tabelów)

add-migration InitialCreate -context AppDbContext
update-database -context AppDbContext
3. Dodania administrator (czyli pracownika)
Żeby dodać administratora potrzebno zrobić kolejnie kroki:

Zarejestrować Administratora. Rejestracja i Logowanie, znajduję się w rogu wprawej stronie na górze.
Człowiek jaki ptorzebuje utworzenia konto w naszem sklepe  (np. admin1@gmail.com).

Podać hasło, 2 razy. Uwaga hasło musi zawierać chóciaż 8 dowolnych symbolów, jedną cyfre(np. 0-9), litery jedną wielką, a drugą małą (np. Qw) i dowalnę symbolę(np. !). W całoszci hasło, musi wyjść tak (np. 12345678Qw!)

Pan(-i), musi ustalić tego admina w Baze danych, ktorego zarejestrował(-ła). Musi otwórzyć aplikacje bazy danych, (np. SQL lub inne).

W Bazie danych, z lewa jest panel "Object Explorer", tam musimy wybrać swoją nazwe bazy danych.

Pan(-i), musi kliknąć na tabele pod nazwą "dbo.AspNetRoles" > Edit Top 200 Rows.

Dodawanie  image 
To rzeba zainstalować obraaz z internetu 
1) Trzeba wpisać szeczki teego image( naprzykład folderu gdzie wszystki obrazy)
2)  Trzeba  w Visual Studio wpisać id tego image 

Opis  wkadcy gry 
W tej wkdladcy można dodać  gry , genre  , ceny gry .Naprzykad można dodać swoje ulubijone gry. Dodać genre i ten skłep moge dodać jego do erkranu glównego .
Można napisać nazwe , genre  i ceny swojej ulubijonej gry 


Collection of game
Ta wkladka  odpowieda za collection .Naprzykład jakieś prezynta od developera dla pana(i) który  kupiłi gru.To może być mapa świata gry , postać gracza
Na tej wkladce można wybrać еdycjе  kolekcjonerske  z gry , wybrać ceny tej edycji .Tak samo jak iz gierkami , można u

Funkcjii
1) Dodawanie - można dodać gry dla komputera , konsolii , telefona
2) Dodawanie Genre- Można wybrać genre gry ,albo zmienić genre .Naprzykład: Call of Dury to shooter , Fifa 23- Sport Simulator i tak dalej
3) Delete - to funkcja usuwania jednej gry ,albo calej kolkcjii gier




