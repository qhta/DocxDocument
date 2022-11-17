namespace DocumentModel.Office2021.PowerPoint.Comment;

public interface ITextBodyType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IBodyProperties? BodyProperties { get ; set; }
  
  public IListStyle? ListStyle { get ; set; }
  
}
