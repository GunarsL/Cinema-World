# DP4-2

# Gunārs Leitāns

# Kvalifikācijas darbs

### Kvalifikācijas darba uzdevums ir izveidot kinematogrāfijas jeb filmu un seriālu favorītu sistēmu. Sistēmas mērķis ir ļaut lietotājiem apskatīt kinematogrāfijas klāstu, izvēlēties sev iecienītākos izpildījumus un pievienot savam favorītu sarakstam. To vēlāk ir iespējams apskatīt, noņemt kinematogrāfiju un dalīties ar savu sarakstu, sniedzot sava profila saiti.

## Izmantotās tehnoloģijas
Lai sistēmu veiksmīgu spētu izmantot gan lietotāji, gan administratori, ir nepieciešams nodrošināt to ar jaunākām tehnoloģijām un versijām, kuras tiek izmantotas. Sistēmas pamantā ir C# MVC ietvaros un atbilstošās tehnoloģijas - Entity Framework, SQL datubāze, HTML/CSS.
- C# MVC ietvaros ar jaunāko, 6.0 tehnoloģijas versiju ilgspējīgai izmantošanai un jaunākām funkcijām.
- SQL datubāze ar tiešu saistību, pateicoties jaunākajai MVC versijai. SQL datubāzes versija projekta ietvaros ir SQL 15.0.18390.0.
- Azure mākoņpakalpojumi, lai spētu izmantot sistēmu ārpus lokālās vides. Ir nepieciešama resursu grupa, kurā ir iekļauti Azure SQL Server/Database pakalpojumi datu bāzes izmantošanai un Azure App Service pašas sistēmas uzstādīšanai.

## Izmantotie moduļi
Papildus sistēmas galvenajām funkcijām, sistēmai piemīt arī nelieli vizuālie elementie, kurus var vienkārši izmantot, pateicoties šie moduļiem:
- Instagram modulis
- Google Maps modulis
- Bootstrap modulis

## Sistēmas uzstādīšanas instrukcija
Lai sistēmai varētu piekļūt jebkurš lietotājs, to ir iespējams vienkārši atvert jebkurā atbalstītā pārlūkprogramma ar atbilstošu saiti. Lai sistēmu varētu papildināt/uzstādīt un tādējādi piekļūt paša koda daļai, ir nepieciešams uzstādīt Visual Studio uz datora. Sistēmas izveidot tika izmantota Visual Studio Enterprise 2022 versija, un ir ieteicams izmantot šo vai jebkuru jaunāku versiju par šo. Lai klonētu sistēmu, ir nepieciešams iegūt visu nepieciešamo no repozitorija GitHub vidē, taču lai sistēmu uzstādītu, pirmajai reizei ir nepieciešams iegūt noteiktus rīkus, kurus izmantoja sistēmas izstrādes laikā.

### Sistēmas pirmās palaišanas priekšnosacījumi

![Pirmais solis programmas uzstādīšanai.](https://github.com/GunarsL/Cinema-World/assets/70687877/7c23fc46-03ad-40d1-be80-91e816f84655)

Lai iegūtu papildus rīkus, kurus izmantoja sistēmas izveidie, nepieciešams tos iegūt papildus sadaļa, kuru ir iespējams atrast, nospiežot pogu "Modify".

![Otrais solis programmas uzstrādīšanai.](https://github.com/GunarsL/Cinema-World/assets/70687877/3d81e911-77e9-4c6a-802d-066ceaf6757b)

![Trešais solis programmas uzstādīšanai.](https://github.com/GunarsL/Cinema-World/assets/70687877/a6b80a7b-fe8d-4ab2-a9a0-5160946973b4)

![Ceturtais solis programmas uzstādīšanai](https://github.com/GunarsL/Cinema-World/assets/70687877/5a9bbacb-7dd1-42d4-91d2-ca65fb851a54)

Papildus rīku sadaļā nepieciešamos rīkus ir jāizvēlas pirmajā sadaļā "Workloads", kā arī sadaļā "Installation details", kur ir nepieciešams atvērt katru pieejamo sadaļu un jāizvēlas visi piedāvātie rīki, ja tas jau nav izdarīts.

### Sistēmas klonēšana vai uzstādīšana

Kad sistēmas priekšnosacījumi ir izpildīti un viss nepieciešamais ir ielādēts, var pāriet uz pašas sistēmas klonēšanu vai izveidi. To var izdarīt, vai nu no pirmā soļa, nospiežot pogu "Launch" vai atverot jauno lietotājprogrammu Visual Studio.

![Pirmais solis sistēmas klonēšanai vai uzstādīšanai](https://github.com/GunarsL/Cinema-World/assets/70687877/38ea2a01-701a-4413-a2c1-fc85a5152cd0)

Pirmais solis jau sniedz iespēju vai nu izveidot jaunu sistēmu vai klonēt to. Sistēmas klonēšana ir vienkāršs process, kas sevī ietver izvēlēties iespēju klonēt "Clone a repository", kas pieprasīs saiti ar repozitoriju, kas automātiski uzstādīs to un atvērs. Ja sistēmu vēlas uzstādīt pa jaunu un tad ātkārtoti to izveidot, ir jāizvēlas iespēja "Create a new project".

![Otrais solis sistēmas klonēšanai vai uzstādīšanai](https://github.com/GunarsL/Cinema-World/assets/70687877/0acb24f1-730e-48d2-a104-589193b10a85)

Kad izvēlas uzstādīt sistēmu, ir nepieciešams izvēlēties MVC arhitektūras šablonu, uz kuras tiks balstīta visa sitēma.

![Trešais solis sistēmas klonēšanai vai uzstādīšanai](https://github.com/GunarsL/Cinema-World/assets/70687877/bb04c9f9-c3db-4040-ab8c-645e5350f6c2)

Jānorāda sistēmas nosaukumus. Kad tas tiek darīts, pāriet uz nākošo sadaļu.

![Ceturtais solis sistēmas klonēšanai vai uzstādīšanai](https://github.com/GunarsL/Cinema-World/assets/70687877/d0591a76-2af2-4785-80f0-434004e08177)

Sistēma tiek balstīta uz .NET 6.0 versijas, tādējādi nav ieteicams izmantot vecākas versijas, jo tās var nesaturēt funkcijas vai sistēmas var pamata līmeņos atšķirties.
Otrā izvēles iespēja apzīmē, vai kāda koda daļa tiks izveidota jau iepriekš - pāris HTML/CSS lapas un reģistrācijas/ielogošanās funkcionalitāte. Sistēmas izstrādes laikā tas netika izmantots, jo automātiska izveide arī paslēp modeļus, kurus pēc tam ir grūti atrast un modificēt.

![Pirmais solis papildus projekta funkcijām](https://github.com/GunarsL/Cinema-World/assets/70687877/0b1080ea-2ab2-4ec2-9fc5-cd26cfe7e01f)

![Otrais solis papildus projekta funkcijām](https://github.com/GunarsL/Cinema-World/assets/70687877/11a9dd7a-a00f-4030-9991-69e454eaecb6)

Sistēma izmanto arī funkcionalitātes, kuras nav aktivizētas un pievienotas, kad sākotnēji tiek izveidots projekts. Lai to pievienotu, ir nepieciešams izmantot NuGet Package Manager.

![Trešais solis papildus projekta funkcijām](https://github.com/GunarsL/Cinema-World/assets/70687877/51853796-7282-479a-8f37-338d86645396)

Lai izveidotu savienojumu ar datu bāzi, ir nepieciešams izveidot savienojumu un iegūt datu bāzes savienošanās atslēgu. Katras datu bāzes atslēga ir unikāla. Kad tas tiek darīts, ir divi veidi, lai izveidotu nepieciešamās tabulas, saites, datu tipus un pievienot to nosacījumus. Ir iespējams manuāli izveidot visu, taču ja ir izveidoti moduļi, kuriem ir pievienoti atslēgas vārdi, kas apzīmē saites un attiecības, tad cauri konsolei ir jāizveido migrācija, kura pārsūtīs informāciju uz datu bāzes daļu un automātiski izveidos visu nepieciešamo. Ir ieteicams izmantot otro metodi, jo tā atvieglo sistēmas izveidi, kā arī nodrošina pareizu izveidi, jo jebkura datu bāzes kļūda var traucēt sistēmas funkcionēšanai.

![Ceturtais solis papildus projekta funkcijām](https://github.com/GunarsL/Cinema-World/assets/70687877/8e217b81-73db-462b-85e5-131d49ab5e4f)

Ir jāievada komanda, lai izveidotu pirmatnēju migrāciju, kurai ir jānorāda nosaukumus, kuru vēlāk var apskatīt izveidotajā projektā.

![Pēdējais solis papildus projekta funkcijām](https://github.com/GunarsL/Cinema-World/assets/70687877/56cc49d9-e4d9-473d-bc61-e70f0d87e385)

Pēc veiksmīgas migrācijas izveidošanas, jānosūta dati uz datu bāzi, kur tiek izveidots viss nepieciešamais. Kad tiek saņemts paziņojums, ka migrācija ir veiksmīga, ir iespējams izmantot sistēmu un visas tās iespējāmās funkcijas.
