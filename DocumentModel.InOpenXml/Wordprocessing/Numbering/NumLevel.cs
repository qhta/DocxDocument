namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Specifies the appearance and behavior of a numbering level within a given abstract numbering definition in a WordprocessingML document.
  /// A numbering level contains a set of properties for the display of numbering for a given level, including formatting, starting value, restart behavior, text, picture bullets, and associated paragraph/run properties.
  /// </summary>
  /// <remarks>
  /// A numbering level definition is identical to a numbering level override definition, except it is defined as part of a numbering definition instance using the abstractNum element rather than as part of an abstract numbering definition using the num element.
  /// </remarks>
  public interface NumLevel : CollectionItem
  {
    
    /// <summary>
    /// Zero-based index of the numbering level defined by this set of properties (e.g., 2 is the 3rd list level).
    /// </summary>
    public Int32? LevelIndex { get; set; }
    
    /// <summary>
    /// Indicates that this numbering level was saved by a producer but not used in the parent document, allowing redefinition by future consumers.
    /// </summary>
    public bool? Tentative { get; set; }
    
    /// <summary>
    /// Starting value for numbering at this level, used when the level starts or is restarted. Defaults to zero if omitted.
    /// </summary>
    public Int32? StartNumberingValue { get; set; }
    
    /// <summary>
    /// One-based index determining when this numbering level should restart to its start value, based on higher or earlier levels.
    /// </summary>
    public Int32? LevelRestart { get; set; }
    
    /// <summary>
    /// Number format used to display numbering at this level, replacing %x in the level text string with the appropriate value.
    /// </summary>
    public NumberingFormat? NumberingFormat { get; set; }
    
    /// <summary>
    /// Paragraph style ID associated with this numbering level.
    /// </summary>
    public string? ParagraphStyleIdInLevel { get; set; }
    
    /// <summary>
    /// Indicates that all levels are displayed using Arabic numerals.
    /// </summary>
    public bool? IsLegalNumberingStyle { get; set; }
    
    /// <summary>
    /// Content added between the numbering level's text and the text of every numbered paragraph referencing this level. Defaults to tab if omitted.
    /// </summary>
    public LevelSuffixKind? LevelSuffix { get; set; }
    
    /// <summary>
    /// Textual content displayed for paragraphs at this numbering level, with %x replaced by the appropriate number.
    /// </summary>
    public NumLevelText? LevelText { get; set; }
    
    /// <summary>
    /// Identifier for the picture bullet to use as the numbering symbol at this level.
    /// </summary>
    public Int32? LevelPictureBulletId { get; set; }
    
    /// <summary>
    /// Unique hexadecimal value for UI location of this numbering level, interpretation is application-defined.
    /// </summary>
    public HexInt? TemplateCode { get; set; }
    
    /// <summary>
    /// Indicates that this numbering level is from an earlier word processor that did not support full WordprocessingML numbering properties.
    /// </summary>
    public LegacyNumbering? LegacyNumbering { get; set; }
    
    /// <summary>
    /// Justification for the numbering level (e.g., left, center, right).
    /// </summary>
    public LevelJustificationKind? LevelJustification { get; set; }
    
    /// <summary>
    /// Paragraph properties associated with this numbering level, specifying formatting for paragraphs at this level.
    /// </summary>
    public PreviousParagraphProperties? NumberingLevelParagraphProperties { get; set; }
    
    /// <summary>
    /// Run properties for the numbering symbol at this level, specifying formatting for the symbol.
    /// </summary>
    public NumberingSymbolRunProperties? NumberingSymbolRunProperties { get; set; }
  }