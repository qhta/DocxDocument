namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NamedSheetViews Class.
/// </summary>
public interface INamedSheetViews // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<INamedSheetView>? NamedSheetViews { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
