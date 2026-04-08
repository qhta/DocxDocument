namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains font attributes (font name, font size, color, and so on) for an object.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.font?view=word-pia"/>
public partial interface ITextFormat
{

  /// <summary>
  /// True if the text is formatted as bold.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.bold?view=word-pia"/>
  public OnOffToggle? Bold { get; set; }

  /// <summary>
  /// True if the text is formatted as italic.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.italic?view=word-pia"/>
  public OnOffToggle? Italic { get; set; }

  /// <summary>
  /// True if the text is formatted as hidden.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.hidden?view=word-pia"/>
  public OnOffToggle? Hidden { get; set; }

  /// <summary>
  /// True if the text is formatted as small capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.smallcaps?view=word-pia"/>
  public OnOffToggle? SmallCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as all capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.allcaps?view=word-pia"/>
  public OnOffToggle? AllCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.strikethrough?view=word-pia"/>
  public OnOffToggle? StrikeThrough { get; set; }

  /// <summary>
  /// True if the text is formatted as double strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.doublestrikethrough?view=word-pia"/>
  public OnOffToggle? DoubleStrikeThrough { get; set; }

  /// <summary>
  /// Gets or sets the color index for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.colorindex?view=word-pia"/>
  public ColorIndex? ColorIndex { get; set; }

  /// <summary>
  /// True if the text is formatted as subscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.subscript?view=word-pia"/>
  public OnOffToggle? Subscript { get; set; }

  /// <summary>
  /// True if the text is formatted as superscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.superscript?view=word-pia"/>
  public OnOffToggle? Superscript { get; set; }

  /// <summary>
  /// Gets or sets the underline style for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.underline?view=word-pia"/>
  public UnderlineType? Underline { get; set; }

  /// <summary>
  /// The font size in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.size?view=word-pia"/>
  public float? FontSize { get; set; }

  /// <summary>
  /// The name of the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// The position of text (in points) relative to the baseline. A positive number raises the text, and a negative number lowers it.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.position?view=word-pia"/>
  public int? Position { get; set; }

  /// <summary>
  /// The spacing (in points) between characters.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.spacing?view=word-pia"/>
  public float? Spacing { get; set; }

  /// <summary>
  /// The scaling percentage applied to the font. This property stretches or compresses text horizontally as a percentage of the current size (the scaling range is from 1 through 600).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.scaling?view=word-pia"/>
  public int? Scaling { get; set; }

  /// <summary>
  /// True if the specified font is formatted as shadowed. Can be True, False, or Undefined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.shadow?view=word-pia"/>
  public OnOff? HasShadow { get; set; }

  /// <summary>
  /// True if the text is formatted as outlined.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.outline?view=word-pia"/>
  public OnOffToggle? Outline { get; set; }

  /// <summary>
  /// True if the text is formatted as embossed.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.emboss?view=word-pia"/>
  public OnOffToggle? Emboss { get; set; }

  /// <summary>
  /// The minimum font size for which kerning should be applied automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.kerning?view=word-pia"/>
  public float? Kerning { get; set; }

  /// <summary>
  /// True if the text is formatted as engraved.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.engrave?view=word-pia"/>
  public OnOffToggle? Engrave { get; set; }

  /// <summary>
  /// Gets or sets the animation effect for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.animation?view=word-pia"/>
  public Animation? Animation { get; set; }

  /// <summary>
  /// Gets or sets the border formatting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.borders?view=word-pia"/>
  public IBorders? Borders { get; set; }

  /// <summary>
  /// Gets or sets the emphasis mark for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.emphasismark?view=word-pia"/>
  public EmphasisMark? EmphasisMark { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether to disable character spacing on the document grid.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.disablecharacterspacegrid?view=word-pia"/>
  public bool? DisableCharacterSpaceGrid { get; set; }

  /// <summary>
  /// The name of the font for East Asian scripts.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.namefareast?view=word-pia"/>
  public string? NameFarEast { get; set; }

  /// <summary>
  /// The name of the font for used for Latin text (characters with character codes from 0 (zero) through 127).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.nameascii?view=word-pia"/>
  public string? NameAscii { get; set; }

  /// <summary>
  /// The name of the font for characters with character codes from 128 through 255.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.nameother?view=word-pia"/>
  public string? NameOther { get; set; }

  /// <summary>
  /// The 24-bit color for the specified TextFormat object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.color?view=word-pia"/>
  public IColor? Color { get; set; }

  /// <summary>
  /// True if the text is formatted as bold for complex script.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.boldbi?view=word-pia"/>
  public OnOffToggle? BoldCS { get; set; }

  /// <summary>
  /// True if the text is formatted as italic for complex script.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.italicbi?view=word-pia"/>
  public OnOffToggle? ItalicCS { get; set; }

  /// <summary>
  /// The font size in points for complex script.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.sizebi?view=word-pia"/>
  public float? FontSizeCS { get; set; }

  /// <summary>
  /// The name of the font for complex script.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.namebi?view=word-pia"/>
  public string? NameCS { get; set; }

  /// <summary>
  /// Gets or sets the color index for complex-script text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.colorindexbi?view=word-pia"/>
  public ColorIndex? ColorIndexCS { get; set; }

  /// <summary>
  /// Gets or sets the color of diacritical marks.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.diacriticcolor?view=word-pia"/>
  public IColor? DiacriticColor { get; set; }

  /// <summary>
  /// Gets or sets the underline color.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.underlinecolor?view=word-pia"/>
  public IColor? UnderlineColor { get; set; }

}
