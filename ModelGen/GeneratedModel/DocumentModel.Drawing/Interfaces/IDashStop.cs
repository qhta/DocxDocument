namespace DocumentModel.Drawing;

/// <summary>
/// Dash Stop.
/// </summary>
public interface IDashStop // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Dash Length
  /// </summary>
  public int? DashLength { get ; set; }
  
  /// <summary>
  /// Space Length
  /// </summary>
  public int? SpaceLength { get ; set; }
  
}
