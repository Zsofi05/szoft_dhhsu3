# Pontozólap 

Név: Zsámbokréty Zsófia

Neptun: DHHSU3

## Projekt rövid leírása:

A projektem egy asztali- és egy webalkalmazás fejlesztése a JóAutók kitalált autószalon adatainak nyilvántartására. Egy Azure SQL alapú adatbázisban találhatóak az adatok, melyeket API végpontokon keresztül, illetve a Scaffold-al ér el a rendszer. Az asztali alkalmazás Windows Forms technológiával készült, adatkötéseket és dinamikus UI elemeket használva. A weboldal dinamikusan tölthető tartalommal, CSS-sel és JavaScript funkciókkal egészül ki. A rendszer célja a könnyen kezelhető, átlátható adatnyilvántartás biztosítása.

## Hozott anyagok:

##### Saját adatbázis
![image](https://github.com/user-attachments/assets/7bb7f95a-560a-4611-9f18-56c63fb77ceb)
![image](https://github.com/user-attachments/assets/55f43ef6-cbf5-421d-ab93-1fb87e596e77)

-   `1x1p`  Az alkalmazásban használt táblánként pont (Cars)
-   `2p`  Az adatbázis saját Azure SQL szerveren van
-   `1p`  Az adatbázis adatainak forrásmegjelölése: 
                          Az adatbázis adatai fiktívek, a fejlesztés során a ChatGPT által generált tartalmakat használtam. Ezek a mintaadatok kizárólag a projekt demonstrációs céljait szolgálják, és nem valós személyekre, eseményekre vagy szervezetekre utalnak.

Részösszeg:  `4p`

##### Weboldal
![Animáció](https://github.com/user-attachments/assets/48ff3786-0c9c-4422-85ad-484e61b08a41)

-   `1p`  A weboldalnak van egy értelmezhető struktúrája
-   `1p`  A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
-   `1p`  A weboldal használ legalább 20 sor értelmes css-t
-   `1p`  A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése (új rögzítése, törlés)

Részösszeg:  `4p`  Eddig:  `8p`

### ASP .NET

-   `2p`  `program.cs`  beállítása  `wwwroot`  mappában tárolt statikus tartalmak megosztására

##### API végpontok

![apik](https://github.com/user-attachments/assets/f7c071dd-28ad-42a9-b37c-3cdfc874cf8c)

-   `3p`  Teljes SQL tábla adatainak szolgáltatása API végponton keresztül 
-   `1x2p`  SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül 
-   `3p`  SQL tábla egy választható rekordjának törlése 
-   `5p`  Új rekord felvétele  `HttpPost`  metóduson keresztül SQL táblába 
-   `1x3p`  Rekord módosítása  `HttpPost`  metóduson keresztül SQL táblában 

Részösszeg:  `18p`  Eddig:  `26p`

### Windows Forms Application

##### User Interface 
![UI](https://github.com/user-attachments/assets/9befda29-889c-4a66-b626-2c5038bc5f7e)


- `1x2p` Az alkalmazásból a **kilépés csak megerősítő kérdés után** lehetséges. 
- `3x2p` Olyan alkalmazás **elrendezés, melyben gombok lenyomására UserControl-ok kerülnek elhelyezésre egy Panel vezérlőben**, teljesen kitöltve azt. Minden gombra jár a pont, amennyiben az funckionlalitással rendelkező UserControl-t tölt be. 
- `1x2p` **Anchorok alkalmazása**: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület.

Részösszeg:  `10p`

##### Tábla adatainak megjelenítése `ListBox`-ban. 
![listbox](https://github.com/user-attachments/assets/b27f0d46-4dd7-4b61-8639-edbc26012601)


- `1x2p` Adatok  megjelenítése 
- `2x2p` Ha az adatok tetszőleges módszerrel, pl. `TextBox`-on keresztül szűrhetőek.

Részösszeg:  `6p`

##### Tábla adatainak megjelenítése `DataGridView`-ban 


- `1x2p` Adatok  megjelenítése

Részösszeg:  `2p`  

![DatagV_BindingS](https://github.com/user-attachments/assets/8bdaba7e-ee84-4780-99d1-025e25521e4b)

##### Adatkötés `BindingSource` -on keresztül

- `1x2p` Működő  `BindingSource` 
- `3x1p` Egy `BindingSource`-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint `TextBox`, `DateTimePicker`, `ComboBox` idegen kulcs értékének beállítására, stb.

Részösszeg:  `5p`  

##### Új rekord rögzítése 

- `1x2p` Felugró ablakon keresztül történik _Ok_ és _Mégse_ gombbal

Részösszeg:  `2p`  

![torles_uj](https://github.com/user-attachments/assets/48a72c5f-ba69-45ac-bca0-8e90d31dce3a)

#####  Rekord törlése 

- `1x2p` Sikeres törlés
- `1x2p` Megerősítéshez kötött törlés

Részösszeg:  `4p`  

Részösszeg:  `29p`  Eddig:  `55p`

### Egyéb, extra

- `1x1p`  `Scaffold-DbContext` használata (ajándék)

"Scaffold-DbContext "Data Source=software9.database.windows.net;Initial Catalog=Student2;Persist Security Info=True;User ID=hallgato;Password=Alma1234;Encrypt=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir CarModels"

Részösszeg:  `1p`  Eddig:  `56p`

## Összessen:  `57p`
