namespace DocumentModel.Spreadsheet;

public interface IXmlCellProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? Id { get ; set; }
  
  public string? UniqueName { get ; set; }
  
  public IXmlProperties? XmlProperties { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
