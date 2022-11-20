namespace DocumentModel.Drawing;

/// <summary>
/// Dash Stop.
/// </summary>
public class DashStop: IDashStop
{
  /// <summary>
  /// Dash Length
  /// </summary>
  public int? DashLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// Space Length
  /// </summary>
  public int? SpaceLength
  {
    get;
    set;
  }
  
}
