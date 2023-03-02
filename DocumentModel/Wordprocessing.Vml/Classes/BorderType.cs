namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
///   Defines the BorderType Class.
/// </summary>
public record BorderType
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