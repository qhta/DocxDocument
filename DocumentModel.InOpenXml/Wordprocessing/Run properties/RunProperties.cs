namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties class for formatting text runs in WordprocessingML documents.
/// Provides complete control over character-level formatting including font name, size, style, color, spacing, effects, and advanced typography features.
/// Corresponds to the DocumentFormat.OpenXml.Wordprocessing.RunProperties class and contains all properties for comprehensive run formatting.
/// </summary>
[OpenXmlType(typeof(DXW.RunProperties))]
[XmlRoot("RunProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class RunProperties: BaseRunProperties<DXW.RunProperties>
{
  /// <summary>
  /// Run style identifier, referencing a style defined in the document's styles part.
  /// </summary>
  [OpenXmlElement(typeof(DXW.RunStyle))]
  public string? RunStyle
  {
    get => _RunStyle ??= GetElement<string?, DXW.RunStyle>(_openXmlElement);
    set => UpdateField(ref _RunStyle, value, nameof(RunStyle));
  }

  private string? _RunStyle;

  /// <summary>
  /// Indicates whether complex script text in the run is bold.
  /// </summary>
  [OpenXmlElement(typeof(DXW.BoldComplexScript))]
  public bool? BoldComplexScript
  {
    get => _BoldComplexScript ??= GetElement<bool?, DXW.BoldComplexScript>(_openXmlElement);
    set => UpdateField(ref _BoldComplexScript, value, nameof(BoldComplexScript));
  }

  private bool? _BoldComplexScript;

  /// <summary>
  /// Indicates whether complex script text in the run is italic.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ItalicComplexScript))]
  public bool? ItalicComplexScript
  {
    get => _ItalicComplexScript ??= GetElement<bool?, DXW.ItalicComplexScript>(_openXmlElement);
    set => UpdateField(ref _ItalicComplexScript, value, nameof(ItalicComplexScript));
  }

  private bool? _ItalicComplexScript;

  /// <summary>
  /// TextFormat size for complex script text in half-points.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FontSizeComplexScript))]
  public string? FontSizeComplexScript
  {
    get => _FontSizeComplexScript ??= GetElement<string?, DXW.FontSizeComplexScript>(_openXmlElement);
    set => UpdateField(ref _FontSizeComplexScript, value, nameof(FontSizeComplexScript));
  }

  private string? _FontSizeComplexScript;

  /// <summary>
  /// Highlight color.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Highlight))]
  public HighlightColors? Highlight
  {
    get => _Highlight ??= GetElement<HighlightColors?, DXW.Highlight>(_openXmlElement);
    set => UpdateField(ref _Highlight, value, nameof(Highlight));
  }

  private HighlightColors? _Highlight;

  /// <summary>
  /// Indicates whether text direction is right-to-left.
  /// </summary>
  [OpenXmlElement(typeof(DXW.RightToLeftText))]
  public bool? RightToLeftText
  {
    get => _RightToLeftText ??= GetElement<bool?, DXW.RightToLeftText>(_openXmlElement);
    set => UpdateField(ref _RightToLeftText, value, nameof(RightToLeftText));
  }

  private bool? _RightToLeftText;

  /// <summary>
  /// Indicates whether text uses complex script formatting.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ComplexScript))]
  public bool? ComplexScript
  {
    get => _ComplexScript ??= GetElement<bool?, DXW.ComplexScript>(_openXmlElement);
    set => UpdateField(ref _ComplexScript, value, nameof(ComplexScript));
  }

  private bool? _ComplexScript;

  /// <summary>
  /// Glow effect (Office 2010+).
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.Glow))]
  public DMWD.Glow? Glow
  {
    get => _Glow ??= GetElement<DMWD.Glow?, DXO10W.Glow>(_openXmlElement);
    set => UpdateField(ref _Glow, value, nameof(Glow));
  }

  private DMWD.Glow? _Glow;

  /// <summary>
  /// Shadow effect (Office 2010+).
  /// </summary>
  [OpenXmlElement(typeof(DXW.Shadow))]
  public DMWD.Shadow? Shadow
  {
    get => _Shadow ??= GetElement<DMWD.Shadow?, DXW.Shadow>(_openXmlElement);
    set => UpdateField(ref _Shadow, value, nameof(Shadow));
  }

  private DMWD.Shadow? _Shadow;

  /// <summary>
  /// Reflection effect (Office 2010+).
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.Reflection))]
  public DMWD.Reflection? Reflection
  {
    get => _Reflection ??= GetElement<DMWD.Reflection?, DXO10W.Reflection>(_openXmlElement);
    set => UpdateField(ref _Reflection, value, nameof(Reflection));
  }

  private DMWD.Reflection? _Reflection;

  /// <summary>
  /// Text outline effect (Office 2010+).
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.TextOutlineEffect))]
  public DMWD.TextOutlineEffect? TextOutlineEffect
  {
    get => _TextOutlineEffect ??= GetElement<DMWD.TextOutlineEffect?, DXO10W.TextOutlineEffect>(_openXmlElement);
    set => UpdateField(ref _TextOutlineEffect, value, nameof(TextOutlineEffect));
  }

  private DMWD.TextOutlineEffect? _TextOutlineEffect;

  /// <summary>
  /// Text fill effect (Office 2010+).
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.FillTextEffect))]
  public DMWD.FillTextEffect? FillTextEffect
  {
    get => _FillTextEffect ??= GetElement<DMWD.FillTextEffect?, DXO10W.FillTextEffect>(_openXmlElement);
    set => UpdateField(ref _FillTextEffect, value, nameof(FillTextEffect));
  }

  private DMWD.FillTextEffect? _FillTextEffect;

  /// <summary>
  /// 3D scene properties (Office 2010+).
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.Scene3D))]
  public DMWD.Scene3D? Scene3D
  {
    get => _Scene3D ??= GetElement<DMWD.Scene3D?, DXO10W.Scene3D>(_openXmlElement);
    set => UpdateField(ref _Scene3D, value, nameof(Scene3D));
  }

  private DMWD.Scene3D? _Scene3D;

  /// <summary>
  /// 3D text properties (Office 2010+).
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.Properties3D))]
  public DMWD.Properties3D? Properties3D
  {
    get => _Properties3D ??= GetElement<DMWD.Properties3D?, DXO10W.Properties3D>(_openXmlElement);
    set => UpdateField(ref _Properties3D, value, nameof(Properties3D));
  }

  private DMWD.Properties3D? _Properties3D;

  /// <summary>
  /// OpenType ligatures setting (Office 2010+), controls which ligatures are used in OpenType fonts.
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.Ligatures))]
  public Ligatures? Ligatures
  {
    get => _Ligatures ??= GetElement<Ligatures?, DXO10W.Ligatures>(_openXmlElement);
    set => UpdateField(ref _Ligatures, value, nameof(Ligatures));
  }

  private Ligatures? _Ligatures;

  /// <summary>
  /// Number form for OpenType fonts (Office 2010+), specifies lining or old-style numerals.
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.NumberingFormat))]
  public NumberForm? NumberingFormat
  {
    get => _NumberingFormat ??= GetElement<NumberForm?, DXO10W.NumberingFormat>(_openXmlElement);
    set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat));
  }

  private NumberForm? _NumberingFormat;

  /// <summary>
  /// Number spacing for OpenType fonts (Office 2010+), specifies proportional or tabular spacing for numbers.
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.NumberSpacing))]
  public NumberSpacing? NumberSpacing
  {
    get => _NumberSpacing ??= GetElement<NumberSpacing?, DXO10W.NumberSpacing>(_openXmlElement);
    set => UpdateField(ref _NumberSpacing, value, nameof(NumberSpacing));
  }

  private NumberSpacing? _NumberSpacing;

  /// <summary>
  /// Stylistic sets collection (Office 2010+), OpenType fonts may include alternate glyph sets.
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.StylisticSets))]
  public StylisticSets? StylisticSets
  {
    get => _StylisticSets ??= GetElement<StylisticSets?, DXO10W.StylisticSets>(_openXmlElement);
    set => UpdateField(ref _StylisticSets, value, nameof(StylisticSets));
  }

  private StylisticSets? _StylisticSets;

  /// <summary>
  /// Indicates whether to use contextual alternates (Office 2010+), adjusts glyphs based on surrounding characters.
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.ContextualAlternatives))]
  public Boolean? ContextualAlternatives
  {
    get => _ContextualAlternatives ??= GetElement<Boolean?, DXO10W.ContextualAlternatives>(_openXmlElement);
    set => UpdateField(ref _ContextualAlternatives, value, nameof(ContextualAlternatives));
  }

  private Boolean? _ContextualAlternatives;

  /// <summary>
  /// Run properties change tracking information, records the previous state of run properties when changes are tracked.
  /// </summary>
  [OpenXmlElement(typeof(DXW.RunPropertiesChange))]
  public RunPropertiesChange? RunPropertiesChange
  {
    get => _RunPropertiesChange ??= GetElement<RunPropertiesChange?, DXW.RunPropertiesChange>(_openXmlElement);
    set => UpdateField(ref _RunPropertiesChange, value, nameof(RunPropertiesChange));
  }

  private RunPropertiesChange? _RunPropertiesChange;
}