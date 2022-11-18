namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the DataModelExtensionBlock Class.
/// </summary>
public interface IDataModelExtensionBlock // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// relId, this property is only available in Office 2010 and later.
  /// </summary>
  public string? RelId { get ; set; }
  
  /// <summary>
  /// minVer, this property is only available in Office 2010 and later.
  /// </summary>
  public string? MinVer { get ; set; }
  
}
