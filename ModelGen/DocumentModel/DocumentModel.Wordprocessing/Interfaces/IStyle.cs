namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Definition.
/// </summary>
public interface IStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style Type
  /// </summary>
  public StyleKind? Type { get ; set; }
  
  /// <summary>
  /// Style ID
  /// </summary>
  public String? StyleId { get ; set; }
  
  /// <summary>
  /// Default Style
  /// </summary>
  public Boolean? Default { get ; set; }
  
  /// <summary>
  /// User-Defined Style
  /// </summary>
  public Boolean? CustomStyle { get ; set; }
  
  /// <summary>
  /// Primary Style Name.
  /// </summary>
  public IStringValue? StyleName { get ; set; }
  
  /// <summary>
  /// Alternate Style Names.
  /// </summary>
  public IAliases? Aliases { get ; set; }
  
  /// <summary>
  /// Parent Style ID.
  /// </summary>
  public IBasedOn? BasedOn { get ; set; }
  
  /// <summary>
  /// Style For Next Paragraph.
  /// </summary>
  public INextParagraphStyle? NextParagraphStyle { get ; set; }
  
  /// <summary>
  /// Linked Style Reference.
  /// </summary>
  public ILinkedStyle? LinkedStyle { get ; set; }
  
  /// <summary>
  /// Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  public IAutoRedefine? AutoRedefine { get ; set; }
  
  /// <summary>
  /// Hide Style From User Interface.
  /// </summary>
  public IStyleHidden? StyleHidden { get ; set; }
  
  /// <summary>
  /// Optional User Interface Sorting Order.
  /// </summary>
  public Int32Value? UIPriority { get ; set; }
  
  /// <summary>
  /// Hide Style From Main User Interface.
  /// </summary>
  public ISemiHidden? SemiHidden { get ; set; }
  
  /// <summary>
  /// Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  public IUnhideWhenUsed? UnhideWhenUsed { get ; set; }
  
  /// <summary>
  /// Primary Style.
  /// </summary>
  public IPrimaryStyle? PrimaryStyle { get ; set; }
  
  /// <summary>
  /// Style Cannot Be Applied.
  /// </summary>
  public ILocked? Locked { get ; set; }
  
  /// <summary>
  /// E-Mail Message Text Style.
  /// </summary>
  public IPersonal? Personal { get ; set; }
  
  /// <summary>
  /// E-Mail Message Composition Style.
  /// </summary>
  public IPersonalCompose? PersonalCompose { get ; set; }
  
  /// <summary>
  /// E-Mail Message Reply Style.
  /// </summary>
  public IPersonalReply? PersonalReply { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Style Definition.
  /// </summary>
  public IRsid? Rsid { get ; set; }
  
  /// <summary>
  /// Style Paragraph Properties.
  /// </summary>
  public IStyleParagraphProperties? StyleParagraphProperties { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IStyleRunProperties? StyleRunProperties { get ; set; }
  
  /// <summary>
  /// Style Table Properties.
  /// </summary>
  public IStyleTableProperties? StyleTableProperties { get ; set; }
  
  /// <summary>
  /// Style Table Row Properties.
  /// </summary>
  public ITableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties { get ; set; }
  
  /// <summary>
  /// Style Table Cell Properties.
  /// </summary>
  public IStyleTableCellProperties? StyleTableCellProperties { get ; set; }
  
}
