# DAB_Project (Distributeur Automatique de Billets)

## Auteurs

- Pellizzari Théo, Kanari Mark, Mourot Axel, Jeanney Jonathan

## Description
Ce projet consiste en la création d'un Distributeur Automatique de Billets (DAB) en utilisant les concepts de la Programmation Orientée Objet (POO) avec le langage C#. Il permet à un utilisateur d'effectuer des actions telles que l'insertion d'une carte, la vérification du solde, le retrait d'argent, et l'impression d'un reçu.

## Fonctionnalités

- **Vérification du code PIN** : Un client peut insérer une carte et un code PIN. Si le code est valide, il accède aux autres fonctionnalités.
- **Consultation du solde** : L'utilisateur peut vérifier le solde actuel du compte.
- **Retrait d'argent** : Le DAB permet de retirer un montant spécifique, dans les limites du solde disponible et de la limite de retrait.
- **Impression de reçu** : Après chaque transaction, un reçu est imprimé avec les détails de l'opération et le solde restant.

## Prérequis

- [Dotnet SDK](https://dotnet.microsoft.com/download) (version 6.0 ou plus récente)
- Un IDE tel que [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

## Installation

1. Clonez le dépôt Git localement :
   ```bash
   git clone https://github.com/pellizza1u/DAB_Project.git
   ```

2. Accédez au répertoire du projet :
   ```bash
   cd DAB_Project
   ```

3. Restaurez les dépendances :
   ```bash
   dotnet restore
   ```

4. Compilez le projet :
   ```bash
   dotnet build
   ```

## Utilisation

Pour exécuter le programme, utilisez la commande suivante :
```bash
dotnet run
```

Une fois exécuté, le programme vous demandera d'insérer un code PIN, puis vous proposera les options de consulter le solde ou de retirer de l'argent.

## Tests

Pour exécuter les tests unitaires, utilisez la commande suivante :
```bash
dotnet test
```

Les tests couvrent :
- Vérification du code PIN.
- Retrait d'argent avec solde suffisant.
- Consultation du solde après chaque opération.
