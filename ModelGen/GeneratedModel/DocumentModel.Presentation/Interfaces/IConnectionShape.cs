namespace DocumentModel.Presentation;

/// <summary>
/// Connection Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualConnectionShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
public interface IConnectionShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Connection Shape.
  /// </summary>
  public DocumentModel.Presentation.INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Presentation.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Connector Shape Style.
  /// </summary>
  public DocumentModel.Presentation.IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
