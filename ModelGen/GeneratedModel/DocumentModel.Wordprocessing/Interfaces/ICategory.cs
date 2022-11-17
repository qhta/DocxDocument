namespace DocumentModel.Wordprocessing;

public interface ICategory // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IName? Name { get ; set; }
  
  public DocumentModel.Wordprocessing.IGallery? Gallery { get ; set; }
  
}
