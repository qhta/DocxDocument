namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticLineDrawing Class.
/// </summary>
public static class ArtisticLineDrawingConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticLineDrawing openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticLineDrawing openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetPencilSize(DXO2010Draw.ArtisticLineDrawing openXmlElement)
  {
    return openXmlElement.PencilSize?.Value;
  }
  
  private static void SetPencilSize(DXO2010Draw.ArtisticLineDrawing openXmlElement, Int32? value)
  {
    openXmlElement.PencilSize = value;
  }
  
  public static DMDraws.ArtisticLineDrawing? CreateModelElement(DXO2010Draw.ArtisticLineDrawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticLineDrawing();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.PencilSize = GetPencilSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticLineDrawing? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticLineDrawing, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetPencilSize(openXmlElement, value?.PencilSize);
      return openXmlElement;
    }
    return default;
  }
}
