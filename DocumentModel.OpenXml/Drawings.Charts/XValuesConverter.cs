namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the XValues Class.
/// </summary>
public static class XValuesConverter
{
  private static DMDrawsCharts.MultiLevelStringReference? GetMultiLevelStringReference(DXDrawCharts.XValues openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.MultiLevelStringReference>();
    if (itemElement != null)
      return DMXDrawsCharts.MultiLevelStringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMultiLevelStringReference(DXDrawCharts.XValues openXmlElement, DMDrawsCharts.MultiLevelStringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MultiLevelStringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MultiLevelStringReferenceConverter.CreateOpenXmlElement<DXDrawCharts.MultiLevelStringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.NumberReference? GetNumberReference(DXDrawCharts.XValues openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberReference(DXDrawCharts.XValues openXmlElement, DMDrawsCharts.NumberReference? value)
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
  
  private static DMDrawsCharts.NumberLiteral? GetNumberLiteral(DXDrawCharts.XValues openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberLiteral(DXDrawCharts.XValues openXmlElement, DMDrawsCharts.NumberLiteral? value)
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
  
  private static DMDrawsCharts.StringReference? GetStringReference(DXDrawCharts.XValues openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>();
    if (itemElement != null)
      return DMXDrawsCharts.StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringReference(DXDrawCharts.XValues openXmlElement, DMDrawsCharts.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringReferenceConverter.CreateOpenXmlElement<DXDrawCharts.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.StringLiteral? GetStringLiteral(DXDrawCharts.XValues openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (itemElement != null)
      return DMXDrawsCharts.StringLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringLiteral(DXDrawCharts.XValues openXmlElement, DMDrawsCharts.StringLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringLiteralConverter.CreateOpenXmlElement<DXDrawCharts.StringLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.XValues? CreateModelElement(DXDrawCharts.XValues? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.XValues();
      value.MultiLevelStringReference = GetMultiLevelStringReference(openXmlElement);
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      value.StringReference = GetStringReference(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.XValues? value)
    where OpenXmlElementType: DXDrawCharts.XValues, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLevelStringReference(openXmlElement, value?.MultiLevelStringReference);
      SetNumberReference(openXmlElement, value?.NumberReference);
      SetNumberLiteral(openXmlElement, value?.NumberLiteral);
      SetStringReference(openXmlElement, value?.StringReference);
      SetStringLiteral(openXmlElement, value?.StringLiteral);
      return openXmlElement;
    }
    return default;
  }
}
