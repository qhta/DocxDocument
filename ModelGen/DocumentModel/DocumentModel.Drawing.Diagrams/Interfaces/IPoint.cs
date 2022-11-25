namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Point.
/// </summary>
public interface IPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public System.String? ModelId { get ; set; }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public DocumentModel.Drawing.Diagrams.PointKind? Type { get ; set; }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public System.String? ConnectionId { get ; set; }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IPropertySet? PropertySet { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ITextBody? TextBody { get ; set; }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PtExtensionList { get ; set; }
  
}
