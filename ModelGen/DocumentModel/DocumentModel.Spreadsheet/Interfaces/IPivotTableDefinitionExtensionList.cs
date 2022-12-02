namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinitionExtensionList Class.
/// </summary>
public interface IPivotTableDefinitionExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPivotTableDefinitionExtension>? PivotTableDefinitionExtensions { get ; set; }
  
}
