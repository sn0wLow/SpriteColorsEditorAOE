# SpriteColorsEditorAOE

A simple sprite colors editor for Age of Empires II: Definitive Edition
Import a spritecolors.json file (spritecolors_deuteranopia, spritecolors_protanopia, etc. work too)
Change the Outline and Player Color for each Player (Gaia, Player 1, Player 2, etc.)

example spritecolors.json

```json
{
    "TeamColors": {
        "Gaia": { "FloatRGBA": { "r": 1, "g": 1, "b": 1, "a": 1 } }, 
        "Player 1": { "FloatRGBA": { "r": 0, "g": 0.47058824, "b": 1, "a": 1 } }, 
        "Player 2": { "FloatRGBA": { "r": 1, "g": 0.19215687, "b": 0.28627452, "a": 1 } }, 
        "Player 3": { "FloatRGBA": { "r": 0.6313726, "g": 1, "b": 0.15294118, "a": 1 } }, 
        "Player 4": { "FloatRGBA": { "r": 0.88235295, "g": 0.7882353, "b": 0, "a": 1 } }, 
        "Player 8": { "FloatRGBA": { "r": 1, "g": 0.42352942, "b": 0, "a": 1 } }, 
        "Player 5": { "FloatRGBA": { "r": 0, "g": 1, "b": 1, "a": 1 } }, 
        "Player 6": { "FloatRGBA": { "r": 1, "g": 0, "b": 1, "a": 1 } }, 
        "Player 7": { "FloatRGBA": { "r": 0.12941177, "g": 0.12941177, "b": 0.12941177, "a": 1 } }
    }, 
    "OutlineColors": {
        "Gaia": { "FloatRGBA": { "r": 1, "g": 1, "b": 1, "a": 1 } }, 
        "Player 1": { "FloatRGBA": { "r": 0, "g": 0.44313726, "b": 0.9372549, "a": 1 } }, 
        "Player 2": { "FloatRGBA": { "r": 0.9372549, "g": 0.18039216, "b": 0.26666668, "a": 1 } }, 
        "Player 3": { "FloatRGBA": { "r": 0.5921569, "g": 0.9372549, "b": 0.14509805, "a": 1 } }, 
        "Player 4": { "FloatRGBA": { "r": 0.827451, "g": 0.7372549, "b": 0, "a": 1 } }, 
        "Player 8": { "FloatRGBA": { "r": 0.9372549, "g": 0.39607844, "b": 0, "a": 1 } }, 
        "Player 5": { "FloatRGBA": { "r": 0, "g": 0.9372549, "b": 0.9372549, "a": 1 } }, 
        "Player 6": { "FloatRGBA": { "r": 0.9372549, "g": 0, "b": 0.9372549, "a": 1 } }, 
        "Player 7": { "FloatRGBA": { "r": 0.12156863, "g": 0.12156863, "b": 0.12156863, "a": 1 } }
    }
}
```

tested for Update 108769
