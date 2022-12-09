namespace DocumentModel.Drawings;

/// <summary>
/// Shape Guide.
/// </summary>
public class ShapeGuideImpl: ModelElementImpl, ShapeGuide
{
  public DocumentFormat.OpenXml.Drawing.ShapeGuide? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapeGuide?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
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
    get => (String?)OpenXmlElement?.Formula?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Formula = (System.String?)value;
    }
  }
  
}
