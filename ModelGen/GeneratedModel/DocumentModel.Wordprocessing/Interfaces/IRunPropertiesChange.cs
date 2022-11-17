namespace DocumentModel.Wordprocessing;

public interface IRunPropertiesChange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Author { get ; set; }

  public DateTime? Date { get ; set; }

  public string? Id { get ; set; }

  public IPreviousRunProperties? PreviousRunProperties { get ; set; }

}
