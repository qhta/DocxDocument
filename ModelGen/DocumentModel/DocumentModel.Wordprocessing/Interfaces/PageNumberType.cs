namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageNumberType Class.
/// </summary>
public interface PageNumberType
{
  /// <summary>
  /// Page Number Format
  /// </summary>
  public NumberFormatKind? Format { get ; set; }
  
  /// <summary>
  /// Starting Page Number
  /// </summary>
  public Int32? Start { get ; set; }
  
  /// <summary>
  /// Chapter Heading Style
  /// </summary>
  public Byte? ChapterStyle { get ; set; }
  
  /// <summary>
  /// Chapter Separator Character
  /// </summary>
  public ChapterSeparatorKind? ChapterSeparator { get ; set; }
  
}
