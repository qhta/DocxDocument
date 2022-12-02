namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilterExtensionList Class.
/// </summary>
public interface IPivotFilterExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPivotFilterExtension>? PivotFilterExtensions { get ; set; }
  
}
