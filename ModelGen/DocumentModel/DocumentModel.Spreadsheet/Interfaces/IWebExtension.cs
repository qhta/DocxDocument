namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public interface IWebExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// appRef, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ApplicationReference { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
}
