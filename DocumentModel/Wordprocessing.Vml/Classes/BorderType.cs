namespace DocumentModel.Wordprocessing.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BorderType Class.
/// </summary>
public class BorderType: ModelElement
{
  /// <summary>
  ///   Border Style
  /// </summary>
  public BorderKind? Type { get; set; }

  /// <summary>
  ///   Border Width
  /// </summary>
  public Int64? Width { get; set; }

  /// <summary>
  ///   Border shadow
  /// </summary>
  public Boolean? Shadow { get; set; }
}