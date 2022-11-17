namespace DocumentModel.Office2010.PowerPoint;

public interface ISeekEventRecord // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Time { get ; set; }
  
  public uint? ObjectId { get ; set; }
  
  public string? Seek { get ; set; }
  
}
