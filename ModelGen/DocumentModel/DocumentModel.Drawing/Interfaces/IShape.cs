namespace DocumentModel.Drawing;

/// <summary>
/// Shape Definition.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public System.String? Macro { get ; set; }
  
  /// <summary>
  /// Text Link
  /// </summary>
  public System.String? TextLink { get ; set; }
  
  /// <summary>
  /// Lock Text
  /// </summary>
  public System.Boolean? LockText { get ; set; }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.IStyle? Style { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public DocumentModel.Drawing.ITextBody? TextBody { get ; set; }
  
}
