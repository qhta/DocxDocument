namespace DocumentModel.Spreadsheet;

/// <summary>
/// Future Feature Data Storage Area.
/// </summary>
public interface IPivotFieldExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPivotFieldExtension>? PivotFieldExtensions { get ; set; }
  
}
