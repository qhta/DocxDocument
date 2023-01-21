namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Values Class.
/// </summary>
public static class ValuesConverter
{
  private static DMDrawsCharts.NumberReference? GetNumberReference(DXDrawCharts.Values openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberReference(DXDrawCharts.Values openXmlElement, DMDrawsCharts.NumberReference? value)
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
  
  private static DMDrawsCharts.NumberLiteral? GetNumberLiteral(DXDrawCharts.Values openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberLiteral(DXDrawCharts.Values openXmlElement, DMDrawsCharts.NumberLiteral? value)
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
  
  public static DMDrawsCharts.Values? CreateModelElement(DXDrawCharts.Values? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Values();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Values? value)
    where OpenXmlElementType: DXDrawCharts.Values, new()
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
