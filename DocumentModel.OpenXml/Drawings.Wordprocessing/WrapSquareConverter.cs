namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Square Wrapping.
/// </summary>
public static class WrapSquareConverter
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  private static DMDrawsW.WrapTextKind? GetWrapText(DXDrawW.WrapSquare openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDrawsW.WrapTextKind>(openXmlElement?.WrapText?.Value);
  }
  
  private static bool CmpWrapText(DXDrawW.WrapSquare openXmlElement, DMDrawsW.WrapTextKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDrawsW.WrapTextKind>(openXmlElement?.WrapText?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrapText(DXDrawW.WrapSquare openXmlElement, DMDrawsW.WrapTextKind? value)
  {
    openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDrawsW.WrapTextKind>(value);
  }
  
  /// <summary>
  /// Distance From Text (Top)
  /// </summary>
  private static UInt32? GetDistanceFromTop(DXDrawW.WrapSquare openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }
  
  private static bool CmpDistanceFromTop(DXDrawW.WrapSquare openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromTop?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromTop", openXmlElement?.DistanceFromTop?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromTop(DXDrawW.WrapSquare openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  private static UInt32? GetDistanceFromBottom(DXDrawW.WrapSquare openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }
  
  private static bool CmpDistanceFromBottom(DXDrawW.WrapSquare openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromBottom?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromBottom", openXmlElement?.DistanceFromBottom?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromBottom(DXDrawW.WrapSquare openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDrawW.WrapSquare openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  private static bool CmpDistanceFromLeft(DXDrawW.WrapSquare openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromLeft?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromLeft", openXmlElement?.DistanceFromLeft?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromLeft(DXDrawW.WrapSquare openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDrawW.WrapSquare openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  private static bool CmpDistanceFromRight(DXDrawW.WrapSquare openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromRight?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromRight", openXmlElement?.DistanceFromRight?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromRight(DXDrawW.WrapSquare openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  private static DMDrawsW.EffectExtent? GetEffectExtent(DXDrawW.WrapSquare openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawW.EffectExtent>();
    if (element != null)
      return DMXDrawsW.EffectExtentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectExtent(DXDrawW.WrapSquare openXmlElement, DMDrawsW.EffectExtent? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.EffectExtentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawW.EffectExtent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectExtent(DXDrawW.WrapSquare openXmlElement, DMDrawsW.EffectExtent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.EffectExtent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.EffectExtentConverter.CreateOpenXmlElement<DXDrawW.EffectExtent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WrapSquare? CreateModelElement(DXDrawW.WrapSquare? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapSquare();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawW.WrapSquare? openXmlElement, DMDrawsW.WrapSquare? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWrapText(openXmlElement, value.WrapText, diffs, objName))
        ok = false;
      if (!CmpDistanceFromTop(openXmlElement, value.DistanceFromTop, diffs, objName))
        ok = false;
      if (!CmpDistanceFromBottom(openXmlElement, value.DistanceFromBottom, diffs, objName))
        ok = false;
      if (!CmpDistanceFromLeft(openXmlElement, value.DistanceFromLeft, diffs, objName))
        ok = false;
      if (!CmpDistanceFromRight(openXmlElement, value.DistanceFromRight, diffs, objName))
        ok = false;
      if (!CmpEffectExtent(openXmlElement, value.EffectExtent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.WrapSquare value)
    where OpenXmlElementType: DXDrawW.WrapSquare, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawW.WrapSquare openXmlElement, DMDrawsW.WrapSquare value)
  {
    SetWrapText(openXmlElement, value?.WrapText);
    SetDistanceFromTop(openXmlElement, value?.DistanceFromTop);
    SetDistanceFromBottom(openXmlElement, value?.DistanceFromBottom);
    SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
    SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
    SetEffectExtent(openXmlElement, value?.EffectExtent);
  }
}
