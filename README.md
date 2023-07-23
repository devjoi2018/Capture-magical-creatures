# Project: Capture of Magical Creatures

In this text-based game, the player interacts with the interface by clicking a button to "capture" a random magical creature. Each creature has various characteristics such as name, element, gender, and life stage.

## Inheritance
There is a base "Creature" class that has common attributes and methods such as name, element, gender, and life stage. From the "Creature" class, you can derive more specific classes such as "WaterCreature", "FireCreature", etc., which can have additional unique characteristics or behaviors.

## Polymorphism
Each subclass of "Creature" could have its own implementation of the "Describe" method, which prints the description of the creature. For example, a "WaterCreature" might describe itself as "this magical creature lives in the water and has water-related powers."

## Encapsulation
The attributes of the creatures are private and accessed through getter and setter methods. This allows control over how these attributes are set and gotten, ensuring that, for example, gender can only be "female" or "male", and the life stage can only be "baby", "young", or "old."

## Abstraction
You could have a high-level "CaptureCreature" method that handles the logic of generating a new random creature and displaying its description. This hides the complexity of creature generation from the code that calls this method.

By clicking on the "Capture creature" button, the "CaptureCreature" method is called, a new random creature is generated, and its description is displayed on the interface. Thus, players can continue "capturing" new creatures and discovering their unique features.
