namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Minus.
/// </summary>
public static class MinusConverter
{
  private static DMDrawsCharts.NumberReference? GetNumberReference(DXDrawCharts.Minus openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberReference(DXDrawCharts.Minus openXmlElement, DMDrawsCharts.NumberReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberReferenceConverter.CreateOpenXmlElement<DXDrawCharts.NumberReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.NumberLiteral? GetNumberLiteral(DXDrawCharts.Minus openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberLiteral(DXDrawCharts.Minus openXmlElement, DMDrawsCharts.NumberLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberLiteralConverter.CreateOpenXmlElement<DXDrawCharts.NumberLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Minus? CreateModelElement(DXDrawCharts.Minus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Minus();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Minus? value)
    where OpenXmlElementType: DXDrawCharts.Minus, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberReference(openXmlElement, value?.NumberReference);
      SetNumberLiteral(openXmlElement, value?.NumberLiteral);
      return openXmlElement;
    }
    return default;
  }
}
