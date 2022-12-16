namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
public class ConnectorLockingExtensionImpl: ModelElementImpl, ConnectorLockingExtension
{
  public DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConnectorLockingExtensionImpl(): base() {}
  
  public ConnectorLockingExtensionImpl(DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Graphic? Graphic
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
        if (item != null)
          return new DocumentModel.Drawings.GraphicImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GraphicImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
