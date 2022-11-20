namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the TracePoint Class.
/// </summary>
public class TracePoint: ITracePoint
{
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Time
  {
    get;
    set;
  }
  
  /// <summary>
  /// x, this property is only available in Office 2010 and later.
  /// </summary>
  public long? XCoordinate
  {
    get;
    set;
  }
  
  /// <summary>
  /// y, this property is only available in Office 2010 and later.
  /// </summary>
  public long? YCoordinate
  {
    get;
    set;
  }
  
}
