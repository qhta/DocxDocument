namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public class PathShadePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>, PathShadeProperties
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  public PathShadeKind? Path
  {
    get => (PathShadeKind?)OpenXmlElement?.Path?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Path = (DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues?)value;
    }
  }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  public FillToRectangle? FillToRectangle
  {
    get;
    set;
  }
  
}
