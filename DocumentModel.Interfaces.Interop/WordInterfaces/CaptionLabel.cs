namespace DocumentModel.Interop;

/// <summary>
/// Represents a single caption label.
/// </summary>
public partial interface CaptionLabel : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The built in.
  /// </summary>
  public bool BuiltIn { get; }

  /// <summary>
  /// The id.
  /// </summary>
  public WdCaptionLabelID ID { get; }

  /// <summary>
  /// The include chapter number.
  /// </summary>
  public bool IncludeChapterNumber { get; set; }

  /// <summary>
  /// The number style.
  /// </summary>
  public WdCaptionNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The chapter style level.
  /// </summary>
  public int ChapterStyleLevel { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  public WdSeparatorType Separator { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  public WdCaptionPosition Position { get; set; }
}
