namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the DataModelExtensionBlock Class.
/// </summary>
public partial class DataModelExtensionBlockImpl: ModelElementImpl, DataModelExtensionBlock
{
  public DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataModelExtensionBlockImpl(): base() {}
  
  public DataModelExtensionBlockImpl(DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// relId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelId
  {
    get => (System.String?)OpenXmlElement?.RelId?.Value;
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
    get => (System.String?)OpenXmlElement?.MinVer?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinVer = (System.String?)value;
    }
  }
  
}
