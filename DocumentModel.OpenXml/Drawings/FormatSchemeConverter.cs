namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Format Scheme.
/// </summary>
public static class FormatSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDraw.FormatScheme openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDraw.FormatScheme openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  private static DMDraws.FillStyleList? GetFillStyleList(DXDraw.FormatScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FillStyleList>();
    if (itemElement != null)
      return DMXDraws.FillStyleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.FillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FillStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FillStyleListConverter.CreateOpenXmlElement<DXDraw.FillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  private static DMDraws.LineStyleList? GetLineStyleList(DXDraw.FormatScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LineStyleList>();
    if (itemElement != null)
      return DMXDraws.LineStyleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.LineStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineStyleListConverter.CreateOpenXmlElement<DXDraw.LineStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  private static DMDraws.EffectStyleList? GetEffectStyleList(DXDraw.FormatScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectStyleList>();
    if (itemElement != null)
      return DMXDraws.EffectStyleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.EffectStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectStyleListConverter.CreateOpenXmlElement<DXDraw.EffectStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  private static DMDraws.BackgroundFillStyleList? GetBackgroundFillStyleList(DXDraw.FormatScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BackgroundFillStyleList>();
    if (itemElement != null)
      return DMXDraws.BackgroundFillStyleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundFillStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.BackgroundFillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BackgroundFillStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundFillStyleListConverter.CreateOpenXmlElement<DXDraw.BackgroundFillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.FormatScheme? CreateModelElement(DXDraw.FormatScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.FormatScheme();
      value.Name = GetName(openXmlElement);
      value.FillStyleList = GetFillStyleList(openXmlElement);
      value.LineStyleList = GetLineStyleList(openXmlElement);
      value.EffectStyleList = GetEffectStyleList(openXmlElement);
      value.BackgroundFillStyleList = GetBackgroundFillStyleList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.FormatScheme? value)
    where OpenXmlElementType: DXDraw.FormatScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetFillStyleList(openXmlElement, value?.FillStyleList);
      SetLineStyleList(openXmlElement, value?.LineStyleList);
      SetEffectStyleList(openXmlElement, value?.EffectStyleList);
      SetBackgroundFillStyleList(openXmlElement, value?.BackgroundFillStyleList);
      return openXmlElement;
    }
    return default;
  }
}
