namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the IgnoredErrors Class.
/// </summary>
public interface IIgnoredErrors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IIgnoredError>? IgnoredErrors { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
