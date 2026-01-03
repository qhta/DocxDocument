namespace DocumentModel.Wordprocessing;
/// <summary>
///   Style Definition.
/// </summary>
public partial interface Style : IModelElement, IEquatable<Style>
{
  /// <summary>
  ///   Style Type
  /// </summary>
  public StyleKind? Type { get; set; }
  /// <summary>
  ///   Style ID
  /// </summary>
  public string? StyleId { get; set; }
  /// <summary>
  ///   Style Name
  /// </summary>
  public string? StyleName { get; set; }
  /// <summary>
  ///   Default Style
  /// </summary>
  [DefaultValue(false)]
  public bool? IsDefault { get; set; }
  /// <summary>
  ///   User-Defined Style
  /// </summary>
  [DefaultValue(false)]
  public bool? IsCustom { get; set; }
  /// <summary>
  ///   Parent Style ID.
  /// </summary>
  public string? BasedOn { get; set; }
  /// <summary>
  ///   Style For Next Paragraph.
  /// </summary>
  public string? NextParagraphStyle { get; set; }
  /// <summary>
  ///   Linked Style Reference.
  /// </summary>
  public string? LinkedStyle { get; set; }
  /// <summary>
  ///   Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsAutoRedefined { get; set; }
  /// <summary>
  ///   Hide Style From User Interface.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsHidden { get; set; }
  /// <summary>
  ///   Hide Style From Main User Interface.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsSemiHidden { get; set; }
  /// <summary>
  ///   Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsUnhiddenWhenUsed { get; set; }
  /// <summary>
  ///   Optional User Interface Sorting Order.
  /// </summary>
  public Int32? UIPriority { get; set; }
  /// <summary>
  ///   Primary Style.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsPrimary { get; set; }
  /// <summary>
  ///   Style Cannot Be Applied.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsLocked { get; set; }
  /// <summary>
  ///   E-Mail Message Text Style.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsPersonal { get; set; }
  /// <summary>
  ///   E-Mail Message Composition Style.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsPersonalCompose { get; set; }
  /// <summary>
  ///   E-Mail Message Reply Style.
  /// </summary>
  [DefaultValue(false)]
  public Boolean IsPersonalReply { get; set; }
  /// <summary>
  ///   Revision Identifier for Style Definition.
  /// </summary>
   public IHexInt? Rsid { get; set; }
  /// <summary>
  ///   Style Paragraph Properties.
  /// </summary>
  public StyleParagraphProperties? StyleParagraphProperties { get; set; }
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public StyleRunProperties? StyleRunProperties { get; set; }
  /// <summary>
  ///   Style Table Properties.
  /// </summary>
  public StyleTableProperties? StyleTableProperties { get; set; }
  /// <summary>
  ///   Style Table Row Properties.
  /// </summary>
  public TableStyleConditionalRowProperties? TableStyleConditionalFormattingTableRowProperties { get; set; }
  /// <summary>
  ///   Style Table Cell Properties.
  /// </summary>
  public StyleTableCellProperties? StyleTableCellProperties { get; set; }
  /// <summary>
  ///   Table Style Properties
  /// </summary>
  public TableStyleConditionalProperties? TableStyleConditionalProperties { get; set; }

}