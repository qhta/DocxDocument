namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPastelsSmooth Class.
/// </summary>
public static class ArtisticPastelsSmoothConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBrushSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth openXmlElement)
  {
    return openXmlElement.BrushSize?.Value;
  }
  
  private static void SetBrushSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth openXmlElement, Int32? value)
  {
    openXmlElement.BrushSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPastelsSmooth? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPastelsSmooth();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPastelsSmooth? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetBrushSize(openXmlElement, value?.BrushSize);
      return openXmlElement;
    }
    return default;
  }
}
