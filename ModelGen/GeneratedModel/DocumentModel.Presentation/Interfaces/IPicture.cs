namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Picture Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualPictureProperties))]
public interface IPicture // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Picture.
  /// </summary>
  public DocumentModel.Presentation.INonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Presentation.IBlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Presentation.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Presentation.IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
