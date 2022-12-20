namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Object Data.
/// </summary>
public partial class GraphicDataImpl: ModelElementImpl, GraphicData
{
  public DocumentFormat.OpenXml.Drawing.GraphicData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GraphicData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GraphicDataImpl(): base() {}
  
  public GraphicDataImpl(DocumentFormat.OpenXml.Drawing.GraphicData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Uniform Resource Identifier
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
  
}
