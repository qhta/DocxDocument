namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryAxisScaling Class.
/// </summary>
public class CategoryAxisScalingImpl: ModelElementImpl, CategoryAxisScaling
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  public String? GapWidth
  {
    get => (String?)OpenXmlElement?.GapWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GapWidth = (System.String?)value;
    }
  }
  
}
