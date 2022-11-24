namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Point.
/// </summary>
public interface IPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public String? ModelId { get ; set; }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public PointValues? Type { get ; set; }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public String? ConnectionId { get ; set; }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public IPropertySet? PropertySet { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public ITextBody? TextBody { get ; set; }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public IPtExtensionList? PtExtensionList { get ; set; }
  
}
