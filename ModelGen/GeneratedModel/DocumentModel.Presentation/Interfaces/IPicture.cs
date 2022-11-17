namespace DocumentModel.Presentation;

public interface IPicture // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Presentation.INonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  public DocumentModel.Presentation.IBlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Presentation.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Presentation.IShapeStyle? ShapeStyle { get ; set; }
  
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
