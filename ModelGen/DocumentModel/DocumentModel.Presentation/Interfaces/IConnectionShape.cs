namespace DocumentModel.Presentation;

/// <summary>
/// Connection Shape.
/// </summary>
public interface IConnectionShape // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public DocumentModel.Presentation.IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
