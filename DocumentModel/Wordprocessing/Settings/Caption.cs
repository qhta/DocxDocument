namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  ///   Include Chapter Number Iin IField Ifor Caption
  /// </summary>
  public bool? ChapterNumber { get; set; }

  /// <summary>
  ///   IStyle Ifor Chapter Headings
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
  ///   Chapter Number/Item IIndex Separator
  /// </summary>
  public ChapterSeparatorKind? Separator { get; set; }
}
