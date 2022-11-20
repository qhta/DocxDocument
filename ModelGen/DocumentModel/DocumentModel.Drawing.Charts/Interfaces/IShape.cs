namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public interface IShape // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape Value
  /// </summary>
  public ShapeValues? Val { get ; set; }
  
}
