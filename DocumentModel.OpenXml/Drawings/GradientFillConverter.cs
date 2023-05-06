namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public static class GradientFillConverter
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  private static DMD.TileFlipKind? GetFlip(DXD.GradientFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(openXmlElement?.Flip?.Value);
  }
  
  private static bool CmpFlip(DXD.GradientFill openXmlElement, DMD.TileFlipKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(openXmlElement?.Flip?.Value, value, diffs, objName);
  }
  
  private static void SetFlip(DXD.GradientFill openXmlElement, DMD.TileFlipKind? value)
  {
    openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXD.GradientFill openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXD.GradientFill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RotateWithShape?.Value == value) return true;
    diffs?.Add(objName, "RotateWithShape", openXmlElement?.RotateWithShape?.Value, value);
    return false;
  }
  
  private static void SetRotateWithShape(DXD.GradientFill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  private static DMD.GradientStopList? GetGradientStopList(DXD.GradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientStopList>();
    if (element != null)
      return DMXD.GradientStopListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientStopList(DXD.GradientFill openXmlElement, DMD.GradientStopList? value, DiffList? diffs, string? objName)
  {
    return DMXD.GradientStopListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientStopList>(), value, diffs, objName);
  }
  
  private static void SetGradientStopList(DXD.GradientFill openXmlElement, DMD.GradientStopList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientStopList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GradientStopListConverter.CreateOpenXmlElement<DXD.GradientStopList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LinearGradientFill? GetLinearGradientFill(DXD.GradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LinearGradientFill>();
    if (element != null)
      return DMXD.LinearGradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinearGradientFill(DXD.GradientFill openXmlElement, DMD.LinearGradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.LinearGradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LinearGradientFill>(), value, diffs, objName);
  }
  
  private static void SetLinearGradientFill(DXD.GradientFill openXmlElement, DMD.LinearGradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LinearGradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LinearGradientFillConverter.CreateOpenXmlElement<DXD.LinearGradientFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PathGradientFill? GetPathGradientFill(DXD.GradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PathGradientFill>();
    if (element != null)
      return DMXD.PathGradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPathGradientFill(DXD.GradientFill openXmlElement, DMD.PathGradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.PathGradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PathGradientFill>(), value, diffs, objName);
  }
  
  private static void SetPathGradientFill(DXD.GradientFill openXmlElement, DMD.PathGradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PathGradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PathGradientFillConverter.CreateOpenXmlElement<DXD.PathGradientFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.RelativeRectangleType? GetTileRectangle(DXD.GradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TileRectangle>();
    if (element != null)
      return DMXD.RelativeRectangleTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTileRectangle(DXD.GradientFill openXmlElement, DMD.RelativeRectangleType? value, DiffList? diffs, string? objName)
  {
    return DMXD.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TileRectangle>(), value, diffs, objName);
  }
  
  private static void SetTileRectangle(DXD.GradientFill openXmlElement, DMD.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TileRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXD.TileRectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.GradientFill? CreateModelElement(DXD.GradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GradientFill();
      value.Flip = GetFlip(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.GradientStopList = GetGradientStopList(openXmlElement);
      value.LinearGradientFill = GetLinearGradientFill(openXmlElement);
      value.PathGradientFill = GetPathGradientFill(openXmlElement);
      value.TileRectangle = GetTileRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.GradientFill? openXmlElement, DMD.GradientFill? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFlip(openXmlElement, value.Flip, diffs, objName))
        ok = false;
      if (!CmpRotateWithShape(openXmlElement, value.RotateWithShape, diffs, objName))
        ok = false;
      if (!CmpGradientStopList(openXmlElement, value.GradientStopList, diffs, objName))
        ok = false;
      if (!CmpLinearGradientFill(openXmlElement, value.LinearGradientFill, diffs, objName))
        ok = false;
      if (!CmpPathGradientFill(openXmlElement, value.PathGradientFill, diffs, objName))
        ok = false;
      if (!CmpTileRectangle(openXmlElement, value.TileRectangle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.GradientFill value)
    where OpenXmlElementType: DXD.GradientFill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.GradientFill openXmlElement, DMD.GradientFill value)
  {
    SetFlip(openXmlElement, value?.Flip);
    SetRotateWithShape(openXmlElement, value?.RotateWithShape);
    SetGradientStopList(openXmlElement, value?.GradientStopList);
    SetLinearGradientFill(openXmlElement, value?.LinearGradientFill);
    SetPathGradientFill(openXmlElement, value?.PathGradientFill);
    SetTileRectangle(openXmlElement, value?.TileRectangle);
  }
}
