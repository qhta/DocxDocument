namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Frameset Splitter Properties.
/// </summary>
public static class FramesetSplitbarConverter
{
  /// <summary>
  /// Frameset Splitter Width.
  /// </summary>
  private static String? GetWidth(DXW.FramesetSplitbar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Width>()?.Val);
  }
  
  private static bool CmpWidth(DXW.FramesetSplitbar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Width>()?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetWidth(DXW.FramesetSplitbar openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.Width>(openXmlElement, value);
  }
  
  /// <summary>
  /// Frameset Splitter Color.
  /// </summary>
  private static DMW.Color? GetColor(DXW.FramesetSplitbar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Color>();
    if (element != null)
      return DMXW.ColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColor(DXW.FramesetSplitbar openXmlElement, DMW.Color? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Color>(), value, diffs, objName);
  }
  
  private static void SetColor(DXW.FramesetSplitbar openXmlElement, DMW.Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ColorConverter.CreateOpenXmlElement<DXW.Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Display Frameset Splitters.
  /// </summary>
  private static Boolean GetNoBorder(DXW.FramesetSplitbar openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoBorder>());
  }
  
  private static bool CmpNoBorder(DXW.FramesetSplitbar openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoBorder>(), value, diffs, objName);
  }
  
  private static void SetNoBorder(DXW.FramesetSplitbar openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.NoBorder>(openXmlElement, value);
  }
  
  /// <summary>
  /// Frameset Splitter Border Style.
  /// </summary>
  private static Boolean GetFlatBorders(DXW.FramesetSplitbar openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.FlatBorders>());
  }
  
  private static bool CmpFlatBorders(DXW.FramesetSplitbar openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.FlatBorders>(), value, diffs, objName);
  }
  
  private static void SetFlatBorders(DXW.FramesetSplitbar openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.FlatBorders>(openXmlElement, value);
  }
  
  public static DMW.FramesetSplitbar? CreateModelElement(DXW.FramesetSplitbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FramesetSplitbar();
      value.Width = GetWidth(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.NoBorder = GetNoBorder(openXmlElement);
      value.FlatBorders = GetFlatBorders(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FramesetSplitbar? openXmlElement, DMW.FramesetSplitbar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpNoBorder(openXmlElement, value.NoBorder, diffs, objName))
        ok = false;
      if (!CmpFlatBorders(openXmlElement, value.FlatBorders, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FramesetSplitbar value)
    where OpenXmlElementType: DXW.FramesetSplitbar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FramesetSplitbar openXmlElement, DMW.FramesetSplitbar value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetColor(openXmlElement, value?.Color);
    SetNoBorder(openXmlElement, value?.NoBorder);
    SetFlatBorders(openXmlElement, value?.FlatBorders);
  }
}
