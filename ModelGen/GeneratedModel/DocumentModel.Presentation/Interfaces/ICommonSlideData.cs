namespace DocumentModel.Presentation;

public interface ICommonSlideData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Name { get ; set; }

  public DocumentModel.Presentation.IBackground? Background { get ; set; }

  public DocumentModel.Presentation.IShapeTree? ShapeTree { get ; set; }

  public ICustomerDataList? CustomerDataList { get ; set; }

  public IControlList? ControlList { get ; set; }

  public ICommonSlideDataExtensionList? CommonSlideDataExtensionList { get ; set; }

}
