namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Text Class.
/// </summary>
public class Text: ModelElement
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