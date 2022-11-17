namespace DocumentModel.Drawing.Charts;

public interface INumberingFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? FormatCode { get ; set; }
  
  public bool? SourceLinked { get ; set; }
  
}
