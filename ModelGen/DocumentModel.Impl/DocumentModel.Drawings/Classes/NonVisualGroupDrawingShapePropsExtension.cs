namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public class NonVisualGroupDrawingShapePropsExtensionImpl: ModelElementImpl, NonVisualGroupDrawingShapePropsExtension
{
  public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualGroupDrawingShapePropsExtensionImpl(): base() {}
  
  public NonVisualGroupDrawingShapePropsExtensionImpl(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.NonVisualGroupProperties? NonVisualGroupProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties>();
        if (item != null)
          return new DocumentModel.Drawings.NonVisualGroupPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.NonVisualGroupPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
