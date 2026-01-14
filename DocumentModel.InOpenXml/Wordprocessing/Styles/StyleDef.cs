namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a style definition in a Wordprocessing document.
  /// This interface provides properties for style type, identifiers, inheritance, UI settings, revision tracking, and formatting options, enabling advanced style management and customization for document content.
  /// </summary>
  public partial interface StyleDef : IEquatable<StyleDef>
  {
    
    /// <summary>
    /// Style type, such as paragraph, character, table, or numbering.
    /// </summary>
    public StyleKind? Type { get; set; }
    
    /// <summary>
    /// Style identifier, used to uniquely identify the style in the document.
    /// </summary>
    public string? StyleId { get; set; }
    
    /// <summary>
    /// Style name as displayed in the UI.
    /// </summary>
    public string? StyleName { get; set; }
    
    /// <summary>
    /// Indicates whether the style is the default for its type.
    /// </summary>
    public bool? IsDefault { get; set; }
    
    /// <summary>
    /// Indicates whether the style is user-defined.
    /// </summary>
    public bool? IsCustom { get; set; }
    
    /// <summary>
    /// Parent style identifier, specifying the style on which this style is based.
    /// </summary>
    public string? BasedOn { get; set; }
    
    /// <summary>
    /// Style for the next paragraph, used for automatic style transitions.
    /// </summary>
    public string? NextParagraphStyle { get; set; }
    
    /// <summary>
    /// Linked style reference, specifying a related style for linking purposes.
    /// </summary>
    public string? LinkedStyle { get; set; }
    
    /// <summary>
    /// Indicates whether user formatting is automatically merged into the style definition.
    /// </summary>
    public Boolean IsAutoRedefined { get; set; }
    
    /// <summary>
    /// Indicates whether the style is hidden from the user interface.
    /// </summary>
    public Boolean IsHidden { get; set; }
    
    /// <summary>
    /// Indicates whether the style is hidden from the main user interface.
    /// </summary>
    public Boolean IsSemiHidden { get; set; }
    
    /// <summary>
    /// Indicates whether the semi-hidden property is removed when the style is used.
    /// </summary>
    public Boolean IsUnhiddenWhenUsed { get; set; }
    
    /// <summary>
    /// Optional user interface sorting order, specifying the priority of the style in the UI.
    /// </summary>
    public Int32? UIPriority { get; set; }
    
    /// <summary>
    /// Indicates whether the style is a primary style.
    /// </summary>
    public Boolean IsPrimary { get; set; }
    
    /// <summary>
    /// Indicates whether the style cannot be applied.
    /// </summary>
    public Boolean IsLocked { get; set; }
    
    /// <summary>
    /// Indicates whether the style is used for e-mail message text.
    /// </summary>
    public Boolean IsPersonal { get; set; }
    
    /// <summary>
    /// Indicates whether the style is used for e-mail message composition.
    /// </summary>
    public Boolean IsPersonalCompose { get; set; }
    
    /// <summary>
    /// Indicates whether the style is used for e-mail message replies.
    /// </summary>
    public Boolean IsPersonalReply { get; set; }
    
    /// <summary>
    /// Revision identifier for the style definition, used for change tracking.
    /// </summary>
    public HexInt? Rsid { get; set; }
    
    /// <summary>
    /// Style paragraph properties, specifying formatting for paragraphs in the style.
    /// </summary>
    public StyleParagraphProperties? StyleParagraphProperties { get; set; }
    
    /// <summary>
    /// Run properties, specifying formatting for text runs in the style.
    /// </summary>
    public StyleRunProperties? StyleRunProperties { get; set; }
    
    /// <summary>
    /// Style table properties, specifying formatting for tables in the style.
    /// </summary>
    public StyleTableProperties? StyleTableProperties { get; set; }
    
    /// <summary>
    /// Style table row properties, specifying formatting for table rows in the style.
    /// </summary>
    public TableStyleConditionalRowProperties? TableStyleConditionalFormattingTableRowProperties { get; set; }
    
    /// <summary>
    /// Style table cell properties, specifying formatting for table cells in the style.
    /// </summary>
    public StyleTableCellProperties? StyleTableCellProperties { get; set; }
    
    /// <summary>
    /// Table style properties, specifying conditional formatting for tables in the style.
    /// </summary>
    public TableStyleConditionalProperties? TableStyleConditionalProperties { get; set; }
  }