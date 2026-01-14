namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Specifies the set of properties that define the behavior, appearance, and functionality of a structured document tag (SDT) in a WordprocessingML document.
  /// This interface provides configuration for identity, data binding, appearance, content type, behavior, locking, and specialized controls, enabling advanced management and customization of SDTs at block, inline, row, or cell level.
  /// </summary>
  public interface SdtProperties : IStoryContent
  {
    
    /// <summary>
    /// Unique numerical identifier for this structured document tag.
    /// </summary>
    public HexInt? SdtId { get; set; }
    
    /// <summary>
    /// Run properties applied to text runs within the structured document tag.
    /// </summary>
    public RunProperties? RunProperties { get; set; }
    
    /// <summary>
    /// Friendly name (alias) associated with this structured document tag.
    /// </summary>
    public string? SdtAlias { get; set; }
    
    /// <summary>
    /// Locking behavior that controls how the content and the SDT itself can be edited.
    /// </summary>
    public LockingKind? Lock { get; set; }
    
    /// <summary>
    /// Placeholder configuration that defines the text displayed when the SDT is empty.
    /// </summary>
    public SdtPlaceholder? SdtPlaceholder { get; set; }
    
    /// <summary>
    /// Indicates whether the SDT is currently displaying placeholder text.
    /// </summary>
    public bool? ShowingPlaceholder { get; set; }
    
    /// <summary>
    /// Data binding configuration that maps this SDT to an XML element in a Custom XML Data part.
    /// </summary>
    public SdtDataBinding? DataBinding { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT should be automatically removed when its contents are modified.
    /// </summary>
    public bool? TemporarySdt { get; set; }
    
    /// <summary>
    /// Programmatic tag that identifies this SDT for application code.
    /// </summary>
    public string? Tag { get; set; }
    
    /// <summary>
    /// Color used for visual highlighting or borders of the SDT.
    /// </summary>
    public IColor? Color { get; set; }
    
    /// <summary>
    /// Visual appearance style for this structured document tag.
    /// </summary>
    public AppearanceKind? Appearance { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT is linked to a web extension (Office Add-in).
    /// </summary>
    public bool? WebExtensionLinked { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT was created by a web extension (Office Add-in).
    /// </summary>
    public bool? WebExtensionCreated { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT represents an equation content control.
    /// </summary>
    public bool? SdtContentEquation { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT represents a picture content control.
    /// </summary>
    public bool? SdtContentPicture { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT represents a rich text content control.
    /// </summary>
    public bool? SdtContentRichText { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT represents a citation content control.
    /// </summary>
    public bool? SdtContentCitation { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT represents a group content control.
    /// </summary>
    public bool? SdtContentGroup { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT represents a bibliography content control.
    /// </summary>
    public bool? SdtContentBibliography { get; set; }
    
    /// <summary>
    /// Indicates whether the entity picker for this SDT is in an empty state.
    /// </summary>
    public bool? EntityPickerEmpty { get; set; }
    
    /// <summary>
    /// Indicates whether this SDT is an item within a repeating section.
    /// </summary>
    public bool? IsRepeatedSectionItem { get; set; }
    
    /// <summary>
    /// Plain text or formatted text content control configuration.
    /// </summary>
    public SdtContentText? SdtContentText { get; set; }
    
    /// <summary>
    /// Checkbox content control configuration.
    /// </summary>
    public SdtContentCheckBox? SdtContentCheckBox { get; set; }
    
    /// <summary>
    /// Combo box content control configuration.
    /// </summary>
    public SdtContentComboBox? SdtContentComboBox { get; set; }
    
    /// <summary>
    /// Date picker content control configuration.
    /// </summary>
    public SdtContentDate? SdtContentDate { get; set; }
    
    /// <summary>
    /// Document part object content control configuration.
    /// </summary>
    public SdtContentDocPartObject? SdtContentDocPartObject { get; set; }
    
    /// <summary>
    /// Document part list content control configuration.
    /// </summary>
    public SdtContentDocPartObject? SdtContentDocPartList { get; set; }
    
    /// <summary>
    /// Drop-down list content control configuration.
    /// </summary>
    public SdtContentDropDownList? SdtContentDropDownList { get; set; }
    
    /// <summary>
    /// Repeating section content control configuration.
    /// </summary>
    public SdtRepeatedSection? SdtRepeatedSection { get; set; }
  }