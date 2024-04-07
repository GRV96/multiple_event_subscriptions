# FRANÇAIS
# Abonnements multiples à un évènement

Cette application console montre la conséquence d'abonner un gestionnaire
(*event handler*) plusieurs fois au même évènement. Elle prend comme argument
le nombre d'abonnements. Une classe détecte les entrées de l'utilisateur et
déclenche un évènement quand elle les reçoit. Le gestionnaire affiche dans la
console la chaîne de caractères entrée.

1. Compilez l'application.

2. Lancez l'exécutable `multiple_event_subscriptions.exe` en ligne de commande
en spécifiant le nombre d'abonnements. Si l'argument est omis ou n'est pas un
nombre entier, le gestionnaire sera abonné une fois.

Exemple:
```
multiple_event_subscriptions.exe 7
```

3. Entrez une chaîne de caractères quelconque à l'invite `> `. Observez le
résultat.

4. Entrez `q` ou `Q` pour arrêter l'application.

Le nombre d'abonnements correspond au nombre de fois que l'entrée de
l'utilisateur apparaît dans la console. Donc, un gestionnaire d'évènement est
exécuté autant de fois qu'il est abonné.

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
