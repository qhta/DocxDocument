namespace DocumentModel.Presentation;

public interface ISorterViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? ShowFormatting { get ; set; }
  
  public ICommonViewProperties? CommonViewProperties { get ; set; }
  
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
