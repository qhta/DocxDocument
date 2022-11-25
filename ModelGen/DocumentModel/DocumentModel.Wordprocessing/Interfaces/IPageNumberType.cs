namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageNumberType Class.
/// </summary>
public interface IPageNumberType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Page Number Format
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormatKind? Format { get ; set; }
  
  /// <summary>
  /// Starting Page Number
  /// </summary>
  public System.Int32? Start { get ; set; }
  
  /// <summary>
  /// Chapter Heading Style
  /// </summary>
  public System.Byte? ChapterStyle { get ; set; }
  
  /// <summary>
  /// Chapter Separator Character
  /// </summary>
  public DocumentModel.Wordprocessing.ChapterSeparatorKind? ChapterSeparator { get ; set; }
  
}
