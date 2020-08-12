# Trophies

Trophies are awarded to players based on actions taken during a game, such as playing certain types of cards.

## Trophy object format

A trophy object consists of several components. Below is some example JSON showing how they are structured:

```json
{
    // Internal ID string for trophy
    "id": "trophy_example",

    // Display name for trophy
    "name": {
        "en-US": "Fun pesron"
    },

    // Description displayed next to trophy
    "desc": {
        "en-US": "20% or more cards played feature fun activities."
    },

    // Requirements for getting trophy
    "requirements": [
        {
            "type": "card_proportion",
            "flags": ["xf"],
            "winning": false,
            "percent": 20
        }
    ]
}
```

## Trophy requirements

Requirements define the conditions that must be met in order for a player to earn a specific trophy. If multiple requirements are listed, all must be met.

### Any

Type name: `any`

Requires that one or more of the specified requirements be met.

```json
{
    "type": "any",
    "requirements": [
        { 
            /* ... */
        },
        { 
            /* ... */
        }
    ]
}
```

### All

Type name: `all`

Requires that all of the specified requirements be met.

```json
{
    "type": "all",
    "requirements": [
        { 
            /* ... */
        },
        { 
            /* ... */
        }
    ]
}
```

### Cards Played

Type name: `cards_played`

Requires that all of the listed cards have been played.

```json
{
    "type": "cards_played",
    "cards": ["w_example1", "w_example2"],
    "single_play": false, // Do they need to be in the same play?
    "winning": false, // Require that played cards have won round(s)
}
```

### Card Proportion

Type name: `card_proportion`

Requires a certain percentage of played cards to match at least one of the specified content flag strings.

```json
{
    "type": "card_proportion",

    // Flag filters. Contents must include at least one of the array items.
    "flags": ["bc", "d"], // Cards with either bad coding or about developers

    "winning": false, // Specifies whether cards must have won a round

    "maximum": false, // (optional) Filter by maximum proportion instead of minimum

    // Minimum percentage of cards to be met
    "percent": 20
}
```

### Win Proportion

Type name: `win_proportion`

Requires that the user win a certain proportion of the rounds in a game.

```json
{
    "type": "win_proportion",
    "percent": 50,
    "inclusive": true, // (optional) Inclusive comparison (e.g. at 50%, or above 50%?)
    "maximum": // (optional) Filter by maximum proportion instead of minimum
}
```

## Card contents

Standard content flags are defined below for use by all packs.
Additional flags not on this list may also be used (e.g. for implementing a special trophy type).

|Flag|Description|
|:--:|-----------|
|`an`|Animals.|
|`ce`|Celebrities.|
|`fc`|Fictional characters.|
|`i`|Injury.|
|`in`|Insects.|

