namespace DocumentModel.Office2010.PowerPoint;

public interface ITriggerEventRecord // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public TriggerEvent? Type { get ; set; }
  
  public string? Time { get ; set; }
  
  public uint? ObjectId { get ; set; }
  
}
