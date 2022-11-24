namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Axis Orientation.
/// </summary>
public interface IOrientation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Orientation Value
  /// </summary>
  public OrientationValues? Val { get ; set; }
  
}
