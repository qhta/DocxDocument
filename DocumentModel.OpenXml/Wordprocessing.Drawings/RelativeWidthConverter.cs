namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public static class RelativeWidthConverter
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMWD.SizeRelativeHorizontallyKind? GetObjectId(DXO10WD.RelativeWidth openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DMWD.SizeRelativeHorizontallyKind>(openXmlElement?.ObjectId?.Value);
  }
  
  private static bool CmpObjectId(DXO10WD.RelativeWidth openXmlElement, DMWD.SizeRelativeHorizontallyKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DMWD.SizeRelativeHorizontallyKind>(openXmlElement?.ObjectId?.Value, value, diffs, objName);
  }
  
  private static void SetObjectId(DXO10WD.RelativeWidth openXmlElement, DMWD.SizeRelativeHorizontallyKind? value)
  {
    openXmlElement.ObjectId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DMWD.SizeRelativeHorizontallyKind>(value);
  }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  private static String? GetPercentageWidth(DXO10WD.RelativeWidth openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO10WD.PercentageWidth>()?.Text;
  }
  
  private static bool CmpPercentageWidth(DXO10WD.RelativeWidth openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO10WD.PercentageWidth>()?.Text == value;
  }
  
  private static void SetPercentageWidth(DXO10WD.RelativeWidth openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10WD.PercentageWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO10WD.PercentageWidth { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Drawings.RelativeWidth? CreateModelElement(DXO10WD.RelativeWidth? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Drawings.RelativeWidth();
      value.ObjectId = GetObjectId(openXmlElement);
      value.PercentageWidth = GetPercentageWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10WD.RelativeWidth? openXmlElement, DMWD.RelativeWidth? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpObjectId(openXmlElement, value.ObjectId, diffs, objName))
        ok = false;
      if (!CmpPercentageWidth(openXmlElement, value.PercentageWidth, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWD.RelativeWidth value)
    where OpenXmlElementType: DXO10WD.RelativeWidth, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10WD.RelativeWidth openXmlElement, DMWD.RelativeWidth value)
  {
    SetObjectId(openXmlElement, value?.ObjectId);
    SetPercentageWidth(openXmlElement, value?.PercentageWidth);
  }
}
