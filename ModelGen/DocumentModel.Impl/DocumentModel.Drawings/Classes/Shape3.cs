namespace DocumentModel.Drawings;

/// <summary>
/// Shape Definition.
/// </summary>
public class Shape3Impl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>, Shape3
{
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  public NonVisualShapeProperties? NonVisualShapeProperties
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
  /// Shape Style.
  /// </summary>
  public Style4? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public TextBody3? TextBody
  {
    get;
    set;
  }
  
}
