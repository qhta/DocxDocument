namespace DocumentModel.Drawings;

/// <summary>
/// Shape Guide.
/// </summary>
public partial class ShapeGuideImpl: ModelElementImpl, ShapeGuide
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ShapeGuide? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapeGuide?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ShapeGuideImpl(): base() {}
  
  public ShapeGuideImpl(DocumentFormat.OpenXml.Drawing.ShapeGuide openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Guide Formula
  /// </summary>
  public String? Formula
  {
    get => (System.String?)OpenXmlElement?.Formula?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Formula = (System.String?)value;
    }
  }
  
}
