namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheDefinitionExtensionList Class.
/// </summary>
public interface IPivotCacheDefinitionExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPivotCacheDefinitionExtension>? PivotCacheDefinitionExtensions { get ; set; }
  
}
