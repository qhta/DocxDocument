namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageNumberType Class.
/// </summary>
public partial class PageNumberType
{
  
  /// <summary>
  ///   Page Number Format
  /// </summary>
  [SchemaAttr("w:fmt")]
  public DocumentModel.Wordprocessing.NumberFormatValues? Format { get; set; }
  
  
  /// <summary>
  ///   Starting Page Number
  /// </summary>
  [SchemaAttr("w:start")]
  public Int32? Start { get; set; }
  
  
  /// <summary>
  ///   Chapter Heading Style
  /// </summary>
  [SchemaAttr("w:chapStyle")]
  public Byte? ChapterStyle { get; set; }
  
  
  /// <summary>
  ///   Chapter Separator Character
  /// </summary>
  [SchemaAttr("w:chapSep")]
  public DocumentModel.Wordprocessing.ChapterSeparatorValues? ChapterSeparator { get; set; }
  
}
