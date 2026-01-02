namespace DocumentModel.Wordprocessing;

/// <summary>
///   Single Caption Type Definition.
/// </summary>
public class Caption: ModelElement
{
  /// <summary>
  ///   Caption Type Name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Automatic Caption Placement
  /// </summary>
  public CaptionPositionKind? Position { get; set; }
  /// <summary>
  ///   Include Chapter Number in Field for Caption
  /// </summary>
  public bool? ChapterNumber { get; set; }
  /// <summary>
  ///   Style for Chapter Headings
  /// </summary>
  public Int32? Heading { get; set; }
  /// <summary>
  ///   Do Not Include Name In Caption
  /// </summary>
  public bool? NoLabel { get; set; }
  /// <summary>
  ///   Caption Numbering Format
  /// </summary>
  public NumberFormatKind? NumberFormat { get; set; }
  /// <summary>
  ///   Chapter Number/Item Index Separator
  /// </summary>
  public ChapterSeparatorKind? Separator { get; set; }
}