# harjoitusty-OikeaRepo_swd

Tässä tekstitiedostossa on lyhyet selitteet ohjelmista. Alla olevassa linkissä on video, jossa selitetään yleisesti harjoitustyöstä mm. Missä onnistuimme, mikä oli haastavinta, mitä korjaisimme ja testien käytöstä. Ensimäiset kaksi ohjelmaa teimme yhdessä, viimeiset kaksi ohjelmaa teimme "ohjelman mieheen." Lopputuloksena saimme jaettua kyllä molemmille tasaisesti kaiken työn. Käytimme Discordia ja Facebook messengiä palaveriohjelmana. Kommunikaatio sujui hyvin, vaihdoimme ideoita, virheitä ja vinkkejä päivittäin. Mielestämme tuo kommunikaatio vastaa SCRUM daily palavereita. Product backlog löytyy issues valikosta, Sprint backlogit löytyvät projects valikosta. Ensin käytimme Trelloa(täysin vastaava käytäntö), mutta vaihdoimme sen pian pois koska jäi turhaksi. Mielestämme onnistuimme loppujen lopuksi työssä hyvin. Opimme versionhallintaa, yksikkötestausta ja SCRUM-ketterää käytäntöä. 

Youtube videon linkki : https://www.youtube.com/watch?v=GpQwnyUWjFA

scrum harjoitustyöt ( Matkalasku-, palkkalaskenta-, kilometrikorvaus- ja laskutusohjelma)

Ohjelmien tekijät: Marko Nopri ja Joni Tanhuansuu.

Matkalasku

Ohjelman tarkoitus on matkalaskun valmistaminen, tarkastelu, muokkaaminen ja tarvittaessa poistaminen. Käyttäjä saa valita
viidestä vaihdoehdosta toiminnon: Lisää, näytä, muokkaa tai poista matkalasku. Viimeinen vaihtoehto on ohjelman sammuttaminen.
Jos käyttäjä valitsee "Lisää matkalasku" vaihtoehdon, ohjelma kysyy kaikki tarvittavat tiedot järjestyksessä. Laskun lisäämisen jälkeen ohjelma palaa etusivulle. "Näytä matkalasku(t)" toiminto näyttää matkalaskun, ohjelma kysyy halutaanko lasku tallentaa? Jos käyttäjä valitsee "Kyllä" ohjelma tallentaaa repon juurelle(kansion ulkopuolelle) matkalasku.txt josta löytyy kaikki samat tiedot. Ohjelmasta ei voi poistaa .txt tiedostoja, ne on poistettava manuaalisesti.
"Muokkaus" toiminnolla voi vaihtaa matkalaskun tietoja ja "poista" vaihtoehdolla laskun voi poistaa. Ohjelmaan voi tallentaa viisi matkalaskua. Matkalasku ohjelman main tiedosto on "matkalasku" kansiossa. Luokka päivärahoille yms. löytyy "matkalaskuCore" ja testit omasta kansiosta.


Kilometrikorvaus

Kilometrikorvausohjelmalla pystyy lisäämään halutun määrän myyntiedustajia, joille pystyy lisäämään yksittäisiä matkakuluja. Matkakuluihin lasketaan lisäksi mukaan kilometri- ja päivärahakorvaukset. Myyntiedustajien matkakulut voi näyttää yhteenvetona tai tarkastella tarkemmin valitun myyntiedustajan matkakuluja. Tämän Lisäksi ohjelmalla pystyy tarkastelemaan matkakulujen / korvauksien tilaa, onko matkakulu maksettu vai ei. Ohjelma sisältää muutamia testejä liittyen ohjelman toimivuuteen. Kaikki ohjelman tiedostot kilometrikorvaus kansiossa.

Palkkalaskenta

Ohjelmalla pystyy lisäämään työntekijöitä palkkoineen. Tämän lisäksi työntekijöitä pystyy muokkaamaan ja heidän palkan koostumustaan tarkastelemaan. Kaikki ohjelman tiedostot palkkalaskenta kansiosta.

Laskutusohjelma

Laskutusohjelmalla käyttäjä voi päättää kolmelle tasolle omat hinnat. Näitä voi myös muuttaa tarvittaessa. Käyttäjä voi lisätä asiakkaita, määrittää heille tason ja maksutavan(kk-maksu, 6kk sopimus tai 12kk sopimus.) Ohjelmasta voi tarkastella 6kk tulevat maksut. Käyttäjä voi muuttaa asiakkaan tasoa. Kaikki ohjelman tiedostot löytyvät laskutus kansiosta.

