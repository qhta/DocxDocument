namespace DocumentModel.Drawing;

/// <summary>
/// Dash Stop.
/// </summary>
public interface IDashStop // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Dash Length
  /// </summary>
  public Int32? DashLength { get ; set; }
  
  /// <summary>
  /// Space Length
  /// </summary>
  public Int32? SpaceLength { get ; set; }
  
}
