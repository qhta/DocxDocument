namespace DocumentModel.Drawings;

/// <summary>
///   Represents text spacing settings, allowing specification of spacing as a percentage or in points.
/// </summary>
public interface TextSpacingType
{
  /// <summary>
  ///   Spacing value specified as a percentage.
  /// </summary>
  public Int32? SpacingPercent { get; set; }

  /// <summary>
  ///   Spacing value specified in points.
  /// </summary>
  public Int32? SpacingPoints { get; set; }
}