namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CameraTool Class.
/// </summary>
public interface ICameraTool // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? CellRange { get ; set; }
  
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
}
