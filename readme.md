# Lern-Periode 3

Fynn Huber

9.1.2024 bis 30.1.2024 (☃️ Sportferien)

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
   
   In allen bisherigen Modulen bin ich mit meiner Leistung zufrieden. Jedoch könnte ich mehr Fokus auf M164 und M117 legen, da diese gerade aktuell sind.
   Diese Modula haben aber nicht viel mit Coden an sich zu tun, und da ich gerne etwas Programmieren möchte,
   weis ich nicht, ob ich meinen Fokus auf diese Module legen sollte.
   
   
3. Was hatten Sie sich am Ende von LP2 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?
   
   Am Ende der LP2 habe ich mir vorgenommen ein Game zu Coden. Ich würde dies gerne umsetzen in Form eines Unity Projektes,
   bin mir aber zeitlich nicht sicher, ob diese ausreicht, weshalb ich mich für etwas anderes entscheide.
   
5. Was wäre ein geeignetes Projekt würd diese LP3?
   
   Reaktionszeitspiel mit mehreren Schwierigkeitsgraden. Mit dem Ziel, wenn die Aufforderung kommt, die Leertaste zu drücken, und man diese drückt, dass dann die Reaktionszeit    gemessen wird.


   
## 9.1.2024

✍️ Heute habe ich...

Die Planung für mein Reaktionszeitspiel erstellt und die einzelnen Anforderungen definiert.



## 16.1 und 23.1.2024

- [x] Startmenu
- [x] Schwierigkeitsgrad auswahl
- [x] Einzelne Schwierigkeiten definieren
- [x] nochmal spielen möglich

| estfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| -------------- | -------------------- | -------------- | -------------- | -------- |
|  Startmenü             |Konsole                     |  Start = y              |    Game startet            |     x     |
|  Schwierigkeit Auswahl       |     Konsole                 |     1,2,3,4           |      leicht bis Schwer          |     x     |
|Schwierigkeit definieren        |       Schwierigkeit ausgewählt             |    Wenn schwierigkeit = 2          |  Zeit zu ragieren = 0.5 Sek             |     x     |
|Nochmal spielen            | Run beendet     |  Nochmal spielen = y       |     Game startet |      |

✍️ Heute am 16.1 habe ich...

Ich habe angefangen, das Spiel zu programmieren und bemerkt, dass es einfacher ist als gedacht. Die Grundfunktion des Spieles steht schon einigermassen, jedoch bin ich mit dem Design und den Details des Spieles noch nicht zufrieden. Beim nächsten Mal möchte ich probieren, wie man in der Konsole ein schönes Gameoverlay machen kann, damit das Spiel auch Spass macht zu Spielen. Ausserdem gibt es noch ein Problem mit dem Code, das ich auch noch beheben muss.



## 23.1.2024

- [x] erneute Schwierigkeitsauswahl
- [x] Reaktionszeit Messen
- [x] Overlay erstellen im Game 
- [ ] Personel best Score

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| erneute Schwierigkeitsauswahl               |Game erneut spielen                  |         Schwierigkeit = 4       | neue Schwierigkeit = 4            |     x     |
| Reaktionszeit Messen        | Run vorbei                |  Zeitspanne Zeichen bis Tastendruck              | Reaktionszeit            |    x      |
| Overlay              | Game gestartet                 |  Zeichen dass man drücken muss          |   Drücken Erfolgreich / nicht Erfolgreich            |    x      |
|Personal best | Run vorbei |Reaktion kleiner als vorher | new PB | |

✍️ Heute am 23.1 habe ich...

Ich habe die komplette Funktionalität meines Codes fertiggestellt und bin zufrieden mit der Umsetzung meiner Idee. Ich hatte anfangs Probleme mit dem Neustarten und erneuter Schwierigkeitsauswahl des Spieles, damit es die neue Schwierigkeit annimmt. Ausserdem war es schwierig, die Zeit auf die Millisekunde genau zu stoppen, dass auch das Endresultat stimmt. Doch dies konnte ich ganz einfach beheben, indem ich früh genug eine stopwatch.stop() gemacht habe.
Leider habe ich nicht mehr geschafft, einen PB Score zu erstellen. Es wäre einfach gewesen ein PB Score für die einzelnen Spiel-Sessions zu machen, ich wollte jedoch einen PB Score der gespeichert wird und bei erneutem Spielstart immer noch aufrufbar wäre.



## 30.1.2024

✍️ Heute am 30.1 habe ich...

Ich habe meinen Code verschönert und mit richtig definierten Variabelnamen ausgestattet damit er besser leserlich ist. Ausserdem habe ich das Programm nochmal getestet um sicher zu gehen das ich keine Fehler mehr habe. Anschliessend habe ich den fertigen Code auf GitHub hochgeladen.

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).

Beim Ideensuchen für ein Projekt wussete ich schon das ich eine Art Game Coden will. Da wir aber nicht so viel Zeit hatten habe ich mich für etwas simpleres entschieden dass ich am Schluss auch sicher fertig werde. Ich habe mich dann für ein Reaktionszeitspiel entschieden und die Anforderungen dafür definiert. Als ich begann zu Coden habe war alles sehr einfach bis auf die Thematik mit dem Zeit stoppen damit ich auch die Reaktionszeit angegeben  kann. Durch Googeln und viel rumprobieren habe ichs dann geschafft das die Zeit die ausgegeben wird auch wirklich auf die Millisekunde stimmt. Anschlissend habe ich noch daran gearbeitet dass das Game erneut gespielt werden kann und dass man auch immer wieder die Schwierigkeit erneut auswählen kann. Am Schluss habe ich den Code nochmal überarbeiter mit neuen Variabeln und schönerer Formatierung.

Verfassen Sie zusätzlich einen kurzen Abschnitt, in welchem Sie über die Länge der Projekte reflektieren: Fanden Sie die 9-wöchtige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für Ihre Planung der zukünftigen LP?

Ich fand es sehr angenehm nur 4 Wochen Zeit zu haben da man sich dadurch nicht so ein grosses Projekt vorgenommen hat und somit auch nicht so in den Stress geraten ist. In den 9 Wöchigen LP's konnte ich  die Zeit nie gut einschätzen und fand es schwieriger zu Planen. Trotzdem hat eine Längere LP auch vorteile da man auch andere Sachen angehen kann als nur an seinem Projekt Coden. In der 9 Wöchigen LP hatte ich z.B auch noch viel Zeit an anderen Modulen zu arbeiten was eine grosser Vorteil war, den ich bei dieser LP nicht hatte.
