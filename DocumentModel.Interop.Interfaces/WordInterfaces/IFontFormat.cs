namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see Font.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font?view=word-pia"/>
public interface IFontFormat : IInteropObject
{
  /// <summary>
  /// Gets a duplicate of the font formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.duplicate?view=word-pia"/>
  public IFontFormat Duplicate { get; }

  /// <summary>
  /// True if the text is formatted as bold.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.bold?view=word-pia"/>
  public int Bold { get; set; }

  /// <summary>
  /// True if the text is formatted as italic.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.italic?view=word-pia"/>
  public int Italic { get; set; }

  /// <summary>
  /// True if the text is formatted as hidden.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.hidden?view=word-pia"/>
  public int Hidden { get; set; }

  /// <summary>
  /// True if the text is formatted as small capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.smallcaps?view=word-pia"/>
  public int SmallCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as all capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.allcaps?view=word-pia"/>
  public int AllCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.strikethrough?view=word-pia"/>
  public int StrikeThrough { get; set; }

  /// <summary>
  /// True if the text is formatted as double strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.doublestrikethrough?view=word-pia"/>
  public int DoubleStrikeThrough { get; set; }

  /// <summary>
  /// Gets or sets the color index for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.colorindex?view=word-pia"/>
  public ColorIndex ColorIndex { get; set; }

  /// <summary>
  /// True if the text is formatted as subscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.subscript?view=word-pia"/>
  public int Subscript { get; set; }

  /// <summary>
  /// True if the text is formatted as superscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.superscript?view=word-pia"/>
  public int Superscript { get; set; }

  /// <summary>
  /// Gets or sets the underline style for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.underline?view=word-pia"/>
  public Underline Underline { get; set; }

  /// <summary>
  /// The font size in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.size?view=word-pia"/>
  public float Size { get; set; }

  /// <summary>
  /// The name of the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The position of text (in points) relative to the baseline. A positive number raises the text, and a negative number lowers it.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.position?view=word-pia"/>
  public int Position { get; set; }

  /// <summary>
  /// The spacing (in points) between characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.spacing?view=word-pia"/>
  public float Spacing { get; set; }

  /// <summary>
  /// The scaling percentage applied to the font. This property stretches or compresses text horizontally as a percentage of the current size (the scaling range is from 1 through 600).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.scaling?view=word-pia"/>
  public int Scaling { get; set; }

  /// <summary>
  /// True if the specified font is formatted as shadowed. Can be True, False, or Undefined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.shadow?view=word-pia"/>
  public int Shadow { get; set; }

  /// <summary>
  /// True if the text is formatted as outlined.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.outline?view=word-pia"/>
  public int Outline { get; set; }

  /// <summary>
  /// True if the text is formatted as embossed.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.emboss?view=word-pia"/>
  public int Emboss { get; set; }

  /// <summary>
  /// The minimum font size for which kerning should be applied automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.kerning?view=word-pia"/>
  public float Kerning { get; set; }

  /// <summary>
  /// True if the text is formatted as engraved.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.engrave?view=word-pia"/>
  public int Engrave { get; set; }

  /// <summary>
  /// Gets or sets the animation effect for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.animation?view=word-pia"/>
  public WdAnimation Animation { get; set; }

  /// <summary>
  /// Gets or sets the border formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.borders?view=word-pia"/>
  public IBorders Borders { get; set; }

  /// <summary>
  /// Gets the shading formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.shading?view=word-pia"/>
  public IShading Shading { get; }

  /// <summary>
  /// Gets or sets the emphasis mark for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.emphasismark?view=word-pia"/>
  public WdEmphasisMark EmphasisMark { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether to disable character spacing on the document grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.disablecharacterspacegrid?view=word-pia"/>
  public bool DisableCharacterSpaceGrid { get; set; }

  /// <summary>
  /// The name of the font for East Asian scripts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.namefareast?view=word-pia"/>
  public string NameFarEast { get; set; }

  /// <summary>
  /// The name of the font for used for Latin text (characters with character codes from 0 (zero) through 127).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.nameascii?view=word-pia"/>
  public string NameAscii { get; set; }

  /// <summary>
  /// The name of the font for characters with character codes from 128 through 255.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.nameother?view=word-pia"/>
  public string NameOther { get; set; }

  /// <summary>
  /// The 24-bit color for the specified Font object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.color?view=word-pia"/>
  public PresetColors Color { get; set; }

  /// <summary>
  /// True if the text is formatted as bold (for complex script).
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.boldbi?view=word-pia"/>
  public int BoldBi { get; set; }

  /// <summary>
  /// True if the text is formatted as italic (for complex script).
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.italicbi?view=word-pia"/>
  public int ItalicBi { get; set; }

  /// <summary>
  /// The font size in points for complex script.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.sizebi?view=word-pia"/>
  public float SizeBi { get; set; }

  /// <summary>
  /// The name of the font for complex script.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.namebi?view=word-pia"/>
  public string NameBi { get; set; }

  /// <summary>
  /// Gets or sets the color index for complex-script text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.colorindexbi?view=word-pia"/>
  public ColorIndex ColorIndexBi { get; set; }

  /// <summary>
  /// Gets or sets the color of diacritical marks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.diacriticcolor?view=word-pia"/>
  public PresetColors DiacriticColor { get; set; }

  /// <summary>
  /// Gets or sets the underline color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.underlinecolor?view=word-pia"/>
  public PresetColors UnderlineColor { get; set; }

  /// <summary>
  /// Gets or sets the glow formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.glow?view=word-pia"/>
  public IGlowFormat Glow { get; set; }

  /// <summary>
  /// Gets or sets the reflection formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.reflection?view=word-pia"/>
  public IReflectionFormat Reflection { get; set; }

  /// <summary>
  /// Gets or sets the shadow formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.textshadow?view=word-pia"/>
  public IShadowFormat TextShadow { get; set; }

  /// <summary>
  /// Gets or sets the fill formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.fill?view=word-pia"/>
  public IFillFormat Fill { get; set; }

  /// <summary>
  /// Gets or sets the line formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.line?view=word-pia"/>
  public ILineFormat Line { get; set; }

  /// <summary>
  /// Gets or sets the 3D formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.threed?view=word-pia"/>
  public IThreeDFormat ThreeD { get; set; }

  /// <summary>
  /// Gets the text color formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.textcolor?view=word-pia"/>
  public IColorFormat TextColor { get; }

  /// <summary>
  /// Gets or sets the ligature setting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.ligatures?view=word-pia"/>
  public OtLigatures Ligatures { get; set; }

  /// <summary>
  /// Gets or sets the number form for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.numberform?view=word-pia"/>
  public OtLigatures NumberForm { get; set; }

  /// <summary>
  /// Gets or sets the number spacing for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.numberspacing?view=word-pia"/>
  public WdNumberSpacing NumberSpacing { get; set; }

  /// <summary>
  /// Gets or sets whether contextual alternates are enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.contextualalternates?view=word-pia"/>
  public int ContextualAlternates { get; set; }

  /// <summary>
  /// Gets or sets the stylistic set for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.stylisticset?view=word-pia"/>
  public OtStylisticSet StylisticSet { get; set; }


  #region methods

/// <summary>
  /// Increases the font size to the next available size. If the selection or range contains more than one font
  /// size, each size is increased to the next available setting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.grow?view=word-pia"/>
  public void Grow();

  #endregion methods
}
