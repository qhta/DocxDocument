namespace DocumentModel.Spreadsheet;

public interface IWebPublishing // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? UseCss { get ; set; }
  
  public bool? Thicket { get ; set; }
  
  public bool? LongFileNames { get ; set; }
  
  public bool? UseVml { get ; set; }
  
  public bool? AllowPng { get ; set; }
  
  public DocumentModel.Spreadsheet.TargetScreenSize? TargetScreenSize { get ; set; }
  
  public uint? Dpi { get ; set; }
  
  public uint? CodePage { get ; set; }
  
  public string? CharacterSet { get ; set; }
  
}
