namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataModelExtensionBlock Class.
/// </summary>
public interface IDataModelExtensionBlock // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// relId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? RelId { get ; set; }
  
  /// <summary>
  /// minVer, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? MinVer { get ; set; }
  
}
