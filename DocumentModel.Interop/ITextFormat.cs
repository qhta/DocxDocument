using DocumentModel.Wordprocessing;

namespace DocumentModel.Interop;

public interface ITextFormat
{
  //public Application Application { get; }
  //public int Creator { get; }
  //public object Parent { get; }
  //public Font Duplicate { get; }


  /// <summary>
  /// The name of the font.
  /// </summary>
  public string FontName { get; set; }

  /// <summary>
  /// The name of the font for used for Latin text (characters with character codes from 0 (zero) through 127).
  /// </summary>
  public string FonNameAscii { get; set; }

  /// <summary>
  /// The name of the font for characters with character codes from 128 through 255.
  /// </summary>
  public string NameOther { get; set; }

  /// <summary>
  /// The name of the font for bidirectional script.
  /// </summary>
  public string FontNameBi { get; set; }

  /// <summary>
  /// The name of the font for East Asian scripts.
  /// </summary>
  public string FontNameFarEast { get; set; }


  /// <summary>
  /// The font size in points.
  /// </summary>
  public float Size { get; set; }

  /// <summary>
  /// The font size in points for bidirectional script.
  /// </summary>
  public float SizeBi { get; set; }

  /// <summary>
  /// True if the text is formatted as bold.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle Bold { get; set; }

  /// <summary>
  /// True if the text is formatted as bold (for bidirectional script).
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle BoldBi { get; set; }

  /// <summary>
  /// True if the text is formatted as italic.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle Italic { get; set; }

  /// <summary>
  /// True if the text is formatted as italic (for bidirectional script).
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle ItalicBi { get; set; }

  /// <summary>
  /// True if the text is formatted as strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle StrikeThrough { get; set; }

  /// <summary>
  /// True if the text is formatted as double strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle DoubleStrikeThrough { get; set; }

  /// <summary>
  /// True if the text is formatted as all capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle AllCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as small capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle SmallCaps { get; set; }

  /// <summary>
  /// True if the text is formatted as subscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle Subscript { get; set; }

  /// <summary>
  /// True if the text is formatted as superscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle Superscript { get; set; }

  /// <summary>
  /// The 24-bit color for the specified Font object.
  /// </summary>
  public PresetColors Color { get; set; }

  public WdColorIndex ColorIndex { get; set; }

  public WdColorIndex ColorIndexBi { get; set; }

  public PresetColors DiacriticColor { get; set; }



  public ColorFormat TextColor { get; }

  public UnderlineType Underline { get; set; }

  public WdColor UnderlineColor { get; set; }

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
  public OnOff Shadow { get; set; }

  /// <summary>
  /// True if the text is formatted as outlined.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle Outline { get; set; }

  /// <summary>
  /// True if the text is formatted as embossed.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle Emboss { get; set; }

  /// <summary>
  /// True if the text is formatted as engraved.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle Engrave { get; set; }

  /// <summary>
  /// The minimum font size for which kerning should be applied automatically.
  /// </summary>
  public float Kerning { get; set; }


  /// <summary>
  /// True if the text is formatted as hidden.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  public OnOffToggle Hidden { get; set; }


  public WdAnimation Animation { get; set; }
  public Borders Borders { get; set; }
  public Shading Shading { get; }
  public WdEmphasisMark EmphasisMark { get; set; }
  public bool DisableCharacterSpaceGrid { get; set; }
  public GlowFormat Glow { get; set; }
  public ReflectionFormat Reflection { get; set; }
  public ShadowFormat TextShadow { get; set; }
  public FillFormat Fill { get; set; }
  public LineFormat Line { get; set; }
  public ThreeDFormat ThreeD { get; set; }
  public WdLigatures Ligatures { get; set; }
  public WdNumberForm NumberForm { get; set; }
  public WdNumberSpacing NumberSpacing { get; set; }
  public int ContextualAlternates { get; set; }
  public WdStylisticSet StylisticSet { get; set; }

  //#region methods
  public void SetAsTemplateDefault();

  //public void Grow();
  //public void Shrink();
  //public void Reset();
  //#endregion

}