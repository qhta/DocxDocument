namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Shape Definition.
/// </summary>
public interface Shape
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Text Link
  /// </summary>
  public String? TextLink { get ; set; }
  
  /// <summary>
  /// Lock Text
  /// </summary>
  public Boolean? LockText { get ; set; }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawings.Charts.Style? Style { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextBody? TextBody { get ; set; }
  
}
