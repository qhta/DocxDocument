namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Axis Orientation.
/// </summary>
public interface IOrientation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Orientation Value
  /// </summary>
  public DocumentModel.Drawing.Charts.OrientationValues? Val { get ; set; }
  
}
