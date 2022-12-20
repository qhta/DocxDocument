namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Shape Extent.
/// </summary>
public partial class ExtentImpl: ModelElementImpl, Extent
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ExtentImpl(): base() {}
  
  public ExtentImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Extent Length
  /// </summary>
  public Int64? Cx
  {
    get => (System.Int64?)OpenXmlElement?.Cx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Cx = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public Int64? Cy
  {
    get => (System.Int64?)OpenXmlElement?.Cy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Cy = (System.Int64?)value;
    }
  }
  
}
