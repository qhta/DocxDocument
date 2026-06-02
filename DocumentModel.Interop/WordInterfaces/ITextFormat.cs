namespace DocumentModel.Interop;

/// <summary>
/// Defines the formatting properties for text. These properties include font name, font size, and font style. The TextFormat object is used by the Font property of the CharacterFormat object and the ParagraphFormat object to specify the formatting of text in a document.
/// </summary>
public interface IITextFormat
{
  /// <summary>
  /// The name of the font.
  /// </summary>
  public string? FontName { get; set; }

  /// <summary>
  /// The name of the font for used for Latin text (characters with character codes from 0 (zero) through 127).
  /// </summary>
  public string? FontNameAscii { get; set; }

  /// <summary>
  /// The name of the font for characters with character codes from 128 through 255.
  /// </summary>
  public string? NameOther { get; set; }

  /// <summary>
  /// The name of the font for bidirectional script.
  /// </summary>
  public string? FontNameBi { get; set; }

  /// <summary>
  /// The name of the font for East Asian scripts.
  /// </summary>
  public string? FontNameFarEast { get; set; }

  /// <summary>
  /// The font size in points.
  /// </summary>
  public float? Size { get; set; }

  /// <summary>
  /// The font size in points for bidirectional script.
  /// </summary>
  public float? SizeBi { get; set; }

  /// <summary>
  /// True if the text is formatted as bold.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  /// True if the text is formatted as bold (for bidirectional script).
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? BoldBi { get; set; }

  /// <summary>
  /// True if the text is formatted as italic.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  /// True if the text is formatted as italic (for bidirectional script).
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? ItalicBi { get; set; }

  /// <summary>
  /// True if the text is formatted as strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? StrikeThrough { get; set; }

  /// <summary>
  /// True if the text is formatted as double strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? DoubleStrikeThrough { get; set; }

  /// <summary>
  /// True if the text is formatted as all capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? AllCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as small capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? SmallCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as subscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? Subscript { get; set; }

  /// <summary>
  /// True if the text is formatted as superscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? Superscript { get; set; }

  /// <summary>
  /// The 24-bit color for the specified Font object.
  /// </summary>
  public PresetColors? Color { get; set; }

  /// <summary>
  /// The color index.
  /// </summary>
  public ColorIndex? ColorIndex { get; set; }
  
  /// <summary>
  /// The color index for bidirectional script.
  /// </summary>
  public ColorIndex? ColorIndexBi { get; set; }

  /// <summary>
  /// The color for diacritical marks.
  /// </summary>
  public PresetColors? DiacriticColor { get; set; }

  /// <summary>
  /// The color for text
  /// </summary>
  public ColorFormat? TextColor { get; }

  /// <summary>
  /// The underline style for the specified Font object.
  /// </summary>
  public Underline? Underline { get; set; }

  /// <summary>
  /// The color of the underline.
  /// </summary>
  public PresetColors? UnderlineColor { get; set; }

  /// <summary>
  /// The position of text (in points) relative to the baseline. A positive number raises the text, and a negative number lowers it. 
  /// </summary>
  public int? Position { get; set; }

  /// <summary>
  /// The spacing (in points) between characters.
  /// </summary>
  public float? Spacing { get; set; }

  /// <summary>
  /// The scaling percentage applied to the font. This property stretches or compresses text horizontally as a percentage of the current size (the scaling range is from 1 through 600). 
  /// </summary>
  public int? Scaling { get; set; }

  /// <summary>
  /// True if the specified font is formatted as shadowed. Can be True, False, or Undefined. 
  /// </summary>
  public bool? Shadow { get; set; }

  /// <summary>
  /// True if the text is formatted as outlined.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? Outline { get; set; }

  /// <summary>
  /// True if the text is formatted as embossed.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? Emboss { get; set; }

  /// <summary>
  /// True if the text is formatted as engraved.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? Engrave { get; set; }

  /// <summary>
  /// The minimum font size for which kerning should be applied automatically.
  /// </summary>
  public float? Kerning { get; set; }


  /// <summary>
  /// True if the text is formatted as hidden.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public bool? Hidden { get; set; }

  /// <summary>
  /// The animation effect applied to the text
  /// </summary>
  public WdAnimation? Animation { get; set; }

  /// <summary>
  /// The borders for the specified text.
  /// </summary>
  public Borders? Borders { get; set; }

  /// <summary>
  /// The shading for the specified Font object.
  /// </summary>
  public Shading? Shading { get; }

  /// <summary>
  /// The emphasis mark type.
  /// </summary>
  public WdEmphasisMark? EmphasisMark { get; set; }

  /// <summary>
  /// True if the character space grid is disabled.
  /// </summary>
  public bool? DisableCharacterSpaceGrid { get; set; }

  /// <summary>
  /// The glow effect applied to the text.
  /// </summary>
  public GlowFormat? Glow { get; set; }

  /// <summary>
  /// The reflection effect applied to the text.
  /// </summary>
  public ReflectionFormat? Reflection { get; set; }

  /// <summary>
  /// The shadow effect applied to the text.
  /// </summary>
  public ShadowFormat? TextShadow { get; set; }

  /// <summary>
  /// The fill formatting for the text.
  /// </summary>
  public FillFormat? Fill { get; set; }

  /// <summary>
  /// The line formatting for the text. 
  /// </summary>
  public LineFormat? Line { get; set; }

  /// <summary>
  /// The three-dimensional (3-D) formatting for the text.
  /// </summary>
  public ThreeDFormat? ThreeD { get; set; }

  /// <summary>
  /// The ligature setting for the text. 
  /// </summary>
  public OtLigatures? Ligatures { get; set; }

  /// <summary>
  /// The number form setting for the text. This property applies only to OpenType fonts that support different number forms. 
  /// </summary>
  public OtNumberForm? NumberForm { get; set; }

  /// <summary>
  /// The number spacing setting for the text. This property applies only to OpenType fonts that support different number spacing settings.
  /// </summary>
  public WdNumberSpacing? NumberSpacing { get; set; }

  /// The contextual alternates setting for the text. This property applies only to OpenType fonts that support contextual alternates.
  public bool? ContextualAlternates { get; set; }

  /// <summary>
  /// The stylistic set for the text. This property applies only to OpenType fonts that support stylistic sets.
  /// </summary>
  public OtStylisticSet? StylisticSet { get; set; }

  //#region methods
  /// <summary>
  /// Sets the specified TextFormat object as the default text format for the template. When you set a TextFormat object as the default text format for a template, the properties of that TextFormat object are applied to all new documents based on that template, unless the properties are overridden by other formatting settings in the document.
  /// </summary>
  public void SetAsTemplateDefault();

  //public void Grow();
  //public void Shrink();
  //public void Reset();
  //#endregion

}