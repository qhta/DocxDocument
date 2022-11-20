namespace DocumentModel.Vml;

/// <summary>
/// Shape Handle.
/// </summary>
public class ShapeHandle: IShapeHandle
{
  /// <summary>
  /// Handle Position
  /// </summary>
  public string? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  public string? Polar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  public string? Map
  {
    get;
    set;
  }
  
  /// <summary>
  /// Invert Handle's X Position
  /// </summary>
  public ITrueFalseBlankValue? InvertX
  {
    get;
    set;
  }
  
  /// <summary>
  /// Invert Handle's Y Position
  /// </summary>
  public ITrueFalseBlankValue? InvertY
  {
    get;
    set;
  }
  
  /// <summary>
  /// Handle Inversion Toggle
  /// </summary>
  public ITrueFalseBlankValue? Switch
  {
    get;
    set;
  }
  
  /// <summary>
  /// Handle X Position Range
  /// </summary>
  public string? XRange
  {
    get;
    set;
  }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  public string? YRange
  {
    get;
    set;
  }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  public string? RadiusRange
  {
    get;
    set;
  }
  
}
