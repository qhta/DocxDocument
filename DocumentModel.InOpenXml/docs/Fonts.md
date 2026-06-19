Fonts, that are used in the OpenXml document, are stored in the **FontTablePart** part. 
Content of the **FontTablePart** part is represented by the **FontTable** class. 
Each font is represented by the **Font** class. 
The **Font** class has a property called **Typeface**, which contains the name of the font,
and is used to identify the font in the document.

The current font used in the document is determined by the **RunProperties** of the text, 
specially by **RunFonts** element, which specifies font names for different scripts.

# Font class

The **Font** class has several properties that are used to identify the font and determine its similarity to other fonts.
- **Typeface** - the base name of the font, which is used to identify the font in the document.
- **Aliases** - the list of alternative names for the font.
- **Panose** - the Panose classification of the font.
- **Charset** - the character set of the font.
- **FontFamily** - the font family of the font.
- **Pitch** - the pitch of the font.
- **FontSignature** - the font signature of the font.
- **NotTrueType** - indicates whether the font is not a TrueType font.

**Name** property of the **Font** class is the same as existing font name in the operating system.
It is usually the full name of the font, which is included in font file metadata.
For instance, the **Name** property of the font stored in operating system in "TIMES.TTF" 
is "Times New Roman".

A single font can represent multiple font types. 
For instance, "Times New Roman" represents four font types: regular, **bold**, _italic_, and **_bold italic_**.
The specific font type is determined by the **RunProperties** of the text.

Sometimes, the **Font** class can have some alternative names for the font, which are stored in the **Aliases** property.
For instance, the "Times New Roman" font can have an alternative names "Times Roman" or simply "Times". 
A font can have multiple aliases, in this case, the **Aliases** property will contain a list of alternative names 
separated by commas, such as "Times Roman, Times".

If the font name and aliases are not sufficient to identify the font, the **Panose** classification can be used.
A **Panose** is a 10-digit compound number that describes the visual characteristics of a font, including:
- **Family Kind**: Text, script, decorative, etc.
- **Serif Style**: Cove, obtuse cove, square, bone, etc.
- **Weight**: Very light, book, bold, black, etc.
- **Proportion**: Old style, modern, condensed, expanded, etc.
- **Contrast**: No variation, horizontal, vertical, etc.
- **Stroke Variation**: Gradual, no transition, etc.
- **Arm Style**: Straight, bent, horizontal, etc.
- **Letterform**: Normal, round, uncial, etc.
- **Midline**: Standard, low, high, etc.
- **X-height**: Constant, ducking, standard, etc.

In the **Font** class, the **Panose** property has the type of 10-byte **HexBinary** value.

The **Charset** property of the **Font** class is a byte value that indicates the character set of the font.
A character set dictates linking of digital character codes to visual characters. 
Most character sets in use are supersets of the U.S. ASCII character set, 
which defines characters for the 96 numeric values from 32 through 127.
However, some fonts, such as "Symbol" and "Wingdings", use the Symbol character set, which is a non-standard character set.
In the Symbol font, the characters visualize the mathematical symbols, and Greek letters.
In Wingdings font, the characters visualize various symbols, such as arrows, stars, etc.
The **Charset** property of the **Font** class encodes 256 character sets, including:
- 0 - **ANSI** - the default character set for Western languages, which includes characters for English, French, German, etc.
- 1 - **Default** - the default character set for the operating system, which is determined by the system locale.
- 2 - **Symbol** - used by symbolic fonts like "Symbol" and "Wingdings",
- 4Dh - **Macintosh** - standard character set for Macintosh operating system, which includes characters for Western languages.
- 80h - **ShiftJIS** - used for Japanese characters.
- 81h - **Hangul** - used for Korean characters.
- 82h - **Johab** - used for Korean characters.
- 86h - **GB2312** - used for simplified Chinese characters.
- 88h - **Big5** - used for traditional Chinese characters.
- A1h - **Greek** - used for Greek characters
- A2h - **Turkish** - used for Turkish characters.
- A3h - **Vietnamese** - used for Vietnamese characters.
- B1h - **Hebrew** - used for Hebrew characters.
- B2h - **Arabic** - used for Arabic characters.
- BAh - **Baltic** - used for Baltic languages characters.
- CCh - **Russian** - used for Cyrillic characters.
- DEh - **Thai** - used for Thai characters.
- EEh - **East European** - used for Eastern European languages characters.
- FFh - **OEM** - used for OEM character sets, which are specific to the operating system and locale.

The **FontFamily** property of the **Font** class is an enum value that indicates one of the following font families:
- **Auto** - the font family is automatically determined by the operating system based on the font name and other properties.
- **Roman** - the font is a Roman font, which is a serif font that has small lines or strokes at the ends of the characters.
- **Swiss** - the font is a Swiss font, which is a sans-serif font that does not have small lines or strokes at the ends of the characters.
- **Modern** - the font is a modern font, which is a serif font that has thin, straight lines and minimal contrast between thick and thin strokes.
- **Script** - the font is a script font, which is a font that mimics handwriting and has flowing, cursive characters.
- **Decorative** - the font is a decorative font, which is a font that has unique and artistic characters that do not fit into the other categories.

The **Pitch** property of the **Font** class is an enum value that indicates one of the following pitch types:
- **Auto** - the pitch is automatically determined by the operating system based on the font name and other properties.
- **Fixed** - the font is a fixed-pitch font, which means that all characters have the same width.
- **Variable** - the font is a variable-pitch font, which means that characters have different widths.

The **FontSignature** property of the **Font** class is a HexBinary value that uses six 32-bit integers
indication the Unicode subsets and the code page bit-fields of the font. 
The bit fields are the following:
- **UnicodeSignature0** - the lowest 32-bit indicate the Unicode subsets supported by the font.
- **UnicodeSignature1** - the second 32-bit indicate the Unicode subsets supported by the font.
- **UnicodeSignature2** - the third 32-bit indicate the Unicode subsets supported by the font.
- **UnicodeSignature3** - the highest 32-bit indicate the Unicode subsets supported by the font.
- **CodePageSignature0** - lower 32-bit indicate the code pages supported by the font.
- **CodePageSignature1** - upper 32-bit indicate the code pages supported by the font.

The **NotTrueType** indicates whether the font is not a TrueType font.

## Font subsitution

If the font specified in the document is not available in the operating system, 
application can substitute it with a similar font that is available on the system
using the above font properties, such as aliases, Panose classification, character set, font family, pitch, and font signature.

## Font embedding

The OpenXml document can contain embedded fonts, which are stored in the **EmbeddedFontPart** part.
The **Font** class has four properties containing the references to the embedded fonts:
- **EmbedRegularFont**, which contains the reference to the embedded regular font part.
- **EmbedBoldFont**, which contains the reference to the embedded bold font part.
- **EmbedItalicFont**, which contains the reference to the embedded italic font part.
- **EmbedBoldItalicFont**, which contains the reference to the embedded bold italic font part.

Each of these properties is of the type **EmbedFont**, and contains the reference to the embedded font part. 
The **EmbedFont** class has the following properties:
- **Id** - the unique identifier of the embedded font part (as a string).
- **FontKey** - the Guid value that is used to obfuscate the font data in the embedded font part.
- **Subsetted** - indicates whether the embedded font is subsetted, which means that only used characters from the font are included in the embedded font part, instead of the entire font.
- **FontData** - the binary data of the embedded font, which is stored in the embedded font part.

### Font data obfuscation

The **FontKey** property is used to obfuscate the font data in the embedded font part. 
The obfuscation process involves XORing the first 32 bytes of the font data with bytes derived from the **FontKey** (in reversed order).
This ensures that the font data is not easily readable, providing a layer of protection for the embedded font.

Font data is deobfuscated when the font is loaded from the embedded font part in OpenXml document to the **EmbedFont** instance, 
and obfuscated when the font is saved to the embedded font part.

# FontScheme class

In addition to referencing individual fonts, the OpenXml document can also reference font schemes, 
which are collections of font references for different usage scenarios.
The font scheme is used in drawing elements, such as charts and diagrams, 
but also in the main part of the document in the text elements, such as paragraphs and runs.

The font scheme is stored in the **FontSchemePart** part, and is represented by the **FontScheme** class.
The **FontScheme** class represents a font scheme, 
which is a collection of font references divided into major and minor font types. 
Major font types are used for headings and titles, 
while minor font types are used for body text and other content.

Both **MajorFont** and **MinorFont** classes derive from **SchemeFont** class,
which have the following properties:
- **LatinFont** - the font identification for Latin script.
- **EastAsianFont** - the font identification for East Asian script.
- **ComplexScriptFont** - the font identification for complex script, such as Arabic or Hebrew.
- **SupplementalFonts** - the collection of supplemental font references for additional language and script support.

The **LatinFont**, **EastAsianFont**, and **ComplexScriptFont** properties 
have the same type of **TextFontType**, which is a simpler version of the **Font** class.
It contains only:
- **Typeface** property, which is the name of the font.
- **Charset** property, which is a byte value that indicates the character set of the font.
- **Panose** property, which is a 10-byte HexBinary value that describes the visual characteristics of the font.
- **Pitch** property, which is an enum value that indicates the pitch of the font (auto, fixed, variable).

The **SupplementalFonts** property is a collection of **SupplementalFont** instances, 
which represent additional font references for specific scripts. 
Each **SupplementalFont** instance has only two properties:
- **Script** - the script identifier for the supplemental font, such as "Jpan" for Japanese, "Hans" for simplified Chinese, etc.
- **Typeface** - the name of the font typeface.

# Referencing fonts in the document

Fonts are referenced in the document in the following classes:
- **DocumentModel.Wordprocessing.RunFonts** - specifies the font names for different scripts in the run properties of the text.
- **DocumentModel.Drawings.FontReference** - specifies the font reference for a text element in shapes and other drawing elements.
- **DocumentModel.Math.MathProperties** - specifies the font reference for elements of mathematical equations, such as a math run or a math paragraph.

## RunFonts class

The **RunFonts** class has the following properties for specifying fonts for different scripts:
- **Ascii** - the font name for Latin script.
- **HighAnsi** - the font name for high ANSI characters (a superset of Latin script).
- **EastAsia** - the font name for East Asian characters.
- **ComplexScript** - the font name for complex script characters.
- **AsciiTheme** - a theme index of a font used for Latin script,
- **HighAnsiTheme** - a theme index of a font used for high ANSI characters,
- **EastAsiaTheme** - a theme index of a font used for East Asian characters,
- **ComplexScriptTheme** - a theme index of a font used for complex script characters,
- **Hint** - a hint for font substitution, which can be used to specify the preferred font type (using the special algorithm described below).

The **Ascii**, **HighAnsi**, **EastAsia**, and **ComplexScript** properties of the **RunFonts** class
are simply strings that identify the font by the name in the document.

The **AsciiTheme**, **HighAnsiTheme**, **EastAsiaTheme**, and **ComplexScriptTheme** properties 
are enums that specify the theme index of the font used for different scripts. 
The **ThemeFont** enum type has the following values:
- **MajorAscii** - refers to the major Ascii font in font scheme.
- **MajorHighAnsi** - refers to the major font for high ANSI characters in font scheme.
- **MajorEastAsia** - refers to the major font for East Asian characters in font scheme.
- **MajorComplexScript** - refers to the major font for complex script characters in font scheme.
- **MinorAscii** - refers to the minor Ascii font in font scheme.
- **MinorHighAnsi** - refers to the minor font for high ANSI characters in font scheme.
- **MinorEastAsia** - refers to the minor font for East Asian characters in font scheme.
- **MinorComplexScript** - refers to the minor font for complex script characters in font scheme.

The **Hint** property of the **RunFonts** class can have the following values:
- **Default** - no hint is provided, and the font is determined based on the Unicode code point of the character.
- **EastAsia** - the font should be determined using East Asian font slot for characters that fall into East Asian classification, regardless of their Unicode code point.
- **ComplexScript** - the font should be determined using Complex Script font slot for characters that fall into Complex Script classification, regardless of their Unicode code point.

The font is determined for each of the characters in the text using the two-step algorithm:
1. Use the table of Unicode code points to decide the classification of the character, based on its Unicode code point.
2. If, after the first step, the character falls into East Asian classification and the value of the **Hint** property
is **EastAsia**, then the character should use East Asian font slot
	a. Otherwise, if this run has **ComplexScript** or **RightToLeft** properties set, then the character should use Complex Script font slot, regardless of its Unicode code point.
		i. Otherwise, the character is decided using the font slot that is corresponding to the classification in the range table.
				
Note that **Hint** value of **ComplexScript** is not used in the above algorithm. 
Instead, the Complex Script font slot is used for runs that have **ComplexScript** (\<w:cs>) or **RightToLeft** (\<w:rtl>) properties set, 
regardless of the value of the **Hint** property. 
Additionally, the **ComplexScript** (\<w:cs>) property also causes the Complex Script formatting
(\<w:bCs>, \<w:iCs>, etc.) to be applied to the run instead of the regular formatting (\<w:b>, \<w:i>, etc.),

## Drawings.FontReference class

When a font is referenced in a drawing element, such as a shape, 
it is represented by the **FontReference** class,
which is an element of the **DocumentModel.Drawings.ShapeStyle** class. 
The **FontReference** type has an **Index** property, 
which is an enum value that indicates the font type for the drawing element. 
It allows to select only **Major** or **Minor** font types from the font scheme, 
and does not allow to specify the font by name.

## MathProperties class

When a font is referenced in a mathematical equation, a **MathProperties** class is used.
The **MathProperties** class has a property called **Typeface**, 
which specifies the default math font to be used in the document. 
If this element is omitted, font substitution should be used 
to determine the most appropriate font for use throughout the document.  
