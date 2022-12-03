namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFieldExtensionList Class.
/// </summary>
public interface DataFieldExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<DataFieldExtension>? DataFieldExtensions { get ; set; }
  
}
