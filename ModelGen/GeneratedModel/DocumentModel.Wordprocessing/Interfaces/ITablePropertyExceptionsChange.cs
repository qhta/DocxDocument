namespace DocumentModel.Wordprocessing;

public interface ITablePropertyExceptionsChange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Author { get ; set; }
  
  public DateTime? Date { get ; set; }
  
  public string? Id { get ; set; }
  
  public IPreviousTablePropertyExceptions? PreviousTablePropertyExceptions { get ; set; }
  
}
