namespace DocumentModel.Wordprocessing;


/// <summary>
///   Suggested Filtering for List of Document Styles.
/// </summary>
public partial class StylePaneFormatFilter
{
  
  /// <summary>
  ///   val
  /// </summary>
  [SchemaAttr("w:val")]
  public DocumentModel.HexBinaryValue? Val { get; set; }
  
  
  /// <summary>
  ///   allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:allStyles")]
  public Boolean? AllStyles { get; set; }
  
  
  /// <summary>
  ///   customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:customStyles")]
  public Boolean? CustomStyles { get; set; }
  
  
  /// <summary>
  ///   latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:latentStyles")]
  public Boolean? LatentStyles { get; set; }
  
  
  /// <summary>
  ///   stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:stylesInUse")]
  public Boolean? StylesInUse { get; set; }
  
  
  /// <summary>
  ///   headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:headingStyles")]
  public Boolean? HeadingStyles { get; set; }
  
  
  /// <summary>
  ///   numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:numberingStyles")]
  public Boolean? NumberingStyles { get; set; }
  
  
  /// <summary>
  ///   tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:tableStyles")]
  public Boolean? TableStyles { get; set; }
  
  
  /// <summary>
  ///   directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:directFormattingOnRuns")]
  public Boolean? DirectFormattingOnRuns { get; set; }
  
  
  /// <summary>
  ///   directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:directFormattingOnParagraphs")]
  public Boolean? DirectFormattingOnParagraphs { get; set; }
  
  
  /// <summary>
  ///   directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:directFormattingOnNumbering")]
  public Boolean? DirectFormattingOnNumbering { get; set; }
  
  
  /// <summary>
  ///   directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:directFormattingOnTables")]
  public Boolean? DirectFormattingOnTables { get; set; }
  
  
  /// <summary>
  ///   clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:clearFormatting")]
  public Boolean? ClearFormatting { get; set; }
  
  
  /// <summary>
  ///   top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:top3HeadingStyles")]
  public Boolean? Top3HeadingStyles { get; set; }
  
  
  /// <summary>
  ///   visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:visibleStyles")]
  public Boolean? VisibleStyles { get; set; }
  
  
  /// <summary>
  ///   alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:alternateStyleNames")]
  public Boolean? AlternateStyleNames { get; set; }
  
}
