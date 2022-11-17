namespace DocumentModel.Spreadsheet;

public interface IXmlProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? MapId { get ; set; }
  
  public string? XPath { get ; set; }
  
  public XmlData? XmlDataType { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
