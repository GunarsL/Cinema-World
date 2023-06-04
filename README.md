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

![Pirmais solis programmas uzstādīšanai.](KD install step one visual studio modify.PNG)

Lai iegūtu papildus rīkus, kurus izmantoja sistēmas izveidie, nepieciešams tos iegūt papildus sadaļa, kuru ir iespējams atrast, nospiežot pogu "Modify".

![Otrais solis programmas uzstrādīšanai.](KD install step two web and cloud.PNG)

![Trešais solis programmas uzstādīšanai.](KD install step three other toolsets.PNG)

![Ceturtais solis programmas uzstādīšanai](KD install step four other necessities.PNG)

Papildus rīku sadaļā nepieciešamos rīkus ir jāizvēlas pirmajā sadaļā "Workloads", kā arī sadaļā "Installation details", kur ir nepieciešams atvērt katru pieejamo sadaļu un jāizvēlas visi piedāvātie rīki, ja tas jau nav izdarīts.

### Sistēmas klonēšana vai uzstādīšana

Kad sistēmas priekšnosacījumi ir izpildīti un viss nepieciešamais ir ielādēts, var pāriet uz pašas sistēmas klonēšanu vai izveidi. To var izdarīt, vai nu no pirmā soļa, nospiežot pogu "Launch" vai atverot jauno lietotājprogrammu Visual Studio.

![Pirmais solis sistēmas klonēšanai vai uzstādīšanai](KD install step five making the project.PNG)

Pirmais solis jau sniedz iespēju vai nu izveidot jaunu sistēmu vai klonēt to. Sistēmas klonēšana ir vienkāršs process, kas sevī ietver izvēlēties iespēju klonēt "Clone a repository", kas pieprasīs saiti ar repozitoriju, kas automātiski uzstādīs to un atvērs. Ja sistēmu vēlas uzstādīt pa jaunu un tad ātkārtoti to izveidot, ir jāizvēlas iespēja "Create a new project".

![Otrais solis sistēmas klonēšanai vai uzstādīšanai](KD install step six choosing project template.PNG)

Kad izvēlas uzstādīt sistēmu, ir nepieciešams izvēlēties MVC arhitektūras šablonu, uz kuras tiks balstīta visa sitēma.

![Trešais solis sistēmas klonēšanai vai uzstādīšanai](KD install step seven naming.PNG)

Jānorāda sistēmas nosaukumus. Kad tas tiek darīts, pāriet uz nākošo sadaļu.

![Ceturtais solis sistēmas klonēšanai vai uzstādīšanai](KD install final step creation.PNG)

Sistēma tiek balstīta uz .NET 6.0 versijas, tādējādi nav ieteicams izmantot vecākas versijas, jo tās var nesaturēt funkcijas vai sistēmas var pamata līmeņos atšķirties.
Otrā izvēles iespēja apzīmē, vai kāda koda daļa tiks izveidota jau iepriekš - pāris HTML/CSS lapas un reģistrācijas/ielogošanās funkcionalitāte. Sistēmas izstrādes laikā tas netika izmantots, jo automātiska izveide arī paslēp modeļus, kurus pēc tam ir grūti atrast un modificēt.

![Pirmais solis papildus projekta funkcijām](KD packet manager for additional tools.png)

![Otrais solis papildus projekta funkcijām](KD packet manager tools.PNG)

Sistēma izmanto arī funkcionalitātes, kuras nav aktivizētas un pievienotas, kad sākotnēji tiek izveidots projekts. Lai to pievienotu, ir nepieciešams izmantot NuGet Package Manager.

![Trešais solis papildus projekta funkcijām](KD packet manager console open.png)

Lai izveidotu savienojumu ar datu bāzi, ir nepieciešams izveidot savienojumu un iegūt datu bāzes savienošanās atslēgu. Katras datu bāzes atslēga ir unikāla. Kad tas tiek darīts, ir divi veidi, lai izveidotu nepieciešamās tabulas, saites, datu tipus un pievienot to nosacījumus. Ir iespējams manuāli izveidot visu, taču ja ir izveidoti moduļi, kuriem ir pievienoti atslēgas vārdi, kas apzīmē saites un attiecības, tad cauri konsolei ir jāizveido migrācija, kura pārsūtīs informāciju uz datu bāzes daļu un automātiski izveidos visu nepieciešamo. Ir ieteicams izmantot otro metodi, jo tā atvieglo sistēmas izveidi, kā arī nodrošina pareizu izveidi, jo jebkura datu bāzes kļūda var traucēt sistēmas funkcionēšanai.

![Ceturtais solis papildus projekta funkcijām](KD packet manager console first command.PNG)

Ir jāievada komanda, lai izveidotu pirmatnēju migrāciju, kurai ir jānorāda nosaukumus, kuru vēlāk var apskatīt izveidotajā projektā.

![Pēdējais solis papildus projekta funkcijām](kd packet manager console last command.PNG)

Pēc veiksmīgas migrācijas izveidošanas, jānosūta dati uz datu bāzi, kur tiek izveidots viss nepieciešamais. Kad tiek saņemts paziņojums, ka migrācija ir veiksmīga, ir iespējams izmantot sistēmu un visas tās iespējāmās funkcijas.