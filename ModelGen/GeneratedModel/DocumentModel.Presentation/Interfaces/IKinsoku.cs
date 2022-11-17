namespace DocumentModel.Presentation;

public interface IKinsoku // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Language { get ; set; }
  
  public string? InvalidStartChars { get ; set; }
  
  public string? InvalidEndChars { get ; set; }
  
}
