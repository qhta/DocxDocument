namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Point.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IPtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ITextBody))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IPropertySet))]
public interface IPoint // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public string? ModelId { get ; set; }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public Point? Type { get ; set; }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public string? ConnectionId { get ; set; }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public IPropertySet? PropertySet { get ; set; }
  
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
  public IPtExtensionList? PtExtensionList { get ; set; }
  
}
