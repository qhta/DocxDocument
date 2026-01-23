namespace DocumentModel.Wordprocessing;

public abstract class IdentifiedChange<T> : ModelElement<T>, IIdentifiedChange where T : DX.OpenXmlElement
{
  public string? Id { get; set; }
  public string? Author { get; set; }
  public DateTime? Date { get; set; }
}