# Obstacle Course

### Spis treści
1. [Założenia i opis gry](#założenia-i-opis-gry)  
2. [Charakterystyka rozgrywki](#charakterystyka-rozgrywki)  
3. [Elementy wchodzące w skład projektu](#elementy-wchodzące-w-skład-projektu)  

---

## Założenia i opis gry
Gra jest wyścigówką arcade, w której gracz prowadzi samochód po torze pełnym przeszkód.  
Zadaniem gracza jest unikanie kolizji przy rosnącej prędkości. Z każdą sekundą rośnie zarówno wynik, jak i prędkość auta, co podnosi poziom trudności rozgrywki.

---

## Charakterystyka rozgrywki
- **Sterowanie**:  
  - Gra zaprojektowana z myślą o urządzeniach mobilnych.  
  - Kliknięcie w lewą lub prawą stronę ekranu powoduje skręt w danym kierunku.  

- **Cel**:  
  - Przetrwać jak najdłużej na torze, omijając przeszkody przy stale rosnącej prędkości.  

- **Punktacja**:  
  - Punkty przyznawane za każdą sekundę przetrwania.  
  - Im dłużej jedziesz, tym wyższy wynik.  

- **Poziom trudności**:  
  - Z każdą sekundą prędkość samochodu wzrasta, co wymaga coraz szybszego refleksu i lepszej koordynacji.

---

## Elementy wchodzące w skład projektu
### Projekt Unity
- Cały projekt stworzony w silniku **Unity**.  

### Scena główna
- Zawiera tor wyścigowy, przeszkody oraz pojazd gracza.  
- Na tej scenie rozgrywa się właściwa gra.

### Assety z Unity Store
- **Model samochodu**
- **Przeszkody**:  
  - Modele, które służą jako elementy utrudniające przejazd (np. bariery, pachołki).  
- **Otoczenie**:  
  - Modele i tekstury toru wyścigowego oraz krajobrazu wokół niego.

### UI
- **Interfejs**:  
  - Wyświetlanie aktualnej punktacji w czasie rzeczywistym.  
- **Ekran startowy**:  
  - Możliwość rozpoczęcia gry i podgląd najwyższego wyniku.
