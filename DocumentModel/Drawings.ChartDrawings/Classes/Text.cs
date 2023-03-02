namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Text Class.
/// </summary>
public record Text
{
  /// <summary>
  ///   TextData.
  /// </summary>
  public TextData? TextData { get; set; }

  /// <summary>
  ///   RichTextBody.
  /// </summary>
  public RichTextBody? RichTextBody { get; set; }
}