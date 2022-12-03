namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableExtensionList Class.
/// </summary>
public interface QueryTableExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<QueryTableExtension>? QueryTableExtensions { get ; set; }
  
}
