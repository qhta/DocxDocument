namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataModelExtensionBlock Class.
/// </summary>
public class DataModelExtensionBlockImpl: ModelElementImpl, DataModelExtensionBlock
{
  public DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// relId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelId
  {
    get => (String?)OpenXmlElement?.RelId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// minVer, this property is only available in Office 2010 and later.
  /// </summary>
  public String? MinVer
  {
    get => (String?)OpenXmlElement?.MinVer?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinVer = (System.String?)value;
    }
  }
  
}
