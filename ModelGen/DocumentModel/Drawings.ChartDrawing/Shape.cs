namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Shape Definition.
/// </summary>
public partial class Shape
{
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public String? Macro { get; set; }
  
  
  /// <summary>
  ///   Text Link
  /// </summary>
  public String? TextLink { get; set; }
  
  
  /// <summary>
  ///   Lock Text
  /// </summary>
  public Boolean? LockText { get; set; }
  
  
  /// <summary>
  ///   Publish to Server
  /// </summary>
  public Boolean? Published { get; set; }
  
  
  /// <summary>
  ///   Non-Visual Shape Properties.
  /// </summary>
  public DMDCD.NonVisualShapeProperties? NonVisualShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public DMDCD.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Shape Style.
  /// </summary>
  public DMDCD.Style? Style { get; set; }
  
  
  /// <summary>
  ///   Shape Text Body.
  /// </summary>
  public DMDCD.TextBody? TextBody { get; set; }
  
}
