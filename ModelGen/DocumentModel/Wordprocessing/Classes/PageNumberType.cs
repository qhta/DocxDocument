namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageNumberType Class.
/// </summary>
public partial class PageNumberType
{
  
  /// <summary>
  ///   Page Number Format
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormatKind? Format { get; set; }
  
  
  /// <summary>
  ///   Starting Page Number
  /// </summary>
  public Int32? Start { get; set; }
  
  
  /// <summary>
  ///   Chapter Heading Style
  /// </summary>
  public Byte? ChapterStyle { get; set; }
  
  
  /// <summary>
  ///   Chapter Separator Character
  /// </summary>
  public DocumentModel.Wordprocessing.ChapterSeparatorKind? ChapterSeparator { get; set; }
  
}
