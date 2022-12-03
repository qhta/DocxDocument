namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheDefinitionExtensionList Class.
/// </summary>
public interface PivotCacheDefinitionExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<PivotCacheDefinitionExtension>? PivotCacheDefinitionExtensions { get ; set; }
  
}
