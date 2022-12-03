namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFieldExtensionList Class.
/// </summary>
public interface CacheFieldExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<CacheFieldExtension>? CacheFieldExtensions { get ; set; }
  
}
