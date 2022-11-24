namespace DocumentModel.Presentation;

/// <summary>
/// Connection Shape.
/// </summary>
public interface IConnectionShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Connection Shape.
  /// </summary>
  public INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Connector Shape Style.
  /// </summary>
  public IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
