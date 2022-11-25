namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public interface IWebExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// appRef, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? ApplicationReference { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Formula { get ; set; }
  
}
