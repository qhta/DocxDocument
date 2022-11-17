namespace DocumentModel.InkML;

public interface ITimestamp // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Id { get ; set; }

  public decimal? Time { get ; set; }

  public string? TimestampRef { get ; set; }

  public DateTime? TimeString { get ; set; }

  public decimal? TimeOffset { get ; set; }

}
