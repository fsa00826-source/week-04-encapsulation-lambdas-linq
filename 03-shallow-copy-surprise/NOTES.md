# Notater

- TODO: Hva skjer med selve listen?
 
 * Med Selve listen så vil ikke RemoveAt eller andre ting som GetDrones() returnener ikke påvirke vaultens interne liste. 

- TODO: Hva skjer med objektene i listen?

* List<Drone> copy valt.GetDrones(); er bare en tom kopi, og begge listene inneholder de samme Drone-referansene.