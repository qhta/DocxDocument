namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Connection Shape.
/// </summary>
public interface IConnectionShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Connection Shape.
  /// </summary>
  public INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
  /// <summary>
  /// Connector Shape Properties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public IShapeStyle? ShapeStyle { get ; set; }
  
}
