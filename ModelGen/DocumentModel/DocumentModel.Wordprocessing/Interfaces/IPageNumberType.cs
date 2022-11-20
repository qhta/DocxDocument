namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageNumberType Class.
/// </summary>
public interface IPageNumberType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Page Number Format
  /// </summary>
  public NumberFormatValues? Format { get ; set; }
  
  /// <summary>
  /// Starting Page Number
  /// </summary>
  public int? Start { get ; set; }
  
  /// <summary>
  /// Chapter Heading Style
  /// </summary>
  public byte? ChapterStyle { get ; set; }
  
  /// <summary>
  /// Chapter Separator Character
  /// </summary>
  public ChapterSeparatorValues? ChapterSeparator { get ; set; }
  
}
