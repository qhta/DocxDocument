namespace DocumentModel.Drawings;

/// <summary>
///   Dash Stop.
/// </summary>
public record DashStop
{
  /// <summary>
  ///   Dash Length
  /// </summary>
  public Int32? DashLength { get; set; }

  /// <summary>
  ///   Space Length
  /// </summary>
  public Int32? SpaceLength { get; set; }
}