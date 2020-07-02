# LoremSharp

A fork of Lorem.NET with some changes to the API. It targets both .NET Standard 2.0 and .NET Framework 4.0.


## Usage

### Text Helpers

```csharp
// this will generate a string with three words:
var words = Lorem.Words(3);

// this will generate a string with two to five words:
var words = Lorem.Words(2, 5);

// this will generate a string with five to ten words with "uppercaseFirstLetter" set to "false" and "includePunctuation" set to "true":
var words = Lorem.Words(5, 10, false, true);

// a sentence is the same as "Words" except that it will include punctuation by default and will include a "." at the end of a string:
var sentence = Lorem.Sentence(5, 10);

// a paragraph is a string composed of multiple sentences; this paragraph will have five to six words per sentence, and four to ten sentences:
var paragraph = Lorem.Paragraph(5, 6, 4, 10);

// paragraphs is an array of paragraphs; this method will have eight to nine words per sentence, four to five sentences per paragraph, and one to three paragraphs:
var paragraphs = Lorem.Paragraphs(8, 9, 4, 5, 1, 3);
```

### Extras

```csharp
// this will generate a random valid email address:
var email = Lorem.Email();

// this will generate a random hex number (i.e. a color)
var hex = Lorem.HexNumber();

// this will generate a random DateTime object between 1/1/1950 and the current DateTime:
var dateTime = Lorem.DateTime();

// this will generate a random DateTime object between 1/1/1995 and 12/31/2020:
var dateTime = Lorem.DateTime(new DateTime(1995, 1, 1), new DateTime(2020, 12, 31))

// this will return "true" 55% of the time:
var isTruth = Lorem.Chance(55, 100);

// this will randomly select an item from the group:
var numbers = GetNumbers();
var number = Lorem.Random(numbers);

// this will randomly select a value from the enum:
var val = Lorem.Enum<MyEnum>();
```

### Updating the Source

If you want to change the underlying source text, go right ahead!

```csharp
public void SomeStartupMethod()
{
    Source.Update("Alright stop collaborate and listen ice is back with my brand new invention something grabs a hold of me tightly flow like a harpoon daily and nightly will it ever stop yo I don't know turn off the lights and I'll glow");

    ...
}
```
