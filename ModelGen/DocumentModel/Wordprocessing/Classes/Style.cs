namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the definition of a single style within a WordprocessingML document. A style is a predefined set of table, numbering, paragraph, and/or character properties which can be applied to regions within a document.
/// </summary>
public partial class Style
{
  
  /// <summary>
  ///   Style Type
  /// </summary>
  public StyleKind? Type { get; set; }
  
  
  /// <summary>
  ///   Style ID
  /// </summary>
  public String? StyleId { get; set; }
  
  
  /// <summary>
  ///   Default Style
  /// </summary>
  public Boolean? Default { get; set; }
  
  
  /// <summary>
  ///   User-Defined Style
  /// </summary>
  public Boolean? CustomStyle { get; set; }
  
  
  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  public String? StyleName { get; set; }
  
  
  /// <summary>
  ///   Alternate Style Names.
  /// </summary>
  public String? Aliases { get; set; }
  
  
  /// <summary>
  ///   Parent Style ID.
  /// </summary>
  public String? BasedOn { get; set; }
  
  
  /// <summary>
  ///   Style For Next Paragraph.
  /// </summary>
  public String? NextParagraphStyle { get; set; }
  
  
  /// <summary>
  ///   Linked Style Reference.
  /// </summary>
  public String? LinkedStyle { get; set; }
  
  
  /// <summary>
  ///   Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  public Boolean? AutoRedefine { get; set; }
  
  
  /// <summary>
  ///   Hide Style From User Interface.
  /// </summary>
  public Boolean? StyleHidden { get; set; }
  
  
  /// <summary>
  ///   Optional User Interface Sorting Order.
  /// </summary>
  public Int32? UIPriority { get; set; }
  
  
  /// <summary>
  ///   Hide Style From Main User Interface.
  /// </summary>
  public Boolean? SemiHidden { get; set; }
  
  
  /// <summary>
  ///   Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  public Boolean? UnhideWhenUsed { get; set; }
  
  
  /// <summary>
  ///   Primary Style.
  /// </summary>
  public Boolean? PrimaryStyle { get; set; }
  
  
  /// <summary>
  ///   Style Cannot Be Applied.
  /// </summary>
  public Boolean? Locked { get; set; }
  
  
  /// <summary>
  ///   E-Mail Message Text Style.
  /// </summary>
  public Boolean? Personal { get; set; }
  
  
  /// <summary>
  ///   E-Mail Message Composition Style.
  /// </summary>
  public Boolean? PersonalCompose { get; set; }
  
  
  /// <summary>
  ///   E-Mail Message Reply Style.
  /// </summary>
  public Boolean? PersonalReply { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Style Definition.
  /// </summary>
  public HexInt? Rsid { get; set; }
  
  
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
  public TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties { get; set; }
  
  
  /// <summary>
  ///   Style Table Cell Properties.
  /// </summary>
  public StyleTableCellProperties? StyleTableCellProperties { get; set; }
  
  public ElementCollection<TableStyleProperties>? Items { get; set; }
  
}
