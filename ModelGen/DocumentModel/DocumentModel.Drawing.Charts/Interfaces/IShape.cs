namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape Value
  /// </summary>
  public ShapeValues? Val { get ; set; }
  
}
