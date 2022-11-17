namespace DocumentModel.Presentation;

public interface INotesTextViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ICommonViewProperties? CommonViewProperties { get ; set; }

  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }

}
