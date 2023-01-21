namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
public static class ManualLayoutConverter
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  private static DMDrawsCharts.LayoutTargetKind? GetLayoutTarget(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LayoutTarget>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDrawsCharts.LayoutTargetKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLayoutTarget(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutTargetKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LayoutTarget>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.LayoutTarget, DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDrawsCharts.LayoutTargetKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  private static DMDrawsCharts.LayoutMode? GetLeftMode(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LeftMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLeftMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LeftMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.LeftMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  private static DMDrawsCharts.LayoutMode? GetTopMode(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TopMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTopMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TopMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.TopMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  private static DMDrawsCharts.LayoutMode? GetWidthMode(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.WidthMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetWidthMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.WidthMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.WidthMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  private static DMDrawsCharts.LayoutMode? GetHeightMode(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.HeightMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHeightMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.HeightMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.HeightMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left.
  /// </summary>
  private static Double? GetLeft(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Left>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLeft(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Left>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Left{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top.
  /// </summary>
  private static Double? GetTop(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Top>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTop(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Top>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Top{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Width.
  /// </summary>
  private static Double? GetWidth(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Width>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetWidth(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Width>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Width{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Height.
  /// </summary>
  private static Double? GetHeight(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Height>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHeight(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Height>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Height{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.ManualLayout? CreateModelElement(DXDrawCharts.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ManualLayout();
      value.LayoutTarget = GetLayoutTarget(openXmlElement);
      value.LeftMode = GetLeftMode(openXmlElement);
      value.TopMode = GetTopMode(openXmlElement);
      value.WidthMode = GetWidthMode(openXmlElement);
      value.HeightMode = GetHeightMode(openXmlElement);
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ManualLayout? value)
    where OpenXmlElementType: DXDrawCharts.ManualLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLayoutTarget(openXmlElement, value?.LayoutTarget);
      SetLeftMode(openXmlElement, value?.LeftMode);
      SetTopMode(openXmlElement, value?.TopMode);
      SetWidthMode(openXmlElement, value?.WidthMode);
      SetHeightMode(openXmlElement, value?.HeightMode);
      SetLeft(openXmlElement, value?.Left);
      SetTop(openXmlElement, value?.Top);
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
