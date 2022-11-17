namespace DocumentModel.Wordprocessing;

public interface ITablePropertiesChange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Author { get ; set; }
  
  public DateTime? Date { get ; set; }
  
  public string? Id { get ; set; }
  
  public IPreviousTableProperties? PreviousTableProperties { get ; set; }
  
}
