namespace DocumentModel.Presentation;

public interface INotesMasterId // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }

  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }

}
