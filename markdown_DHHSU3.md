# Pontozólap 

Név: Zsámbokréty Zsófia

Neptun: DHHSU3

## Projekt rövid leírása:

A projektem egy asztali- és egy webalkalmazás fejlesztése a JóAutók kitalált autószalon adatainak nyilvántartására. Az Azure SQL alapú adatbáziban találhatóak az adatok, melyeket API végpontokon keresztül, illetve a Scaffold-al ér el a rendszer. Az asztali alkalmazás Windows Forms technológiával készült, adatkötéseket és dinamikus UI elemeket használva. A weboldal dinamikusan tölthető tartalommal, CSS-sel és JavaScript funkciókkal egészül ki. A rendszer célja a könnyen kezelhető, átlátható adatnyilvántartás biztosítása.

## Hozott anyagok:

##### Saját Adatbázis
![image](https://github.com/user-attachments/assets/7bb7f95a-560a-4611-9f18-56c63fb77ceb)
![image](https://github.com/user-attachments/assets/55f43ef6-cbf5-421d-ab93-1fb87e596e77)

-   `1x1p`  Az alkalmazásban használt táblánként pont (Cars)
-   `2p`  Az adatbázis saját Azure SQL szerveren van
-   `1p`  Az adatbázis adatainak forrásmegjelölése értsd: 
                          Az adatbázis adatai fiktívek, a fejlesztés során a ChatGPT által generált tartalmakat használtam. Ezek a mintaadatok kizárólag a projekt demonstrációs céljait szolgálják, és nem valós személyekre, eseményekre vagy szervezetekre utalnak.

Részösszeg:  `4p`

##### Weboldal
https://www.screentogif.com/
![image](https://github.com/user-attachments/assets/b52f97f3-29d3-459b-9d1d-8a1c299f3e4b)

-   `1p`  A weboldalnak van egy értelmezhető struktúrája
-   `1p`  A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
-   `1p`  A weboldal használ legalább 20 sor értelmes css-t
-   `1p`  A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése (új rögzítése, törlés)

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
![image](https://github.com/user-attachments/assets/18d487e9-675a-4394-8bd0-a24469fd28e9)
![image](https://github.com/user-attachments/assets/fe71264b-5d1e-48ba-b503-d323f828e566)

- `1x2p` Az alkalmazásból a **kilépés csak megerősítő kérdés után** lehetséges. 
- `3x2p` Olyan alkalmazás **elrendezés, melyben gombok lenyomására UserControl-ok kerülnek elhelyezésre egy Panel vezérlőben**, teljesen kitöltve azt. Minden gombra jár a pont, amennyiben az funckuonlalitással rendelkező UserControl-t tölt be. 
- `1x2p` **Anchorok alkalmazása**: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület.

Részösszeg:  `10p`

##### Tábla adatainak megjelenítése `ListBox`-ban. 
![image](https://github.com/user-attachments/assets/12738ad5-72a0-4efd-9ee6-6778eae35bf7)

- `1x2p` Adatok  megjelenítése 
- `2x2p` Ha az adatok tetszőleges módszerrel, pl. `TextBox`-on keresztül szűrhetőek.

Részösszeg:  `6p`

##### Tábla adatainak megjelenítése `DataGridView`-ban 
![image](https://github.com/user-attachments/assets/14929a8a-818b-4f81-b17d-8a46da1179f3)

- `1x2p` Adatok  megjelenítése

Részösszeg:  `2p`  

##### Adatkötés `BindingSource` -on keresztül

- `1x2p` Működő  `BindingSource` 
- `3x1p` Egy `BindingSource`-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint `TextBox`, `DateTimePicker`, `ComboBox` idegen kulcs értékének beállítására, stb.

Részösszeg:  `5p`  

##### Új rekord rögzítése 
![image](https://github.com/user-attachments/assets/533c5e4e-99d2-4ad4-b5b8-650ffa65d3fb)

- `1x1p` Ha legalább egy nem kulcs mező, pl. _Mennyiség_ is fel van véve
- `1x2p` Felugró ablakon keresztül történik _Ok_ és _Mégse_ gombbal
- `1x2p` Ha az űrlap legördülő dobozon vagy listán keresztül beállítható idegen kulcsot is tartalmaz

Részösszeg:  `5p`  

#####  Rekord törlése 
![image](https://github.com/user-attachments/assets/a90394ab-df04-4bdd-89de-5cdc7bc1105f)

- `1x2p` Sikeres törlés
- `1x2p` Megerősítéshez kötött törlés

Részösszeg:  `4p`  

Részösszeg:  `32p`  Eddig:  `58p`

### Egyéb, extra

- `1x1p`  `Scaffold-DbContext` használata (ajándék)

Részösszeg:  `1p`  Eddig:  `59p`

## Összessen:  `59p`
