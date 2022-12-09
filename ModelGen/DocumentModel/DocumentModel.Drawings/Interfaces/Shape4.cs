namespace DocumentModel.Drawings;

/// <summary>
/// Shape Definition.
/// </summary>
public interface Shape4
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
  public NonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public ShapeProperties7? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public Style4? Style { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public TextBody2? TextBody { get ; set; }
  
}
