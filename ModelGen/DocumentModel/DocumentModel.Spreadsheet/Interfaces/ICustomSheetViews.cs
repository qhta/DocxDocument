namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Sheet Views.
/// </summary>
public interface ICustomSheetViews // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICustomSheetView>? CustomSheetViews { get ; set; }
  
}
