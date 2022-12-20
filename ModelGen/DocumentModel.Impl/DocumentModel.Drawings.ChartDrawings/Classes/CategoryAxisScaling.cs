namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the CategoryAxisScaling Class.
/// </summary>
public partial class CategoryAxisScalingImpl: ModelElementImpl, CategoryAxisScaling
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CategoryAxisScalingImpl(): base() {}
  
  public CategoryAxisScalingImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  public String? GapWidth
  {
    get => (System.String?)OpenXmlElement?.GapWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GapWidth = (System.String?)value;
    }
  }
  
}
