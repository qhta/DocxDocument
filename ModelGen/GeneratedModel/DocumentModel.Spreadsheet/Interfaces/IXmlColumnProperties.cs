namespace DocumentModel.Spreadsheet;

public interface IXmlColumnProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? MapId { get ; set; }
  
  public string? XPath { get ; set; }
  
  public bool? Denormalized { get ; set; }
  
  public XmlData? XmlDataType { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
