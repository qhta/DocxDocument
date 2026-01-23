using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for all RunProperties classes, containing common character-level formatting properties for text runs in WordprocessingML documents.
/// Provides control over fonts, bold, italic, size, caps, underline, color, spacing, alignment, and other essential run formatting features.
/// </summary>
public partial class BaseRunProperties<T> : ModelElementCollection<RunProperty, T, DX.OpenXmlElement> 
  where T : DX.OpenXmlCompositeElement
{
#region Common run properties
  /// <summary>
  /// Fonts used to display the text contents of this run, supporting ASCII, High ANSI, Complex Script, and East Asian character ranges.
  /// </summary>
  [XmlIgnore]
  public RunFonts? RunFonts { get; set; }
  /// <summary>
  /// Bold property for characters in the run, with separate toggles for regular and complex script.
  /// </summary>
  public BoldFonts? Bold { get; set; }
  /// <summary>
  /// Italic property for characters in the run, with separate toggles for regular and complex script.
  /// </summary>
  public ItalicFonts? Italic { get; set; }
  /// <summary>
  /// Font size for the run, with separate values for regular and complex script, measured in half points.
  /// </summary>
  public FontSizes? FontSize { get; set; }
  /// <summary>
  /// Formats lowercase characters as capital letters for display only.
  /// </summary>
  public bool? Caps { get; set; }
  /// <summary>
  /// Formats small letter characters as capital letters in a smaller font size for display only.
  /// </summary>
  public bool? SmallCaps { get; set; }
  /// <summary>
  /// Underline style for the run contents.
  /// </summary>
  public Underline? Underline { get; set; }
  /// <summary>
  /// Displays a single horizontal line through the center of the run.
  /// </summary>
  public bool? Strike { get; set; }
  /// <summary>
  /// Displays two horizontal lines through each character in the run.
  /// </summary>
  public bool? DoubleStrike { get; set; }
  /// <summary>
  /// Color used to display the run contents, can be explicit or automatic.
  /// </summary>
  public DocumentModel.Color? Color { get; set; }
  /// <summary>
  /// Character pitch added or removed after each character in the run.
  /// </summary>
  public Twips? Spacing { get; set; }
  /// <summary>
  /// Amount by which each character is expanded or compressed when rendered.
  /// </summary>
  public Percent? CharacterScale { get; set; }
  /// <summary>
  /// Minimum font size for automatic kerning in the run.
  /// </summary>
  public Twips? Kern { get; set; }
  /// <summary>
  /// Determines if the run uses the document grid characters per line settings.
  /// </summary>
  public bool? SnapToGrid { get; set; }
  /// <summary>
  /// Alignment for the run contents, supporting subscript and superscript.
  /// </summary>
  public VerticalPositionKind? VerticalTextAlignment { get; set; }
  /// <summary>
  /// Amount by which text is raised or lowered relative to the baseline, in half-points.
  /// </summary>
  public Twips? Position { get; set; }
  /// <summary>
  /// Displays the run contents as an outline by drawing a border around each character glyph.
  /// </summary>
  public bool? Outline { get; set; }
  /// <summary>
  /// Displays the run contents as embossed, making text appear raised off the page.
  /// </summary>
  public bool? Emboss { get; set; }
  /// <summary>
  /// Displays the run contents as imprinted (engraved), making text appear pressed into the page.
  /// </summary>
  public bool? Imprint { get; set; }
  /// <summary>
  /// Displays the run contents with a shadow effect.
  /// </summary>
  public bool? Shadow { get; set; }
  /// <summary>
  /// Languages used for spell checking and grammar, supporting regular, complex, and East Asian scripts.
  /// </summary>
  public Languages? Language { get; set; }
  /// <summary>
  /// Prevents spelling and grammar errors from being reported for this run.
  /// </summary>
  public bool? NoProof { get; set; }
  /// <summary>
  /// Shading applied to the run, including background color, pattern, and pattern color.
  /// </summary>
  public DMWD.Shading? Shading { get; set; }
  /// <summary>
  /// Border information for the run, including grouping and rendering details.
  /// </summary>
  public Border? Border { get; set; }
  /// <summary>
  /// Animated text effect for the run.
  /// </summary>
  public TextEffectKind? TextEffect { get; set; }
  /// <summary>
  /// Resizes run contents to fit a specified width by adjusting character size.
  /// </summary>
  public FitText? FitText { get; set; }
  /// <summary>
  /// Emphasis mark applied to each non-space character in the run.
  /// </summary>
  public EmphasisMarkKind? Emphasis { get; set; }
  /// <summary>
  /// East Asian typography settings, including two lines in one and horizontal in vertical text options.
  /// </summary>
  public EastAsianLayout? EastAsianLayout { get; set; }
  /// <summary>
  /// Hides the run contents from display at display time in the document.
  /// </summary>
  public bool? Vanish { get; set; }
  /// <summary>
  /// Ensures the run always behaves as hidden, even when hidden text is displayed (for paragraph marks).
  /// </summary>
  public bool? SpecVanish { get; set; }
  /// <summary>
  /// Hides the run contents from display in web page view.
  /// </summary>
  public bool? WebHidden { get; set; }
#endregion
  /// <summary>
  /// Drawing properties collected from run properties.
  /// </summary>
  public DrawingProperties? DrawingProperties { get; set; }
}