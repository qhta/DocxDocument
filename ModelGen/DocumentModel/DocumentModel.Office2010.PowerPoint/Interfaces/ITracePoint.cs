namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the TracePoint Class.
/// </summary>
public interface ITracePoint // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Time { get ; set; }
  
  /// <summary>
  /// x, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? XCoordinate { get ; set; }
  
  /// <summary>
  /// y, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? YCoordinate { get ; set; }
  
}
