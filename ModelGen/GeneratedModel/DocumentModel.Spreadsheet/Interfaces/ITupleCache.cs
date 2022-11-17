namespace DocumentModel.Spreadsheet;

public interface ITupleCache // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IEntries? Entries { get ; set; }
  
  public ISets? Sets { get ; set; }
  
  public IQueryCache? QueryCache { get ; set; }
  
  public IServerFormats? ServerFormats { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
