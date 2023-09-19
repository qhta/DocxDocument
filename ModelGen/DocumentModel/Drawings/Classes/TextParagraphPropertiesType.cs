namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextParagraphPropertiesType Class.
/// </summary>
public partial class TextParagraphPropertiesType
{
  
  /// <summary>
  ///   Left Margin
  /// </summary>
  [SchemaAttr("marL")]
  public Int32? LeftMargin { get; set; }
  
  
  /// <summary>
  ///   Right Margin
  /// </summary>
  [SchemaAttr("marR")]
  public Int32? RightMargin { get; set; }
  
  
  /// <summary>
  ///   Level
  /// </summary>
  [SchemaAttr("lvl")]
  public Int32? Level { get; set; }
  
  
  /// <summary>
  ///   Indent
  /// </summary>
  [SchemaAttr("indent")]
  public Int32? Indent { get; set; }
  
  
  /// <summary>
  ///   Alignment
  /// </summary>
  [SchemaAttr("algn")]
  public DocumentModel.Drawings.TextAlignmentTypeValues? Alignment { get; set; }
  
  
  /// <summary>
  ///   Default Tab Size
  /// </summary>
  [SchemaAttr("defTabSz")]
  public Int32? DefaultTabSize { get; set; }
  
  
  /// <summary>
  ///   Right To Left
  /// </summary>
  [SchemaAttr("rtl")]
  public Boolean? RightToLeft { get; set; }
  
  
  /// <summary>
  ///   East Asian Line Break
  /// </summary>
  [SchemaAttr("eaLnBrk")]
  public Boolean? EastAsianLineBreak { get; set; }
  
  
  /// <summary>
  ///   Font Alignment
  /// </summary>
  [SchemaAttr("fontAlgn")]
  public DocumentModel.Drawings.TextFontAlignmentValues? FontAlignment { get; set; }
  
  
  /// <summary>
  ///   Latin Line Break
  /// </summary>
  [SchemaAttr("latinLnBrk")]
  public Boolean? LatinLineBreak { get; set; }
  
  
  /// <summary>
  ///   Hanging Punctuation
  /// </summary>
  [SchemaAttr("hangingPunct")]
  public Boolean? Height { get; set; }
  
  
  /// <summary>
  ///   Line Spacing.
  /// </summary>
  public DocumentModel.Drawings.LineSpacing? LineSpacing { get; set; }
  
  
  /// <summary>
  ///   Space Before.
  /// </summary>
  public DocumentModel.Drawings.SpaceBefore? SpaceBefore { get; set; }
  
  
  /// <summary>
  ///   Space After.
  /// </summary>
  public DocumentModel.Drawings.SpaceAfter? SpaceAfter { get; set; }
  
}
