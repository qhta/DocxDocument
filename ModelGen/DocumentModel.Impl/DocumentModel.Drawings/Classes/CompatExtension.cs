namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public class CompatExtensionImpl: ModelElementImpl, CompatExtension
{
  public DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ShapeId
  {
    get => (String?)OpenXmlElement?.ShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeId = (System.String?)value;
    }
  }
  
}
