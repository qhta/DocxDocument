namespace DocumentModel.Drawings;

/// <summary>
/// Connection Shape.
/// </summary>
public class ConnectionShape
{
  /// <summary>
  /// Connector Non Visual Properties.
  /// </summary>
  public NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public ShapeProperties7? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  public Style4? Style
  {
    get;
    set;
  }
  
}
