namespace DocumentModel.Office2010.PowerPoint;

public interface IPlayEventRecord // : DocumentFormat.OpenXml.Office2010.PowerPoint.MediaPlaybackEventRecordType
{
  public string? Time { get ; set; }

  public uint? ObjectId { get ; set; }

}
