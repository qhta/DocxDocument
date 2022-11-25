namespace DocumentModel.Office2021.Word.ExtensionList;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public interface IExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Uri { get ; set; }
  
}
