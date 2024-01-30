# Lern-Periode 3

Fynn Huber

9.1.2024 bis 30.1.2024 (☃️ Sportferien)

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
   Ich allen bisherigen Modulen bin ich mit meiner Leistung zufrieden. Jedoch könnte ich mehr Fokus auf M164 und M117 legen da diese gerade aktuell sind,
   da diese aber nicht viel mit Coden an sich zu tuhen haben, und ich scho gerne etwas Programmieren würde,
    weis ich nicht ob ich meinen Fokus auf diese Module lege.
   
2. Was hatten Sie sich am Ende von LP2 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?
   Am Ende der LP2 habe ich mir vorgenommen ein Game zu Coden. Ich würde dies gerne umsetzen in Form eines Unity Projektes,
    bin mir aber Zeitlich nicht sicher ob diese ausreicht, weshalb ich mich für etwas anderes entscheide.
   
3. Was wäre ein geeignetes Projekt würd diese LP3?
  Reaktionszeitspiel mit mehreren Schwierigkeitsgraden
## 9.1.2024

✍️ Heute habe ich... (50-100 Wörter)

## 16.1 und 23.1.2024

- [ x ] Startmenu
- [x ] Schwierigkeitsgrad auswahl
- [x ] Einzelne Schwierigkeiten deffinieren
- [x ] nochmal spielen möglich

| estfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| -------------- | -------------------- | -------------- | -------------- | -------- |
|  Startmenü             |Konsole                     |  Start = y              |    Game startet            |     x     |
|  Schwierigkeit auswahl        |     Konsole                 |     1,2,3,4           |      leicht oder Schwer          |     x     |
|schwierigkeit deffinieren        |       Schwierigkeit ausgewählt             |    When schwierigkeit 2          |  Zeit zu ragieren = 0.5 Sek             |     x     |
|Nochmal spielen            | Run beendet     |  Nochmal spielen = y       |     Game startet |      |

✍️ Heute am 16.1 habe ich... (50-100 Wörter)
Anfangendas das Spiel zu progammieren und gemerkt, dass es einfacher als gedacht ist. Die Grundidee des Spielsch steht schon einigermassen, jedoh bin ich mit dem Design und den Details des Spiels noch nicht zufrieden. beim nächsten mal möchte ich probieren wie man in der Konsole ein schönens Gameoverlay machen kann damit es auch spass macht zu Spielen. Ausserdem ibt es noch ein Problem mit dem Code, den ich auch noch beheben muss.

☝️ Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 23.1.2024

- [x ] erneute Schwierigkeitsauswahl
- [ x] Reaktionszeit Messen
- [ x] Overlay erstellen im Game 
- [ ] Personel best Score

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| erneute Schwierigkeitsauswahl               |Game erneut spielen                  |         Schwierigkeit = 4       | neue Schwierigkeit = 4            |     x     |
| Reaktionszeit Messen        | Run vorbei                |  Zeitspanne Zeichen bis Tastendruck              | Reaktionszeit            |    x      |
| Overlay              | Game gestartet                 |  Zeichen das man drücken muss          |   Drücken Erfolgrecih / Unerfolgreich            |    x      |
|Personal best | Run vorbei |Reaktion kleiner als vorher | new PB | |

✍️ Heute am 23.1 habe ich... (50-100 Wörter)
Ich habe die komplette Funktionallität meines Codes fertiggestellt und bin Zufrieden mit der Umsetzung meiner Idee. Ich hatte afangs Probleme mit dem Neustarten und erneuter Schwierigkeitsauswahl des Spieles, damit es die neue Schwierigkeit annimmt. Ausserdem War es schwierig die Zeit auf die Millisekunde genau zu stoppen das auch das Endresultat stimmt. Doch dies konnte ich ganz einfach beheben indem ich früh genug eine stopwatch.stop() gemacht habe.
Leider habe ich nicht mehr geschafft einen PB-score zu erstellen, es währe einfach gewesen ein PB score für die einzelnen Spiel-Sessions zu machen, ich wollte jedoch einen PB der irgendwo gespeichert wird und bei erneutem Spielstart immernoch aufrufbar wäre. 

☝️ Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 30.1.2024

✍️ Heute am 30.1 habe ich... (50-100 Wörter)

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).

Verfassen Sie zusätzlich einen kurzen Abschnitt, in welchem Sie über die Länge der Projekte reflektieren: Fanden Sie die 9-wöchtige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für Ihre Planung der zukünftigen LP?
