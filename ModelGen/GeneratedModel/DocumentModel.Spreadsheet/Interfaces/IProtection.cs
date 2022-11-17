namespace DocumentModel.Spreadsheet;

public interface IProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? Locked { get ; set; }
  
  public bool? Hidden { get ; set; }
  
}
