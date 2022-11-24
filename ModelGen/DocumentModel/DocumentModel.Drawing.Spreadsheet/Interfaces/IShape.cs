namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Shape.
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
  /// Lock Text Flag
  /// </summary>
  public Boolean? LockText { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Shape.
  /// </summary>
  public INonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public ITextBody? TextBody { get ; set; }
  
}
