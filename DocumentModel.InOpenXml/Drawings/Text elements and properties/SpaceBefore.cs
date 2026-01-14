namespace DocumentModel.Drawings;

/// <summary>
///   Represents the space before a paragraph, allowing specification as a percentage or in points.
/// </summary>
public class SpaceBefore: ModelElement
{
  /// <summary>
  ///   Space before the paragraph specified as a percentage.
  /// </summary>
  public Int32? SpacingPercent { get; set; }

  /// <summary>
  ///   Space before the paragraph specified in points.
  /// </summary>
  public Int32? SpacingPoints { get; set; }
}