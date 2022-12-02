namespace DocumentModel.Presentation;

/// <summary>
/// Shape.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Use Background Fill
  /// </summary>
  public Boolean? UseBackgroundFill { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Shape.
  /// </summary>
  public INonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public ITextBody? TextBody { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
