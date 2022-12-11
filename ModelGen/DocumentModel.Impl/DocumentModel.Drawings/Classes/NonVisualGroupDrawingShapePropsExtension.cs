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
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public NonVisualGroupProperties? NonVisualGroupProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
