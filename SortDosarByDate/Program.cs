// See https://aka.ms/new-console-template for more information
using SortDosarByDate;

Console.WriteLine("Hello, World!");
Dosare sessions = new();
CaiAtac LegalRecourses = new();
Parti LegalParties = new();
Sedinte CourtSessions = new();
LegalRecourses.AddCaleAtac(new("05/11/2021", "SC GROUPAMA ASIGURARI SA", "Apel"));
CourtSessions.AddSedinta(new("1998.02.25", " 10:00", " C18APEL", " Nefondat", " Respinge apelul ca nefondat.Obliga apelanta la plata catre intimata a sumei de 1.190 lei, reprezentand cheltuieli de judecata in apel.Definitiva.Pronuntata prin punerea solutiei la dispozitia partilor prin mijlocirea grefei instantei azi, 25.02.2025.", "Hotarare 1418/2025 25.02.2025"));
CourtSessions.AddSedinta(new(" 2023.06.09 ", "08:30", "Complet amanari pronuntare pt. jud.GOIDESCU N.N.", "Admite in parte cererea", "Respinge exceptia prescriptiei dreptului material la actiune invocata prin intampinare ca neintemeiata.Admite in parte cererea de chemare in judecata formulata de reclamantul NITA AUREL MIRCEA in contradictoriu cu parata GROUPAMA ASIGURARI S.A.Obliga parata la plata catre reclamant a sumei de 5598,12 lei reprezentand despagubiri aferente politei de asigurare nr. 501042692, ca urmare a evenimentului din data de 23.03.2018.Respinge in rest cererea ca neintemeiata.Obliga parata la plata catre reclamant a sumei de 384,9 lei cu titlu de cheltuieli de judecata constand in taxa judiciara de timbru aferenta pretentiilor admise.Cu drept de apel in termen de 30 zile de la comunicare.Apelul si motivele de apel se depun la Judecatoria Sectorului 1 Bucuresti.Pronun?ata prin punerea solu?iei la dispozi?ia par?ilor prin mijlocirea grefei instan?ei, astazi, 09.06.2023.", "Hotarare 5277/2023 09.06.2023"));
sessions.AddDosar(new("27575/299/2022", "Tribunal", "https://portal.just.ro/93/SitePages/Dosar.aspx?id_dosar=9400000000306300&id_inst=93", "14.10.2024", "14.10.2024", "Sectia a-VI-a Civila", "Litigii cu profesionistii", "pretentii", "Apel", LegalRecourses, LegalParties, CourtSessions));

Sedinte CourtSessions1 = new();
CourtSessions1.AddSedinta(new("2021.08.12", "10:30", "", "", "", ""));
CourtSessions1.AddSedinta(new("2025.05.04", "10:30", "", "", "", ""));
sessions.AddDosar(new("27575/299/2021", "judecatorie", "https://portal.just.ro/93/SitePages/Dosar.aspx?id_dosar=9400000000306300&id_inst=290", "14.10.2024", "14.10.2024", "Sectia a-VI-a Civila", "Litigii cu profesionistii", "pretentii", "Apel", LegalRecourses, LegalParties, CourtSessions1));


//Console.WriteLine(sessions.DosarList[0].GetSedinte.MaxDateSession().Year.ToString());
Console.WriteLine(sessions.DosarList[0].GetSedinte.MaxDateSession());
//Console.WriteLine(sessions.DosarList[0].GetSedinte.SedintaList[1].GetSolutiePeScurt);
Console.WriteLine(sessions.GetOrderDosarList()[0].GetSedinte.MaxDateSession());

Console.WriteLine(sessions.GetWorkforToday().Count);
