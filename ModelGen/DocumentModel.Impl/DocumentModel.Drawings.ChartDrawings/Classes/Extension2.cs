namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Extension2 Class.
/// </summary>
public partial class Extension2Impl: ModelElementImpl, Extension2
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public Extension2Impl(): base() {}
  
  public Extension2Impl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2 openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// uri, this property is only available in Office 2016 and later.
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
