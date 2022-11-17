namespace DocumentModel.Wordprocessing;

public interface IDeleted // : DocumentFormat.OpenXml.Wordprocessing.TrackChangeType
{
  public string? Author { get ; set; }

  public DateTime? Date { get ; set; }

  public string? Id { get ; set; }

}
