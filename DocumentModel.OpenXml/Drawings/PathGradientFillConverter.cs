namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public static class PathGradientFillConverter
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  private static DMD.PathShadeKind? GetPath(DXD.PathGradientFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DMD.PathShadeKind>(openXmlElement?.Path?.Value);
  }
  
  private static bool CmpPath(DXD.PathGradientFill openXmlElement, DMD.PathShadeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DMD.PathShadeKind>(openXmlElement?.Path?.Value, value, diffs, objName);
  }
  
  private static void SetPath(DXD.PathGradientFill openXmlElement, DMD.PathShadeKind? value)
  {
    openXmlElement.Path = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DMD.PathShadeKind>(value);
  }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  private static DMD.RelativeRectangleType? GetFillToRectangle(DXD.PathGradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillToRectangle>();
    if (element != null)
      return DMXD.RelativeRectangleTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillToRectangle(DXD.PathGradientFill openXmlElement, DMD.RelativeRectangleType? value, DiffList? diffs, string? objName)
  {
    return DMXD.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillToRectangle>(), value, diffs, objName);
  }
  
  private static void SetFillToRectangle(DXD.PathGradientFill openXmlElement, DMD.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillToRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXD.FillToRectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.PathGradientFill? CreateModelElement(DXD.PathGradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PathGradientFill();
      value.Path = GetPath(openXmlElement);
      value.FillToRectangle = GetFillToRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.PathGradientFill? openXmlElement, DMD.PathGradientFill? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPath(openXmlElement, value.Path, diffs, objName))
        ok = false;
      if (!CmpFillToRectangle(openXmlElement, value.FillToRectangle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PathGradientFill value)
    where OpenXmlElementType: DXD.PathGradientFill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.PathGradientFill openXmlElement, DMD.PathGradientFill value)
  {
    SetPath(openXmlElement, value?.Path);
    SetFillToRectangle(openXmlElement, value?.FillToRectangle);
  }
}
