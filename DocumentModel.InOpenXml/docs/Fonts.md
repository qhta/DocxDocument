Fonts, that are used in the OpenXml document, are stored in the **FontTablePart** part. 
Content of the **FontTablePart** part is represented by the **FontTable** class. 
Each font is represented by the **Font** class. 
The **Font** class has a property called **Name**, which contains the name of the font,
and is used to identify the font in the document.

# Font class

The **Font** class has several properties that are used to identify the font and determine its similarity to other fonts.
- **Name** - the base name of the font, which is used to identify the font in the document.
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
The obfuscation process involves XORing the first 32 bytes of the font data with bytes derived from the **FontKey**. 
This ensures that the font data is not easily readable, providing a layer of protection for the embedded font.

Font data is deobfuscated when the font is loaded from the embedded font part in OpenXml document to the **EmbedFont** instance, 
and obfuscated when the font is saved to the embedded font part.