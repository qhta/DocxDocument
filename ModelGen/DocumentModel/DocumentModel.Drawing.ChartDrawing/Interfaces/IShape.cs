namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Shape Definition.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public INonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public IStyle? Style { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public ITextBody? TextBody { get ; set; }
  
}
