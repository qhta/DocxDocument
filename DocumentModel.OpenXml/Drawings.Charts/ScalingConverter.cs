namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scaling.
/// </summary>
public static class ScalingConverter
{
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  private static Double? GetLogBase(DXDrawCharts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.LogBase>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLogBase(DXDrawCharts.Scaling openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LogBase>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.LogBase{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  private static DMDrawsCharts.OrientationKind? GetOrientation(DXDrawCharts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Orientation>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDrawsCharts.OrientationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetOrientation(DXDrawCharts.Scaling openXmlElement, DMDrawsCharts.OrientationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Orientation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.Orientation, DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDrawsCharts.OrientationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  private static Double? GetMaxAxisValue(DXDrawCharts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.MaxAxisValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMaxAxisValue(DXDrawCharts.Scaling openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MaxAxisValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.MaxAxisValue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  private static Double? GetMinAxisValue(DXDrawCharts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.MinAxisValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMinAxisValue(DXDrawCharts.Scaling openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MinAxisValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.MinAxisValue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.Scaling openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Scaling? CreateModelElement(DXDrawCharts.Scaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Scaling();
      value.LogBase = GetLogBase(openXmlElement);
      value.Orientation = GetOrientation(openXmlElement);
      value.MaxAxisValue = GetMaxAxisValue(openXmlElement);
      value.MinAxisValue = GetMinAxisValue(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Scaling? value)
    where OpenXmlElementType: DXDrawCharts.Scaling, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLogBase(openXmlElement, value?.LogBase);
      SetOrientation(openXmlElement, value?.Orientation);
      SetMaxAxisValue(openXmlElement, value?.MaxAxisValue);
      SetMinAxisValue(openXmlElement, value?.MinAxisValue);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
