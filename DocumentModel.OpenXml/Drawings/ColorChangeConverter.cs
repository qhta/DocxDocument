namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public static class ColorChangeConverter
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  private static Boolean? GetUseAlpha(DXDraw.ColorChange openXmlElement)
  {
    return openXmlElement?.UseAlpha?.Value;
  }
  
  private static void SetUseAlpha(DXDraw.ColorChange openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseAlpha = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseAlpha = null;
  }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  private static DMDraws.ColorFrom? GetColorFrom(DXDraw.ColorChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorFrom>();
    if (itemElement != null)
      return DMXDraws.ColorFromConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorFrom(DXDraw.ColorChange openXmlElement, DMDraws.ColorFrom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorFrom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorFromConverter.CreateOpenXmlElement<DXDraw.ColorFrom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  private static DMDraws.ColorTo? GetColorTo(DXDraw.ColorChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorTo>();
    if (itemElement != null)
      return DMXDraws.ColorToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorTo(DXDraw.ColorChange openXmlElement, DMDraws.ColorTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorToConverter.CreateOpenXmlElement<DXDraw.ColorTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ColorChange? CreateModelElement(DXDraw.ColorChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ColorChange();
      value.UseAlpha = GetUseAlpha(openXmlElement);
      value.ColorFrom = GetColorFrom(openXmlElement);
      value.ColorTo = GetColorTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ColorChange? value)
    where OpenXmlElementType: DXDraw.ColorChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUseAlpha(openXmlElement, value?.UseAlpha);
      SetColorFrom(openXmlElement, value?.ColorFrom);
      SetColorTo(openXmlElement, value?.ColorTo);
      return openXmlElement;
    }
    return default;
  }
}
