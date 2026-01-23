namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Run Properties interface for formatting text runs in WordprocessingML documents.
  /// Provides complete control over character-level formatting including font name, size, style, color, spacing, effects, and advanced typography features.
  /// Corresponds to the DocumentFormat.OpenXml.Wordprocessing.RunProperties class and contains all properties for comprehensive run formatting.
  /// </summary>
  public class RunProperties: BaseRunProperties<DXW.RunProperties>
  {
    
    /// <summary>
    /// Run style identifier, referencing a style defined in the document's styles part.
    /// </summary>
    public string? RunStyle { get; set; }
    
    /// <summary>
    /// Indicates whether complex script text in the run is bold.
    /// </summary>
    public bool? BoldComplexScript { get; set; }
    
    /// <summary>
    /// Indicates whether complex script text in the run is italic.
    /// </summary>
    public bool? ItalicComplexScript { get; set; }
    
    /// <summary>
    /// Font size for complex script text in half-points.
    /// </summary>
    public string? FontSizeComplexScript { get; set; }
    
    /// <summary>
    /// Highlight color.
    /// </summary>
    public HighlightColorKind? Highlight { get; set; }
    
    
    /// <summary>
    /// Indicates whether text direction is right-to-left.
    /// </summary>
    public bool? RightToLeftText { get; set; }
    
    /// <summary>
    /// Indicates whether text uses complex script formatting.
    /// </summary>
    public bool? ComplexScript { get; set; }
    
    /// <summary>
    /// Language settings for spell checking and grammar.
    /// </summary>
    public LanguageType? Languages { get; set; }
    
    /// <summary>
    /// Glow effect (Office 2010+).
    /// </summary>
    public DMWD.Glow? Glow { get; set; }
    
    /// <summary>
    /// Shadow effect (Office 2010+).
    /// </summary>
    public DMWD.Shadow? Shadow14 { get; set; }
    
    /// <summary>
    /// Reflection effect (Office 2010+).
    /// </summary>
    public DMWD.Reflection? Reflection { get; set; }
    
    /// <summary>
    /// Text outline effect (Office 2010+).
    /// </summary>
    public DMWD.TextOutlineEffect? TextOutlineEffect { get; set; }
    
    /// <summary>
    /// Text fill effect (Office 2010+).
    /// </summary>
    public FillTextEffect? FillTextEffect { get; set; }
    
    /// <summary>
    /// 3D scene properties (Office 2010+).
    /// </summary>
    public DMWD.Scene3D? Scene3D { get; set; }
    
    /// <summary>
    /// 3D text properties (Office 2010+).
    /// </summary>
    public DMWD.Properties3D? Properties3D { get; set; }
    
    /// <summary>
    /// OpenType ligatures setting (Office 2010+), controls which ligatures are used in OpenType fonts.
    /// </summary>
    public LigaturesKind? Ligatures { get; set; }
    
    /// <summary>
    /// Number form for OpenType fonts (Office 2010+), specifies lining or old-style numerals.
    /// </summary>
    public NumberFormKind? NumberingFormat { get; set; }
    
    /// <summary>
    /// Number spacing for OpenType fonts (Office 2010+), specifies proportional or tabular spacing for numbers.
    /// </summary>
    public NumberSpacingKind? NumberSpacing { get; set; }
    
    /// <summary>
    /// Stylistic sets collection (Office 2010+), OpenType fonts may include alternate glyph sets.
    /// </summary>
    public StylisticSets? StylisticSets { get; set; }
    
    /// <summary>
    /// Indicates whether to use contextual alternates (Office 2010+), adjusts glyphs based on surrounding characters.
    /// </summary>
    public OnOffKind? ContextualAlternatives { get; set; }
    
    /// <summary>
    /// Run properties change tracking information, records the previous state of run properties when changes are tracked.
    /// </summary>
    public RunPropertiesChange? RunPropertiesChange { get; set; }
  }