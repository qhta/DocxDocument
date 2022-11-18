namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRsid))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAutoRedefine))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleHidden))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISemiHidden))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IUnhideWhenUsed))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPrimaryStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILocked))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPersonal))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPersonalCompose))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPersonalReply))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAliases))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBasedOn))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INextParagraphStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILinkedStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleName))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleTableProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableStyleProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleTableCellProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableStyleConditionalFormattingTableRowProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IUIPriority))]
public interface IStyle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style Type
  /// </summary>
  public DocumentModel.Wordprocessing.Style? Type { get ; set; }
  
  /// <summary>
  /// Style ID
  /// </summary>
  public string? StyleId { get ; set; }
  
  /// <summary>
  /// Default Style
  /// </summary>
  public bool? Default { get ; set; }
  
  /// <summary>
  /// User-Defined Style
  /// </summary>
  public bool? CustomStyle { get ; set; }
  
  /// <summary>
  /// Primary Style Name.
  /// </summary>
  public IStyleName? StyleName { get ; set; }
  
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
  public IUIPriority? UIPriority { get ; set; }
  
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
  public DocumentModel.Wordprocessing.ILocked? Locked { get ; set; }
  
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
