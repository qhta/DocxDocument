namespace DocumentModel.Wordprocessing;

public interface IParagraphPropertiesChange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Author { get ; set; }

  public DateTime? Date { get ; set; }

  public string? Id { get ; set; }

  public IParagraphPropertiesExtended? ParagraphPropertiesExtended { get ; set; }

}
