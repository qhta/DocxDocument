namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Definition.
/// </summary>
public class Style
{
  /// <summary>
  /// Style Type
  /// </summary>
  public StyleKind? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  public OnOffOnlyKind? AutoRedefine
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Style From User Interface.
  /// </summary>
  public OnOffOnlyKind? StyleHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Style From Main User Interface.
  /// </summary>
  public OnOffOnlyKind? SemiHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  public OnOffOnlyKind? UnhideWhenUsed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Primary Style.
  /// </summary>
  public OnOffOnlyKind? PrimaryStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Cannot Be Applied.
  /// </summary>
  public OnOffOnlyKind? Locked
  {
    get;
    set;
  }
  
  /// <summary>
  /// E-Mail Message Text Style.
  /// </summary>
  public OnOffOnlyKind? Personal
  {
    get;
    set;
  }
  
  /// <summary>
  /// E-Mail Message Composition Style.
  /// </summary>
  public OnOffOnlyKind? PersonalCompose
  {
    get;
    set;
  }
  
  /// <summary>
  /// E-Mail Message Reply Style.
  /// </summary>
  public OnOffOnlyKind? PersonalReply
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Paragraph Properties.
  /// </summary>
  public StyleParagraphProperties? StyleParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public StyleRunProperties? StyleRunProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Table Properties.
  /// </summary>
  public StyleTableProperties? StyleTableProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Table Row Properties.
  /// </summary>
  public TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Table Cell Properties.
  /// </summary>
  public StyleTableCellProperties? StyleTableCellProperties
  {
    get;
    set;
  }
  
}
