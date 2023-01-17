namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticFilmGrain Class.
/// </summary>
public static class ArtisticFilmGrainConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetGrainSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain openXmlElement)
  {
    return openXmlElement.GrainSize?.Value;
  }
  
  private static void SetGrainSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain openXmlElement, Int32? value)
  {
    openXmlElement.GrainSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticFilmGrain? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticFilmGrain();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.GrainSize = GetGrainSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticFilmGrain? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetGrainSize(openXmlElement, value?.GrainSize);
      return openXmlElement;
    }
    return default;
  }
}
