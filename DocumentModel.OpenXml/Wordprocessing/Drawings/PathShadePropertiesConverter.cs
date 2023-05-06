namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public static class PathShadePropertiesConverter
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.PathShadeKind? GetPath(DXO10W.PathShadeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DMW.PathShadeKind>(openXmlElement?.Path?.Value);
  }
  
  private static bool CmpPath(DXO10W.PathShadeProperties openXmlElement, DMW.PathShadeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DMW.PathShadeKind>(openXmlElement?.Path?.Value, value, diffs, objName);
  }
  
  private static void SetPath(DXO10W.PathShadeProperties openXmlElement, DMW.PathShadeKind? value)
  {
    openXmlElement.Path = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DMW.PathShadeKind>(value);
  }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  private static DMW.FillToRectangle? GetFillToRectangle(DXO10W.PathShadeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.FillToRectangle>();
    if (element != null)
      return DMXW.FillToRectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillToRectangle(DXO10W.PathShadeProperties openXmlElement, DMW.FillToRectangle? value, DiffList? diffs, string? objName)
  {
    return DMXW.FillToRectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.FillToRectangle>(), value, diffs, objName);
  }
  
  private static void SetFillToRectangle(DXO10W.PathShadeProperties openXmlElement, DMW.FillToRectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.FillToRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FillToRectangleConverter.CreateOpenXmlElement<DXO10W.FillToRectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.PathShadeProperties? CreateModelElement(DXO10W.PathShadeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PathShadeProperties();
      value.Path = GetPath(openXmlElement);
      value.FillToRectangle = GetFillToRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.PathShadeProperties? openXmlElement, DMW.PathShadeProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PathShadeProperties value)
    where OpenXmlElementType: DXO10W.PathShadeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.PathShadeProperties openXmlElement, DMW.PathShadeProperties value)
  {
    SetPath(openXmlElement, value?.Path);
    SetFillToRectangle(openXmlElement, value?.FillToRectangle);
  }
}
