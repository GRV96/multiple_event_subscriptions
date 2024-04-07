# FRAN�AIS
# Abonnements multiples � un �v�nement

Cette application console montre la cons�quence d'abonner un gestionnaire
(*event handler*) plusieurs fois au m�me �v�nement. Elle prend comme argument
le nombre d'abonnements. Une classe d�tecte les entr�es de l'utilisateur et
d�clenche un �v�nement quand elle les re�oit. Le gestionnaire affiche dans la
console la cha�ne de caract�res entr�e.

1. Compilez l'application.

2. Lancez l'ex�cutable `multiple_event_subscriptions.exe` en ligne de commande
en sp�cifiant le nombre d'abonnements. Si l'argument est omis ou n'est pas un
nombre entier, le gestionnaire sera abonn� une fois.

Exemple:
```
multiple_event_subscriptions.exe 7
```

3. Entrez une cha�ne de caract�res quelconque � l'invite `> `. Observez le
r�sultat.

4. Entrez `q` ou `Q` pour arr�ter l'application.

Le nombre d'abonnements correspond au nombre de fois que l'entr�e de
l'utilisateur appara�t dans la console. Donc, un gestionnaire d'�v�nement est
ex�cut� autant de fois qu'il est abonn�.

# ENGLISH
# Multiple Subscriptions to an Event

This console application shows the consequence of subscribing a handler several
times to an event. It takes the number of subscriptions as an argument. A class
detects user input and triggers an event when it receives it. The handler
displays the input in the console.

1. Compile the application.

2. Launch executable `multiple_event_subscriptions.exe` in command line and
specify the number of subscriptions. If the argument is omitted or is not an
integral number, the handler will be subscribed once.

Example:
```
multiple_event_subscriptions.exe 7
```

3. Enter a random string of characters at the prompt `> `. Observe the
result.

4. Enter `q` or `Q` to quit the application.

The number of subscriptions corresponds to the number of times that the user
input appears in the console. Therefore, an event handler is executed as many
times as it is subscribed.
