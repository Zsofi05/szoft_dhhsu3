# Pontozólap minta

Név: Zsámbokréty Zsófia

Neptun: DHHSU3

## Projekt rövid leírása:

Egy egyszerű asztali alkalmazás és webapplikáció a JóAutók kitalált autószalon nyilvántartásához. 

## Hozott anyagok:

##### Saját Adatbázis
![image](https://github.com/user-attachments/assets/7bb7f95a-560a-4611-9f18-56c63fb77ceb)
![image](https://github.com/user-attachments/assets/55f43ef6-cbf5-421d-ab93-1fb87e596e77)

-   `1x1p`  Az alkalmazásban használt táblánként pont (Cars)
-   `2p`  Az adatbázis saját Azure SQL szerveren van
-   `1p`  Az adatbázis adatainak forrásmegjelölése értsd: miből készült és hogyan:  ...............

Részösszeg:  `4p`

##### Weboldal
![image](https://github.com/user-attachments/assets/b52f97f3-29d3-459b-9d1d-8a1c299f3e4b)

-   `1p`  A weboldalnak van egy értelmezhető struktúrája
-   `1p`  A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
-   `1p`  A weboldal használ legalább 20 sor értelmes css-t
-   `1p`  A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése

Részösszeg:  `4p`  Eddig:  `8p`

### ASP .NET

-   `2p`  `program.cs`  beállítása  `wwwroot`  mappában tárolt statikus tartalmak megosztására

##### API végpontok

![image](https://github.com/user-attachments/assets/2615968d-a074-4713-bd0b-834109ea4566)

-   `3p`  Teljes SQL tábla adatainak szolgáltatása API végponton keresztül 
-   `1x2p`  SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül 
-   `3p`  SQL tábla egy választható rekordjának törlése 
-   `5p`  Új rekord felvétele  `HttpPost`  metóduson keresztül SQL táblába 
-   `1x3p`  Rekord módosítása  `HttpPost`  metóduson keresztül SQL táblában 

Részösszeg:  `18p`  Eddig:  `26p`

### Windows Forms Application

##### User Interface 

- `1x2p` Az alkalmazásból a **kilépés csak megerősítő kérdés után** lehetséges. 
- `3x2p` Olyan alkalmazás **elrendezés, melyben gombok lenyomására UserControl-ok kerülnek elhelyezésre egy Panel vezérlőben**, teljesen kitöltve azt. Minden gombra jár a pont, amennyiben az funckuonlalitással rendelkező UserControl-t tölt be. 
- `1x2p` **Anchorok alkalmazása**: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület.

Részösszeg:  `10p`

##### Tábla adatainak megjelenítése `ListBox`-ban. 

- `1x2p` Adatok  megjelenítése 
- `2x2p` Ha az adatok tetszőleges módszerrel, pl. `TextBox`-on keresztül szűrhetőek.

Részösszeg:  `6p`

##### Tábla adatainak megjelenítése `DataGridView`-ban 

- `1x2p` Adatok  megjelenítése

Részösszeg:  `2p`  

##### Adatkötés `BindingSource` -on keresztül

- `1x2p` Működő  `BindingSource` 
- `3x1p` Egy `BindingSource`-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint `TextBox`, `DateTimePicker`, `ComboBox` idegen kulcs értékének beállítására, stb.

Részösszeg:  `5p`  

