namespace DocumentModel.Presentation;

public interface IHeaderFooter // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? SlideNumber { get ; set; }
  
  public bool? Header { get ; set; }
  
  public bool? Footer { get ; set; }
  
  public bool? DateTime { get ; set; }
  
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
