using System.CodeDom;

using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for all RunProperties classes, containing common character-level formatting properties for text runs in WordprocessingML documents.
/// Provides control over fonts, bold, italic, size, caps, underline, color, spacing, alignment, and other essential run formatting features.
/// </summary>
[XmlRoot("BaseRunProperties", Namespace = "DocumentModel.Wordprocessing")]
[DirectAccess(true)]
public abstract partial class BaseRunProperties<OpenXmlElementType> : ModelElement<OpenXmlElementType> where OpenXmlElementType : DX.OpenXmlCompositeElement
{
  /// <summary>
  /// Default constructor for the BaseRunProperties class, initializing a new instance of the BaseRunProperties class.
  /// </summary>
  protected BaseRunProperties() : base() { }

  ///// <summary>
  ///// Initializes a new instance of the BaseRunProperties class with the specified parent element.
  ///// </summary>
  ///// <param name="parent">The parent ModelElement that contains this element. Can be null if this is a root element.</param>
  //protected BaseRunProperties(ModelElement parent) : base(parent) { }

  ///// <summary>
  ///// Initializes a new instance of the BaseRunProperties class using the specified OpenXmlElementType.
  ///// </summary>
  ///// <param name="element">The OpenXmlElementType that provides the underlying element for the run properties.</param>
  //protected BaseRunProperties(OpenXmlElementType element) : base(element) { }

  /// <summary>
  /// Initializes a new instance of the BaseRunProperties class with the specified parent element and OpenXmlElementType.
  /// </summary>
  /// <param name="parent">The parent ModelElement that contains this element. Can be null if this is a root element.</param>
  /// <param name="element">The OpenXmlElementType that provides the underlying element for the run properties.</param>
  protected BaseRunProperties(ModelElement parent, OpenXmlElementType? element) : base(parent, element) { }

  #region Common run properties

  /// <summary>
  /// Fonts used to display the text contents of this run, supporting ASCII, High ANSI, Complex Script, and East Asian character ranges.
  /// </summary>
  [OpenXmlElement(typeof(DXW.RunFonts))]
  [MultiCategory("Fonts and attributes")]
  public RunFonts? RunFonts
  {
    get => _RunFonts ??= GetElement<DMW.RunFonts, DXW.RunFonts>(_UpdatableElement); 
    set => UpdateField(ref _RunFonts, value, nameof(RunFonts));
  }
  private RunFonts? _RunFonts;

  /// <summary>
  /// Bold property for characters in the run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Bold))]
  [MultiCategory("Fonts and attributes")]
  public Boolean? Bold
  {
    get => _Bold ??= GetElement<bool?, DXW.Bold>(_UpdatableElement);
    set => UpdateField(ref _Bold, value, nameof(RunFonts));
  }
  private Boolean? _Bold;

  /// <summary>
  /// Separate bold property for characters in the complex script.
  /// </summary>
  [OpenXmlElement(typeof(DXW.BoldComplexScript))]
  [MultiCategory("Fonts and attributes")]
  public Boolean? BoldCS
  {
    get => _BoldCS ??= GetElement<bool?, DXW.BoldComplexScript>(_UpdatableElement);
    set => UpdateField(ref _BoldCS, value, nameof(BoldCS));
  }
  private Boolean? _BoldCS;

  /// <summary>
  /// Italic property for characters in the run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Italic))]
  [MultiCategory("Fonts and attributes")]
  public Boolean? Italic
  {
    get => _Italic ??= GetElement<bool?, DXW.Italic>(_UpdatableElement);
    set => UpdateField(ref _Italic, value, nameof(Italic));
  }
  private Boolean? _Italic;

  /// <summary>
  /// Separate italic property for characters in the complex script.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ItalicComplexScript))]
  [MultiCategory("Fonts and attributes")]
  public Boolean? ItalicCS
  {
    get => _ItalicCS ??= GetElement<bool?, DXW.ItalicComplexScript>(_UpdatableElement);
    set => UpdateField(ref _ItalicCS, value, nameof(ItalicCS));
  }
  private Boolean? _ItalicCS;

  /// <summary>
  /// TextFormat size for the run, measured in half points.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FontSize))]
  [MultiCategory("Fonts and attributes")]
  public HPS? FontSize { get => _FontSize ??= GetElement<HPS?, DXW.FontSize>(_UpdatableElement); set => UpdateField(ref _FontSize, value, nameof(FontSize)); }
  private HPS? _FontSize;

  /// <summary>
  /// Separate font size for characters in complex script, measured in half points.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FontSizeComplexScript))]
  [MultiCategory("Fonts and attributes")]
  public HPS? FontSizeCS { get => _FontSizeCS ??= GetElement<HPS?, DXW.FontSizeComplexScript>(_UpdatableElement); set => UpdateField(ref _FontSizeCS, value, nameof(FontSizeCS)); }
  private HPS? _FontSizeCS;

  /// <summary>
  /// Formats lowercase characters as capital letters for display only.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Caps))]
  [MultiCategory("Fonts and attributes")]
  public bool? AllCaps { get => _AllCaps ??= GetElement<bool?, DXW.Caps>(_UpdatableElement); set => UpdateField(ref _AllCaps, value, nameof(AllCaps)); }
  private bool? _AllCaps;

  /// <summary>
  /// Formats small letter characters as capital letters in a smaller font size for display only.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SmallCaps))]
  [MultiCategory("Fonts and attributes")]
  public bool? SmallCaps { get => _SmallCaps ??= GetElement<bool?, DXW.SmallCaps>(_UpdatableElement); set => UpdateField(ref _SmallCaps, value, nameof(SmallCaps)); }
  private bool? _SmallCaps;

  /// <summary>
  /// Underline style for the run contents.
  /// </summary>
  [MultiCategory("Fonts and attributes")]
  public Underline? Underline { get => _Underline ??= GetElement<Underline?, DXW.Underline>(_UpdatableElement); set => UpdateField(ref _Underline, value, nameof(Underline)); }
  private Underline? _Underline;

  /// <summary>
  /// Displays a single horizontal line through the center of the run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Strike))]
  [MultiCategory("Fonts and attributes")]
  public bool? Strike { get => _Strike ??= GetElement<bool?, DXW.Strike>(_UpdatableElement); set => UpdateField(ref _Strike, value, nameof(Strike)); }
  private bool? _Strike;

  /// <summary>
  /// Displays two horizontal lines through each character in the run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoubleStrike))]
  [MultiCategory("Fonts and attributes")]
  public bool? DoubleStrike { get => _DoubleStrike ??= GetElement<bool?, DXW.DoubleStrike>(_UpdatableElement); set => UpdateField(ref _DoubleStrike, value, nameof(DoubleStrike)); }
  private bool? _DoubleStrike;

  /// <summary>
  /// Color used to display the run contents, can be explicit or automatic.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Color))]
  [MultiCategory("Fonts and attributes")]
  public DMW.Color? Color { get => _Color ??= GetElement<DMW.Color?, DXW.Color>(_UpdatableElement); set => UpdateField(ref _Color, value, nameof(Color)); }
  private DMW.Color? _Color;

  /// <summary>
  /// Character pitch added or removed after each character in the run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Spacing))]
  [MultiCategory("Scaling and spacing")]
  public Twips? Spacing { get => _Spacing ??= GetElement<Twips?, DXW.Spacing>(_UpdatableElement); set => UpdateField(ref _Spacing, value, nameof(Spacing)); }
  private Twips? _Spacing;

  /// <summary>
  /// Amount by which each character is expanded or compressed when rendered.
  /// </summary>
  [OpenXmlElement(typeof(DXW.CharacterScale))]
  [MultiCategory("Scaling and spacing")]
  public Percent? CharacterScale { get => _CharacterScale ??= GetElement<Percent?, DXW.CharacterScale>(_UpdatableElement); set => UpdateField(ref _CharacterScale, value, nameof(CharacterScale)); }
  private Percent? _CharacterScale;

  /// <summary>
  /// Minimum font size for automatic kerning in the run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Kern))]
  [MultiCategory("Positioning and alignment")]
  public HPS? Kern { get => _Kern ??= GetElement<HPS?, DXW.Kern>(_UpdatableElement); set => UpdateField(ref _Kern, value, nameof(Kern)); }
  private HPS? _Kern;

  /// <summary>
  /// Determines if the run uses the document grid characters per line settings.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SnapToGrid))]
  [MultiCategory("Positioning and alignment")]
  public bool? SnapToGrid { get => _SnapToGrid ??= GetElement<bool?, DXW.SnapToGrid>(_UpdatableElement); set => UpdateField(ref _SnapToGrid, value, nameof(SnapToGrid)); }
  private bool? _SnapToGrid;

  /// <summary>
  /// Alignment for the run contents, supporting subscript and superscript.
  /// </summary>
  [OpenXmlElement(typeof(DXW.VerticalTextAlignment))]
  [MultiCategory("Positioning and alignment")]
  public VerticalPosition? VerticalTextAlignment { get => _VerticalTextAlignment ??= GetElement<VerticalPosition?, DXW.VerticalTextAlignment>(_UpdatableElement); set => UpdateField(ref _VerticalTextAlignment, value, nameof(VerticalTextAlignment)); }
  private VerticalPosition? _VerticalTextAlignment;

  /// <summary>
  /// Subscript formatting for the run, which lowers text below the baseline. Setting this to true will set VerticalTextAlignment to Subscript, while setting it to false will clear the subscript formatting if it is currently applied.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public bool? Subscript
  {
    get => VerticalTextAlignment == VerticalPosition.Subscript;
    set
    {
      if (value == true)
        VerticalTextAlignment = VerticalPosition.Subscript;
      else if (value == false && VerticalTextAlignment == VerticalPosition.Subscript)
        VerticalTextAlignment = VerticalPosition.Baseline;
      else if (value == null && VerticalTextAlignment == VerticalPosition.Subscript)
        VerticalTextAlignment = null;
    }
  }

  /// <summary>
  /// Superscript formatting for the run, which raises text above the baseline. Setting this to true will set VerticalTextAlignment to Superscript, while setting it to false will clear the superscript   formatting if it is currently applied.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public bool? Superscript
  {
    get => VerticalTextAlignment == VerticalPosition.Superscript;
    set
    {
      if (value == true)
        VerticalTextAlignment = VerticalPosition.Superscript;
      else if (value == false && VerticalTextAlignment == VerticalPosition.Superscript)
        VerticalTextAlignment = VerticalPosition.Baseline;
      else if (value == null && VerticalTextAlignment == VerticalPosition.Superscript)
        VerticalTextAlignment = null;
    }
  }

  /// <summary>
  /// Amount by which text is raised or lowered relative to the baseline, in half-points.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Position))]
  [MultiCategory("Positioning and alignment")]
  public Twips? Position { get => _Position ??= GetElement<Twips?, DXW.Position>(_UpdatableElement); set => UpdateField(ref _Position, value, nameof(Position)); }
  private Twips? _Position;

  /// <summary>
  /// Displays the run contents as an outline by drawing a border around each character glyph.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Outline))]
  [MultiCategory("Effects and Border")]
  public bool? Outline { get => _Outline ??= GetElement<bool?, DXW.Outline>(_UpdatableElement); set => UpdateField(ref _Outline, value, nameof(Outline)); }
  private bool? _Outline;

  /// <summary>
  /// Displays the run contents as embossed, making text appear raised off the page.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Emboss))]
  [MultiCategory("Effects and Border")]
  public bool? Emboss { get => _Emboss ??= GetElement<bool?, DXW.Emboss>(_UpdatableElement); set => UpdateField(ref _Emboss, value, nameof(Emboss)); }
  private bool? _Emboss;

  /// <summary>
  /// Displays the run contents as imprinted (engraved), making text appear pressed into the page.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Imprint))]
  [MultiCategory("Effects and Border")]
  public bool? Imprint { get => _Imprint ??= GetElement<bool?, DXW.Imprint>(_UpdatableElement); set => UpdateField(ref _Imprint, value, nameof(Imprint)); }
  private bool? _Imprint;

  /// <summary>
  /// Displays the run contents with a shadow effect.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Shadow))]
  [MultiCategory("Effects and Border")]
  public bool? HasShadow { get => _HasShadow ??= GetElement<bool?, DXW.Shadow>(_UpdatableElement); set => UpdateField(ref _HasShadow, value, nameof(HasShadow)); }
  private bool? _HasShadow;

  /// <summary>
  /// Languages used for spell checking and grammar, supporting regular, complex, and East Asian scripts.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Languages))]
  [MultiCategory("Languages and proofing")]
  public Languages? Language { get => _Language ??= GetElement<Languages?, DXW.Languages>(_UpdatableElement); set => UpdateField(ref _Language, value, nameof(Language)); }
  private Languages? _Language;

  /// <summary>
  /// Prevents spelling and grammar errors from being reported for this run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NoProof))]
  [MultiCategory("Languages and proofing")]
  public bool? NoProof { get => _NoProof ??= GetElement<bool?, DXW.NoProof>(_UpdatableElement); set => UpdateField(ref _NoProof, value, nameof(NoProof)); }
  private bool? _NoProof;

  /// <summary>
  /// Shading applied to the run, including background color, pattern, and pattern color.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Shading))]
  [MultiCategory("Effects and Border")]
  public Shading? Shading { get => _Shading ??= GetElement<Shading?, DXW.Shading>(_UpdatableElement); set => UpdateField(ref _Shading, value, nameof(Shading)); }
  private Shading? _Shading;

  /// <summary>
  /// Border information for the run, including grouping and rendering details.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Border))]
  [MultiCategory("Effects and Border")]
  public Border? Border { get => _Border ??= GetElement<Border?, DXW.Border>(_UpdatableElement); set => UpdateField(ref _Border, value, nameof(Border)); }
  private Border? _Border;

  /// <summary>
  /// Animated text effect for the run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TextEffect))]
  [MultiCategory("Effects and Border")]
  public TextEffect? TextEffect { get => _TextEffect ??= GetElement<TextEffect?, DXW.TextEffect>(_UpdatableElement); set => UpdateField(ref _TextEffect, value, nameof(TextEffect)); }
  private TextEffect? _TextEffect;

  /// <summary>
  /// Resizes run contents to fit a specified width by adjusting character size.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FitText))]
  [MultiCategory("Scaling and spacing")]
  public FitText? FitText { get => _FitText ??= GetElement<FitText?, DXW.FitText>(_UpdatableElement); set => UpdateField(ref _FitText, value, nameof(FitText)); }
  private FitText? _FitText;

  /// <summary>
  /// Emphasis mark applied to each non-space character in the run.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Emphasis))]
  public EmphasisMark? Emphasis { get => _Emphasis ??= GetElement<EmphasisMark?, DXW.Emphasis>(_UpdatableElement); set => UpdateField(ref _Emphasis, value, nameof(Emphasis)); }
  private EmphasisMark? _Emphasis;

  /// <summary>
  /// East Asian typography settings, including two lines in one and horizontal in vertical text options.
  /// </summary>
  [OpenXmlElement(typeof(DXW.EastAsianLayout))]
  public EastAsianLayout? EastAsianLayout { get => _EastAsianLayout ??= GetElement<EastAsianLayout?, DXW.EastAsianLayout>(_UpdatableElement); set => UpdateField(ref _EastAsianLayout, value, nameof(EastAsianLayout)); }
  private EastAsianLayout? _EastAsianLayout;

  /// <summary>
  /// Hides the run contents from display at display time in the document.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Vanish))]
  public bool? Hidden { get => _hidden ??= GetElement<bool?, DXW.Vanish>(_UpdatableElement); set => UpdateField(ref _hidden, value, nameof(Hidden)); }
  private bool? _hidden;

  /// <summary>
  /// Ensures the run always behaves as hidden, even when hidden text is displayed (for paragraph marks).
  /// </summary>
  [OpenXmlElement(typeof(DXW.SpecVanish))]
  public bool? HiddenAlways { get => _hiddenAlways ??= GetElement<bool?, DXW.SpecVanish>(_UpdatableElement); set => UpdateField(ref _hiddenAlways, value, nameof(HiddenAlways)); }
  private bool? _hiddenAlways;

  /// <summary>
  /// Hides the run contents from display in web page view.
  /// </summary>
  [OpenXmlElement(typeof(DXW.WebHidden))]
  public bool? HiddenInWeb { get => _hiddenInWeb ??= GetElement<bool?, DXW.WebHidden>(_UpdatableElement); set => UpdateField(ref _hiddenInWeb, value, nameof(HiddenInWeb)); }
  private bool? _hiddenInWeb;
  #endregion
  ///// <summary>
  ///// Drawing properties collected from run properties.
  ///// </summary>
  //public DrawingProperties? DrawingProperties
  //{
  //  get => _DrawingProperties;
  //  set => UpdateField(ref _DrawingProperties, value, nameof(DrawingProperties));
  //}
  //private DrawingProperties? _DrawingProperties;
}

/// <summary>
/// Concrete class for BaseRunProperties
/// </summary>
[XmlRoot("BaseRunProperties", Namespace = "DocumentModel.Wordprocessing")]
public class BaseRunProperties : BaseRunProperties<DXW.RunPropertiesBaseStyle>
{
}