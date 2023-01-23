namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public static class PathShadePropertiesConverter
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.PathShadeKind? GetPath(DXO2010W.PathShadeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DMW.PathShadeKind>(openXmlElement?.Path?.Value);
  }
  
  private static bool CmpPath(DXO2010W.PathShadeProperties openXmlElement, DMW.PathShadeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DMW.PathShadeKind>(openXmlElement?.Path?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPath(DXO2010W.PathShadeProperties openXmlElement, DMW.PathShadeKind? value)
  {
    openXmlElement.Path = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DMW.PathShadeKind>(value);
  }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  private static DMW.FillToRectangle? GetFillToRectangle(DXO2010W.PathShadeProperties openXmlElement)
  {
    return DMXW.FillToRectangleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.FillToRectangle>());
  }
  
  private static bool CmpFillToRectangle(DXO2010W.PathShadeProperties openXmlElement, DMW.FillToRectangle? value, DiffList? diffs, string? objName)
  {
    return DMXW.FillToRectangleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.FillToRectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFillToRectangle(DXO2010W.PathShadeProperties openXmlElement, DMW.FillToRectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.FillToRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FillToRectangleConverter.CreateOpenXmlElement<DXO2010W.FillToRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.PathShadeProperties? CreateModelElement(DXO2010W.PathShadeProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2010W.PathShadeProperties? openXmlElement, DMW.PathShadeProperties? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PathShadeProperties? value)
    where OpenXmlElementType: DXO2010W.PathShadeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPath(openXmlElement, value?.Path);
      SetFillToRectangle(openXmlElement, value?.FillToRectangle);
      return openXmlElement;
    }
    return default;
  }
}
