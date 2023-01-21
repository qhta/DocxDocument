namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenFillProperties Class.
/// </summary>
public static class HiddenFillPropertiesConverter
{
  /// <summary>
  /// NoFill.
  /// </summary>
  private static Boolean? GetNoFill(DXO2010Draw.HiddenFillProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NoFill>();
    return itemElement != null;
  }
  
  private static void SetNoFill(DXO2010Draw.HiddenFillProperties openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  private static DMDraws.SolidFill? GetSolidFill(DXO2010Draw.HiddenFillProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SolidFill>();
    if (itemElement != null)
      return DMXDraws.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidFill(DXO2010Draw.HiddenFillProperties openXmlElement, DMDraws.SolidFill? value)
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
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  private static DMDraws.GradientFill? GetGradientFill(DXO2010Draw.HiddenFillProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GradientFill>();
    if (itemElement != null)
      return DMXDraws.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFill(DXO2010Draw.HiddenFillProperties openXmlElement, DMDraws.GradientFill? value)
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
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  private static DMDraws.BlipFill? GetBlipFill(DXO2010Draw.HiddenFillProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlipFill>();
    if (itemElement != null)
      return DMXDraws.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlipFill(DXO2010Draw.HiddenFillProperties openXmlElement, DMDraws.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlipFillConverter.CreateOpenXmlElement<DXDraw.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  private static DMDraws.PatternFill? GetPatternFill(DXO2010Draw.HiddenFillProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PatternFill>();
    if (itemElement != null)
      return DMXDraws.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPatternFill(DXO2010Draw.HiddenFillProperties openXmlElement, DMDraws.PatternFill? value)
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
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  private static Boolean? GetGroupFill(DXO2010Draw.HiddenFillProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GroupFill>();
    return itemElement != null;
  }
  
  private static void SetGroupFill(DXO2010Draw.HiddenFillProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.GroupFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.HiddenFillProperties? CreateModelElement(DXO2010Draw.HiddenFillProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HiddenFillProperties();
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HiddenFillProperties? value)
    where OpenXmlElementType: DXO2010Draw.HiddenFillProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetGroupFill(openXmlElement, value?.GroupFill);
      return openXmlElement;
    }
    return default;
  }
}
