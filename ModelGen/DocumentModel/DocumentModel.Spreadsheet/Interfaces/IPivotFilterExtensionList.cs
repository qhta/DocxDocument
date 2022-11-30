namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilterExtensionList Class.
/// </summary>
public interface IPivotFilterExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotFilterExtension>? PivotFilterExtensions { get ; set; }
  
}
