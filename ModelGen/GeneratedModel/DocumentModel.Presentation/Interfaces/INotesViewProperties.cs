namespace DocumentModel.Presentation;

public interface INotesViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ICommonSlideViewProperties? CommonSlideViewProperties { get ; set; }

  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }

}
