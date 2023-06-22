# 09-3DSceneURP-NSaxx

### Beschreibung:
3D-Szene für ein gemeinsames Schulprojekt. Mini Game in dem man beim kochen so wenig strom wie möglich brauchen soll.

### Enwicklungsplattform: 
+ Windows 10; 
+ Visual studio 2019, 
+ Unit 2020.3.18f1

### Lessons Learned:
Tiefere einblick in Unity und C# 
Hauptsächlich Text in 3D Raum platzieren, Array und CoRoutinen

### Limitations:
Noch kein Unity Profie :< also brenötigte viel Hilfe und konnte manch Dinge nicht umsetzten wie Ei

### Message:
Es ist von zentraler Bedeutung, dass wir alle unsere Verantwortung für den Energieverbrauch ernst nehmen. Die Ressourcen unserer Erde sind begrenzt und jedes Kilowatt, das wir verbrauchen, hinterlässt seinen Fußabdruck auf unserem Planeten. Daher versucht dieses Spiel zu sagen: Seien Sie wachsam hinsichtlich Ihres Stromverbrauchs und bemühen Sie sich, energieeffizient zu leben.

### Expirience:
In diesem Szenario findet man sich in einer Küche wieder, in welcher man dazu aufgefordert wird, eine Mahlzeit zuzubereiten. Es erfordert ein hohes Maß an Geschick und Timing, da jeder Kochvorgang ständige Aufmerksamkeit verlangt. Der Erfolg wird durch die Geschwindigkeit und Effizienz bestimmt, mit der man agiert, da das Ziel darin besteht, einen möglichst niedrigen Gesamtscore zu erzielen. Der ultimative Triumph liegt darin, das gesamte Essen präzise auf dem Teller anzurichten und somit die Herausforderung zu meistern.

### Ablauf: 
Start in Scene namens Küche in der man bis zum ende des Spiel verweilt. Man bereitet an 3 Stationen Essen zu die sich um den Player herum befinden. 
+ Station 1: Blender Spieler gibt die Orange in den Blender und drückt in VR den knopf am Blender um zu Blenden. Kurz darauf Beginnen Orangensäfte zu Spawnen diese Spawnen Endloss bis der Blender mit einem Weiteren Klick ausgeschalten wurde
+ Station 2: Pan Spieler gibt den Schinken in die Pfanne uns startet sie mit knopfdruck an der Pfanne. Der Schinken wird zuerst braun später aber Schwarz je nachdem wie lange man ihn kocht, Ausschalten über erneuten knopfdruch an der pfanne.
+ Station 3: Toaster Spiler gibt brotscheiben in den Toaster nachdem betätigt er den mechanismus und nach kurzem wird der Toast vom Toaster augespuckt.
Nachdem all das Essen gekocht wurde wird nun die Mahlzeit auf dem Teller zusammengestellt. Nachdem das letzte fertige Sssen auf dem Teller ist hat man gewonnen, dein Scor wird präsentiert und kann zurück in die Lobby.

### Steuerung:
Player Controlls:
+ W - Player geht nach vorne
+ S - Player geht nach hinten
+ A - Player geht nach links
+ D - Player geht nach rechts
Blender Controlls:
+ Q - Start Blending
+ E - Stop Blending
Pan Controlls:
+ P - Start Cooking
+ O -Stop Cooking
Toaster Controlls:
+ T - Start Toasting
Sonstige Controlls:
+ V - Rückkehr zur Lobby

### Sounds:
+ Blenderloop - Soundeffekt für Blender wenn er läuft
+ Button Press - fürKnöpfe an Blender un Pan
+ Eggcrack - nicht benutzt
+ Pan fry - für pfanne wenn sie läuft
+ ToasterStart - für wenn Toast in den Toaster geht
+ ToasterEnd - Wenn Toaste fertig ist
+ Winsound - wenn man gewinnt

### 4 gewählte Syntax
+ if/else - Plater 78
+ Methodendeklaration - Pan 22
+ IEnumerator - Mixer 69
+ Array - MissionUpdate 30

