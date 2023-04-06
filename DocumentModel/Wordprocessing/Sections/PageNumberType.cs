namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageNumberType Class.
/// </summary>
public class PageNumberType: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   Page Number Format
  /// </summary>
  public NumberFormatKind? Format { get; set; }

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
  public ChapterSeparatorKind? ChapterSeparator { get; set; }
}