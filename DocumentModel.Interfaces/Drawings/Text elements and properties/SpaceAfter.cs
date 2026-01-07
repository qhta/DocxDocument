namespace DocumentModel.Drawings;

/// <summary>
///   Represents the space after a paragraph, allowing specification as a percentage or in points.
/// </summary>
public interface SpaceAfter
{
  /// <summary>
  ///   Space after the paragraph specified as a percentage.
  /// </summary>
  public Int32? SpacingPercent { get; set; }

  /// <summary>
  ///   Space after the paragraph specified in points.
  /// </summary>
  public Int32? SpacingPoints { get; set; }
}