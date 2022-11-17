namespace DocumentModel.Presentation;

public interface IOutlineViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ICommonViewProperties? CommonViewProperties { get ; set; }
  
  public IOutlineViewSlideList? OutlineViewSlideList { get ; set; }
  
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
