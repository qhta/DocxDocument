namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Dash Stop.
/// </summary>
public class DashStop: ModelElement
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