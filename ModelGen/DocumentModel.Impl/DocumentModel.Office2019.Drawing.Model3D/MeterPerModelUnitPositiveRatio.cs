namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the MeterPerModelUnitPositiveRatio Class.
/// </summary>
public class MeterPerModelUnitPositiveRatio: IMeterPerModelUnitPositiveRatio
{
  /// <summary>
  /// n, this property is only available in Office 2019 and later.
  /// </summary>
  public ulong? N
  {
    get;
    set;
  }
  
  /// <summary>
  /// d, this property is only available in Office 2019 and later.
  /// </summary>
  public ulong? D
  {
    get;
    set;
  }
  
}
