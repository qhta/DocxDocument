namespace DocumentModel.Interop;

/// <summary>
/// Represents a single built-in or user-defined style.
/// </summary>
public partial interface Style : InteropObject
{
  /// <summary>
  /// The name local.
  /// </summary>
  public string NameLocal { get; set; }

  /// <summary>
  /// The base style.
  /// </summary>
  public object BaseStyle { get; set; }

  /// <summary>
  /// The description.
  /// </summary>
  public string Description { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdStyleType Type { get; }

  /// <summary>
  /// The built in.
  /// </summary>
  public bool BuiltIn { get; }

  /// <summary>
  /// The next paragraph style.
  /// </summary>
  public object NextParagraphStyle { get; set; }

  /// <summary>
  /// The in use.
  /// </summary>
  public bool InUse { get; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  public Font Font { get; set; }

  /// <summary>
  /// The frame.
  /// </summary>
  public Frame Frame { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The automatically update.
  /// </summary>
  public bool AutomaticallyUpdate { get; set; }

  /// <summary>
  /// The list template.
  /// </summary>
  public ListTemplate ListTemplate { get; }

  /// <summary>
  /// The list level number.
  /// </summary>
  public int ListLevelNumber { get; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The hidden.
  /// </summary>
  public bool Hidden { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  public int NoProofing { get; set; }

  /// <summary>
  /// The link style.
  /// </summary>
  public object LinkStyle { get; set; }

  /// <summary>
  /// The visibility.
  /// </summary>
  public bool Visibility { get; set; }

  /// <summary>
  /// The no space between paragraphs of same style.
  /// </summary>
  public bool NoSpaceBetweenParagraphsOfSameStyle { get; set; }

  /// <summary>
  /// The table.
  /// </summary>
  public TableStyle Table { get; }

  /// <summary>
  /// The locked.
  /// </summary>
  public bool Locked { get; set; }

  /// <summary>
  /// The priority.
  /// </summary>
  public int Priority { get; set; }

  /// <summary>
  /// The unhide when used.
  /// </summary>
  public bool UnhideWhenUsed { get; set; }

  /// <summary>
  /// The quick style.
  /// </summary>
  public bool QuickStyle { get; set; }

  /// <summary>
  /// The linked.
  /// </summary>
  public bool Linked { get; }
}
