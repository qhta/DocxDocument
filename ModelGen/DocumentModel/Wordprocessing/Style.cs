namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the definition of a single style within a WordprocessingML document. A style is a predefined set of table, numbering, paragraph, and/or character properties which can be applied to regions within a document.
/// </summary>
public partial class Style
{
  
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
  public DMW.Aliases? Aliases { get; set; }
  
  
  /// <summary>
  ///   Parent Style ID.
  /// </summary>
  public DMW.BasedOn? BasedOn { get; set; }
  
  
  /// <summary>
  ///   Style For Next Paragraph.
  /// </summary>
  public DMW.NextParagraphStyle? NextParagraphStyle { get; set; }
  
  
  /// <summary>
  ///   Linked Style Reference.
  /// </summary>
  public DMW.LinkedStyle? LinkedStyle { get; set; }
  
  
  /// <summary>
  ///   Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  public DMW.AutoRedefine? AutoRedefine { get; set; }
  
  
  /// <summary>
  ///   Hide Style From User Interface.
  /// </summary>
  public DMW.StyleHidden? StyleHidden { get; set; }
  
  
  /// <summary>
  ///   Optional User Interface Sorting Order.
  /// </summary>
  public Int32? UIPriority { get; set; }
  
  
  /// <summary>
  ///   Hide Style From Main User Interface.
  /// </summary>
  public DMW.SemiHidden? SemiHidden { get; set; }
  
  
  /// <summary>
  ///   Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  public DMW.UnhideWhenUsed? UnhideWhenUsed { get; set; }
  
  
  /// <summary>
  ///   Primary Style.
  /// </summary>
  public DMW.PrimaryStyle? PrimaryStyle { get; set; }
  
  
  /// <summary>
  ///   Style Cannot Be Applied.
  /// </summary>
  public DMW.Locked? Locked { get; set; }
  
  
  /// <summary>
  ///   E-Mail Message Text Style.
  /// </summary>
  public DMW.Personal? Personal { get; set; }
  
  
  /// <summary>
  ///   E-Mail Message Composition Style.
  /// </summary>
  public DMW.PersonalCompose? PersonalCompose { get; set; }
  
  
  /// <summary>
  ///   E-Mail Message Reply Style.
  /// </summary>
  public DMW.PersonalReply? PersonalReply { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Style Definition.
  /// </summary>
  public HexInt? Rsid { get; set; }
  
  
  /// <summary>
  ///   Style Paragraph Properties.
  /// </summary>
  public DMW.StyleParagraphProperties? StyleParagraphProperties { get; set; }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public DMW.StyleRunProperties? StyleRunProperties { get; set; }
  
  
  /// <summary>
  ///   Style Table Properties.
  /// </summary>
  public DMW.StyleTableProperties? StyleTableProperties { get; set; }
  
  
  /// <summary>
  ///   Style Table Row Properties.
  /// </summary>
  public DMW.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties { get; set; }
  
  
  /// <summary>
  ///   Style Table Cell Properties.
  /// </summary>
  public DMW.StyleTableCellProperties? StyleTableCellProperties { get; set; }
  
}
