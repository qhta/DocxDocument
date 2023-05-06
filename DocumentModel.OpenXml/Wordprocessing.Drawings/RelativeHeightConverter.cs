namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public static class RelativeHeightConverter
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMWD.SizeRelativeVerticallyKind? GetRelativeFrom(DXO10WD.RelativeHeight openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DMWD.SizeRelativeVerticallyKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  private static bool CmpRelativeFrom(DXO10WD.RelativeHeight openXmlElement, DMWD.SizeRelativeVerticallyKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DMWD.SizeRelativeVerticallyKind>(openXmlElement?.RelativeFrom?.Value, value, diffs, objName);
  }
  
  private static void SetRelativeFrom(DXO10WD.RelativeHeight openXmlElement, DMWD.SizeRelativeVerticallyKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DMWD.SizeRelativeVerticallyKind>(value);
  }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  private static String? GetPercentageHeight(DXO10WD.RelativeHeight openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO10WD.PercentageHeight>()?.Text;
  }
  
  private static bool CmpPercentageHeight(DXO10WD.RelativeHeight openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO10WD.PercentageHeight>()?.Text == value;
  }
  
  private static void SetPercentageHeight(DXO10WD.RelativeHeight openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10WD.PercentageHeight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO10WD.PercentageHeight { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.Drawings.RelativeHeight? CreateModelElement(DXO10WD.RelativeHeight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Drawings.RelativeHeight();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.PercentageHeight = GetPercentageHeight(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10WD.RelativeHeight? openXmlElement, DMWD.RelativeHeight? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelativeFrom(openXmlElement, value.RelativeFrom, diffs, objName))
        ok = false;
      if (!CmpPercentageHeight(openXmlElement, value.PercentageHeight, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWD.RelativeHeight value)
    where OpenXmlElementType: DXO10WD.RelativeHeight, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10WD.RelativeHeight openXmlElement, DMWD.RelativeHeight value)
  {
    SetRelativeFrom(openXmlElement, value?.RelativeFrom);
    SetPercentageHeight(openXmlElement, value?.PercentageHeight);
  }
}
