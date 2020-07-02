LoremSharp
===============

A .NET library for all things random!

Usage
---------------

### Text Helpers

```csharp
// this will generate a string with three words:
var words = LoremGen.Words(3);

// this will generate a string with two to five words:
var words = LoremGen.Words(2, 5);

// this will generate a string with five to ten words with "uppercaseFirstLetter" set to "false" and "includePunctuation" set to "true":
var words = LoremGen.Words(5, 10, false, true);

// a sentence is the same as "Words" except that it will include punctuation by default and will include a "." at the end of a string:
var sentence = LoremGen.Sentence(5, 10);

// a paragraph is a string composed of multiple sentences; this paragraph will have five to six words per sentence, and four to ten sentences:
var paragraph = LoremGen.Paragraph(5, 6, 4, 10);

// paragraphs is an array of paragraphs; this method will have eight to nine words per sentence, four to five sentences per paragraph, and one to three paragraphs:
var paragraphs = LoremGen.Paragraphs(8, 9, 4, 5, 1, 3);
```

### Extras

```csharp
// this will generate a random valid email address:
var email = LoremGen.Email();

// this will generate a random hex number (i.e. a color)
var hex = LoremGen.HexNumber();

// this will generate a random DateTime object between 1/1/1950 and the current DateTime:
var dateTime = LoremGen.DateTime();

// this will generate a random DateTime object between 1/1/1995 and 12/31/2020:
var dateTime = LoremGen.DateTime(new DateTime(1995, 1, 1), new DateTime(2020, 12, 31))

// this will return "true" 55% of the time:
var isTruth = LoremGen.Chance(55, 100);

// this will randomly select an item from the group:
var numbers = GetNumbers();
var number = LoremGen.Random(numbers);

// this will randomly select a value from the enum:
var val = LoremGen.Enum<MyEnum>(); 
```

### Updating the Source

If you want to change the underlying source text, go right ahead!

```csharp
public void SomeStartupMethod()
{
    LoremNET.Source.Update("Alright stop collaborate and listen ice is back with my brand new invention something grabs a hold of me tightly flow like a harpoon daily and nightly will it ever stop yo I don't know turn off the lights and I'll glow");

    ...
}
```
