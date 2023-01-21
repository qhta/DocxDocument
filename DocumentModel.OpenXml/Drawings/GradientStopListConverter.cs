namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Gradient Stop List.
/// </summary>
public static class GradientStopListConverter
{
  private static DMDraws.GradientStop? GetGradientStop(DXDraw.GradientStopList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GradientStop>();
    if (itemElement != null)
      return DMXDraws.GradientStopConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientStop(DXDraw.GradientStopList openXmlElement, DMDraws.GradientStop? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GradientStop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GradientStopConverter.CreateOpenXmlElement<DXDraw.GradientStop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.GradientStopList? CreateModelElement(DXDraw.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.GradientStopList();
      value.GradientStop = GetGradientStop(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.GradientStopList? value)
    where OpenXmlElementType: DXDraw.GradientStopList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGradientStop(openXmlElement, value?.GradientStop);
      return openXmlElement;
    }
    return default;
  }
}
