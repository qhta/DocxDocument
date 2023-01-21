namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public static class OutlineConverter
{
  private static Boolean? GetNoFill(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NoFill>();
    return itemElement != null;
  }
  
  private static void SetNoFill(DXDraw.Outline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.NoFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SolidFill? GetSolidFill(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SolidFill>();
    if (itemElement != null)
      return DMXDraws.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidFill(DXDraw.Outline openXmlElement, DMDraws.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SolidFillConverter.CreateOpenXmlElement<DXDraw.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.GradientFill? GetGradientFill(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GradientFill>();
    if (itemElement != null)
      return DMXDraws.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFill(DXDraw.Outline openXmlElement, DMDraws.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GradientFillConverter.CreateOpenXmlElement<DXDraw.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PatternFill? GetPatternFill(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PatternFill>();
    if (itemElement != null)
      return DMXDraws.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPatternFill(DXDraw.Outline openXmlElement, DMDraws.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PatternFillConverter.CreateOpenXmlElement<DXDraw.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PresetLineDashKind? GetPresetDash(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetDash>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMDraws.PresetLineDashKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPresetDash(DXDraw.Outline openXmlElement, DMDraws.PresetLineDashKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetDash>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDraw.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMDraws.PresetLineDashKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.CustomDash? GetCustomDash(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.CustomDash>();
    if (itemElement != null)
      return DMXDraws.CustomDashConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomDash(DXDraw.Outline openXmlElement, DMDraws.CustomDash? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CustomDash>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CustomDashConverter.CreateOpenXmlElement<DXDraw.CustomDash>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetRound(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Round>();
    return itemElement != null;
  }
  
  private static void SetRound(DXDraw.Outline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.Round>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.Round();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetLineJoinBevel(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineJoinBevel>();
    return itemElement != null;
  }
  
  private static void SetLineJoinBevel(DXDraw.Outline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.LineJoinBevel>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.LineJoinBevel();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Miter? GetMiter(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Miter>();
    if (itemElement != null)
      return DMXDraws.MiterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMiter(DXDraw.Outline openXmlElement, DMDraws.Miter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Miter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.MiterConverter.CreateOpenXmlElement<DXDraw.Miter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LineEndPropertiesType? GetHeadEnd(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HeadEnd>();
    if (itemElement != null)
      return DMXDraws.LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHeadEnd(DXDraw.Outline openXmlElement, DMDraws.LineEndPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HeadEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXDraw.HeadEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LineEndPropertiesType? GetTailEnd(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.TailEnd>();
    if (itemElement != null)
      return DMXDraws.LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTailEnd(DXDraw.Outline openXmlElement, DMDraws.LineEndPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TailEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXDraw.TailEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DXDraw.Outline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LinePropertiesExtensionList>();
    if (itemElement != null)
      return DMXDraws.LinePropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLinePropertiesExtensionList(DXDraw.Outline openXmlElement, DMDraws.LinePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LinePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LinePropertiesExtensionListConverter.CreateOpenXmlElement<DXDraw.LinePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.Outline? CreateModelElement(DXDraw.Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Outline();
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.PresetDash = GetPresetDash(openXmlElement);
      value.CustomDash = GetCustomDash(openXmlElement);
      value.Round = GetRound(openXmlElement);
      value.LineJoinBevel = GetLineJoinBevel(openXmlElement);
      value.Miter = GetMiter(openXmlElement);
      value.HeadEnd = GetHeadEnd(openXmlElement);
      value.TailEnd = GetTailEnd(openXmlElement);
      value.LinePropertiesExtensionList = GetLinePropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Outline? value)
    where OpenXmlElementType: DXDraw.Outline, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetPresetDash(openXmlElement, value?.PresetDash);
      SetCustomDash(openXmlElement, value?.CustomDash);
      SetRound(openXmlElement, value?.Round);
      SetLineJoinBevel(openXmlElement, value?.LineJoinBevel);
      SetMiter(openXmlElement, value?.Miter);
      SetHeadEnd(openXmlElement, value?.HeadEnd);
      SetTailEnd(openXmlElement, value?.TailEnd);
      SetLinePropertiesExtensionList(openXmlElement, value?.LinePropertiesExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
