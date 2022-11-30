namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinitionExtensionList Class.
/// </summary>
public interface IPivotTableDefinitionExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotTableDefinitionExtension>? PivotTableDefinitionExtensions { get ; set; }
  
}
