namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Definition.
/// </summary>
public interface IStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style Type
  /// </summary>
  public DocumentModel.Wordprocessing.StyleKind? Type { get ; set; }
  
  /// <summary>
  /// Style ID
  /// </summary>
  public System.String? StyleId { get ; set; }
  
  /// <summary>
  /// Default Style
  /// </summary>
  public System.Boolean? Default { get ; set; }
  
  /// <summary>
  /// User-Defined Style
  /// </summary>
  public System.Boolean? CustomStyle { get ; set; }
  
  /// <summary>
  /// Primary Style Name.
  /// </summary>
  public System.String? StyleName { get ; set; }
  
  /// <summary>
  /// Alternate Style Names.
  /// </summary>
  public System.String? Aliases { get ; set; }
  
  /// <summary>
  /// Parent Style ID.
  /// </summary>
  public System.String? BasedOn { get ; set; }
  
  /// <summary>
  /// Style For Next Paragraph.
  /// </summary>
  public System.String? NextParagraphStyle { get ; set; }
  
  /// <summary>
  /// Linked Style Reference.
  /// </summary>
  public System.String? LinkedStyle { get ; set; }
  
  /// <summary>
  /// Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? AutoRedefine { get ; set; }
  
  /// <summary>
  /// Hide Style From User Interface.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? StyleHidden { get ; set; }
  
  /// <summary>
  /// Optional User Interface Sorting Order.
  /// </summary>
  public System.Int32? UIPriority { get ; set; }
  
  /// <summary>
  /// Hide Style From Main User Interface.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? SemiHidden { get ; set; }
  
  /// <summary>
  /// Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? UnhideWhenUsed { get ; set; }
  
  /// <summary>
  /// Primary Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? PrimaryStyle { get ; set; }
  
  /// <summary>
  /// Style Cannot Be Applied.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? Locked { get ; set; }
  
  /// <summary>
  /// E-Mail Message Text Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? Personal { get ; set; }
  
  /// <summary>
  /// E-Mail Message Composition Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? PersonalCompose { get ; set; }
  
  /// <summary>
  /// E-Mail Message Reply Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? PersonalReply { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Style Definition.
  /// </summary>
  public DocumentModel.BaseTypes.HexWord? Rsid { get ; set; }
  
  /// <summary>
  /// Style Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IStyleParagraphProperties? StyleParagraphProperties { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IStyleRunProperties? StyleRunProperties { get ; set; }
  
  /// <summary>
  /// Style Table Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IStyleTableProperties? StyleTableProperties { get ; set; }
  
  /// <summary>
  /// Style Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties { get ; set; }
  
  /// <summary>
  /// Style Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IStyleTableCellProperties? StyleTableCellProperties { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ITableStyleProperties>? TableStylePropertieses { get ; set; }
  
}
