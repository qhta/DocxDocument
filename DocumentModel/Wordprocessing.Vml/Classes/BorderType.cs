namespace DocumentModel.Wordprocessing.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BorderType Class.
/// </summary>
public class BorderType: ModelElement
{
  /// <summary>
  ///   IBorder IStyle
  /// </summary>
  public BorderKind? Type { get; set; }

  /// <summary>
  ///   IBorder Width
  /// </summary>
  public Int64? Width { get; set; }

  /// <summary>
  ///   IBorder shadow
  /// </summary>
  public bool? Shadow { get; set; }
}
