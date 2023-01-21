namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public static class ColorTransformStyleLabelConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDrawDgms.ColorTransformStyleLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Fill Color List.
  /// </summary>
  private static DMDrawsDgms.FillColorList? GetFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.FillColorList>();
    if (itemElement != null)
      return DMXDrawsDgms.FillColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.FillColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.FillColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.FillColorListConverter.CreateOpenXmlElement<DXDrawDgms.FillColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  private static DMDrawsDgms.LineColorList? GetLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.LineColorList>();
    if (itemElement != null)
      return DMXDrawsDgms.LineColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.LineColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.LineColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.LineColorListConverter.CreateOpenXmlElement<DXDrawDgms.LineColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  private static DMDrawsDgms.EffectColorList? GetEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.EffectColorList>();
    if (itemElement != null)
      return DMXDrawsDgms.EffectColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.EffectColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.EffectColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.EffectColorListConverter.CreateOpenXmlElement<DXDrawDgms.EffectColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  private static DMDrawsDgms.TextLineColorList? GetTextLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.TextLineColorList>();
    if (itemElement != null)
      return DMXDrawsDgms.TextLineColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextLineColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextLineColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextLineColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextLineColorListConverter.CreateOpenXmlElement<DXDrawDgms.TextLineColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  private static DMDrawsDgms.TextFillColorList? GetTextFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.TextFillColorList>();
    if (itemElement != null)
      return DMXDrawsDgms.TextFillColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextFillColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextFillColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextFillColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextFillColorListConverter.CreateOpenXmlElement<DXDrawDgms.TextFillColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  private static DMDrawsDgms.TextEffectColorList? GetTextEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.TextEffectColorList>();
    if (itemElement != null)
      return DMXDrawsDgms.TextEffectColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextEffectColorList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.TextEffectColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextEffectColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextEffectColorListConverter.CreateOpenXmlElement<DXDrawDgms.TextEffectColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.ColorTransformStyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawDgms.ColorTransformStyleLabel openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.ColorTransformStyleLabel? CreateModelElement(DXDrawDgms.ColorTransformStyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ColorTransformStyleLabel();
      value.Name = GetName(openXmlElement);
      value.FillColorList = GetFillColorList(openXmlElement);
      value.LineColorList = GetLineColorList(openXmlElement);
      value.EffectColorList = GetEffectColorList(openXmlElement);
      value.TextLineColorList = GetTextLineColorList(openXmlElement);
      value.TextFillColorList = GetTextFillColorList(openXmlElement);
      value.TextEffectColorList = GetTextEffectColorList(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorTransformStyleLabel? value)
    where OpenXmlElementType: DXDrawDgms.ColorTransformStyleLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetFillColorList(openXmlElement, value?.FillColorList);
      SetLineColorList(openXmlElement, value?.LineColorList);
      SetEffectColorList(openXmlElement, value?.EffectColorList);
      SetTextLineColorList(openXmlElement, value?.TextLineColorList);
      SetTextFillColorList(openXmlElement, value?.TextFillColorList);
      SetTextEffectColorList(openXmlElement, value?.TextEffectColorList);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
