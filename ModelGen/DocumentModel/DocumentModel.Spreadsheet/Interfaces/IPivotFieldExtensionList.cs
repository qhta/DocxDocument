namespace DocumentModel.Spreadsheet;

/// <summary>
/// Future Feature Data Storage Area.
/// </summary>
public interface IPivotFieldExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotFieldExtension>? PivotFieldExtensions { get ; set; }
  
}
