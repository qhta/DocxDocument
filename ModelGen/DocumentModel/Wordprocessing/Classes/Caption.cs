namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Caption Type Definition.
/// </summary>
public partial class Caption
{
  
  /// <summary>
  ///   Caption Type Name
  /// </summary>
  [SchemaAttr("w:name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Automatic Caption Placement
  /// </summary>
  [SchemaAttr("w:pos")]
  public DocumentModel.Wordprocessing.CaptionPositionValues? Position { get; set; }
  
  
  /// <summary>
  ///   Include Chapter Number in Field for Caption
  /// </summary>
  [SchemaAttr("w:chapNum")]
  public Boolean? ChapterNumber { get; set; }
  
  
  /// <summary>
  ///   Style for Chapter Headings
  /// </summary>
  [SchemaAttr("w:heading")]
  public Int32? Heading { get; set; }
  
  
  /// <summary>
  ///   Do Not Include Name In Caption
  /// </summary>
  [SchemaAttr("w:noLabel")]
  public Boolean? NoLabel { get; set; }
  
  
  /// <summary>
  ///   Caption Numbering Format
  /// </summary>
  [SchemaAttr("w:numFmt")]
  public DocumentModel.Wordprocessing.NumberFormatValues? NumberFormat { get; set; }
  
  
  /// <summary>
  ///   Chapter Number/Item Index Separator
  /// </summary>
  [SchemaAttr("w:sep")]
  public DocumentModel.Wordprocessing.ChapterSeparatorValues? Separator { get; set; }
  
}
