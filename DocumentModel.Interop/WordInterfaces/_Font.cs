namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see Font.
/// </summary>
public partial interface _Font : InteropObject
{
  /// <summary>
  /// The duplicate.
  /// </summary>
  public Font Duplicate { get; }

  /// <summary>
  /// True if the text is formatted as bold.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int Bold { get; set; }

  /// <summary>
  /// True if the text is formatted as italic.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int Italic { get; set; }

  /// <summary>
  /// True if the text is formatted as hidden.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int Hidden { get; set; }

  /// <summary>
  /// True if the text is formatted as small capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int SmallCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as all capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int AllCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int StrikeThrough { get; set; }

  /// <summary>
  /// True if the text is formatted as double strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int DoubleStrikeThrough { get; set; }

  /// <summary>
  /// The color index.
  /// </summary>
  public WdColorIndex ColorIndex { get; set; }

  /// <summary>
  /// True if the text is formatted as subscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int Subscript { get; set; }

  /// <summary>
  /// True if the text is formatted as superscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int Superscript { get; set; }

  /// <summary>
  /// The underline.
  /// </summary>
  public WdUnderline Underline { get; set; }

  /// <summary>
  /// The font size in points.
  /// </summary>
  public float Size { get; set; }

  /// <summary>
  /// The name of the font.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The position of text (in points) relative to the baseline. A positive number raises the text, and a negative number lowers it.
  /// </summary>
  public int Position { get; set; }

  /// <summary>
  /// The spacing (in points) between characters.
  /// </summary>
  public float Spacing { get; set; }

  /// <summary>
  /// The scaling percentage applied to the font. This property stretches or compresses text horizontally as a percentage of the current size (the scaling range is from 1 through 600).
  /// </summary>
  public int Scaling { get; set; }

  /// <summary>
  /// True if the specified font is formatted as shadowed. Can be True, False, or Undefined.
  /// </summary>
  public int Shadow { get; set; }

  /// <summary>
  /// True if the text is formatted as outlined.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int Outline { get; set; }

  /// <summary>
  /// True if the text is formatted as embossed.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int Emboss { get; set; }

  /// <summary>
  /// The minimum font size for which kerning should be applied automatically.
  /// </summary>
  public float Kerning { get; set; }

  /// <summary>
  /// True if the text is formatted as engraved.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int Engrave { get; set; }

  /// <summary>
  /// The animation.
  /// </summary>
  public WdAnimation Animation { get; set; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The emphasis mark.
  /// </summary>
  public WdEmphasisMark EmphasisMark { get; set; }

  /// <summary>
  /// The disable character space grid.
  /// </summary>
  public bool DisableCharacterSpaceGrid { get; set; }

  /// <summary>
  /// The name of the font for East Asian scripts.
  /// </summary>
  public string NameFarEast { get; set; }

  /// <summary>
  /// The name of the font for used for Latin text (characters with character codes from 0 (zero) through 127).
  /// </summary>
  public string NameAscii { get; set; }

  /// <summary>
  /// The name of the font for characters with character codes from 128 through 255.
  /// </summary>
  public string NameOther { get; set; }

  /// <summary>
  /// The 24-bit color for the specified Font object.
  /// </summary>
  public WdColor Color { get; set; }

  /// <summary>
  /// True if the text is formatted as bold (for complex script).
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int BoldBi { get; set; }

  /// <summary>
  /// True if the text is formatted as italic (for complex script).
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public int ItalicBi { get; set; }

  /// <summary>
  /// The font size in points for complex script.
  /// </summary>
  public float SizeBi { get; set; }

  /// <summary>
  /// The name of the font for complex script.
  /// </summary>
  public string NameBi { get; set; }

  /// <summary>
  /// The color index bi.
  /// </summary>
  public WdColorIndex ColorIndexBi { get; set; }

  /// <summary>
  /// The diacritic color.
  /// </summary>
  public WdColor DiacriticColor { get; set; }

  /// <summary>
  /// The underline color.
  /// </summary>
  public WdColor UnderlineColor { get; set; }

  /// <summary>
  /// The glow.
  /// </summary>
  public GlowFormat Glow { get; set; }

  /// <summary>
  /// The reflection.
  /// </summary>
  public ReflectionFormat Reflection { get; set; }

  /// <summary>
  /// The text shadow.
  /// </summary>
  public ShadowFormat TextShadow { get; set; }

  /// <summary>
  /// The fill.
  /// </summary>
  public FillFormat Fill { get; set; }

  /// <summary>
  /// The line.
  /// </summary>
  public LineFormat Line { get; set; }

  /// <summary>
  /// The three d.
  /// </summary>
  public ThreeDFormat ThreeD { get; set; }

  /// <summary>
  /// The text color.
  /// </summary>
  public ColorFormat TextColor { get; }

  /// <summary>
  /// The ligatures.
  /// </summary>
  public WdLigatures Ligatures { get; set; }

  /// <summary>
  /// The number form.
  /// </summary>
  public WdNumberForm NumberForm { get; set; }

  /// <summary>
  /// The number spacing.
  /// </summary>
  public WdNumberSpacing NumberSpacing { get; set; }

  /// <summary>
  /// The contextual alternates.
  /// </summary>
  public int ContextualAlternates { get; set; }

  /// <summary>
  /// The stylistic set.
  /// </summary>
  public WdStylisticSet StylisticSet { get; set; }
}
