namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public static class RelativeWidthConverter
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMWDraws.SizeRelativeHorizontallyKind? GetObjectId(DXO2010WDraw.RelativeWidth openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DMWDraws.SizeRelativeHorizontallyKind>(openXmlElement?.ObjectId?.Value);
  }
  
  private static bool CmpObjectId(DXO2010WDraw.RelativeWidth openXmlElement, DMWDraws.SizeRelativeHorizontallyKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DMWDraws.SizeRelativeHorizontallyKind>(openXmlElement?.ObjectId?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetObjectId(DXO2010WDraw.RelativeWidth openXmlElement, DMWDraws.SizeRelativeHorizontallyKind? value)
  {
    openXmlElement.ObjectId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DMWDraws.SizeRelativeHorizontallyKind>(value);
  }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  private static String? GetPercentageWidth(DXO2010WDraw.RelativeWidth openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2010WDraw.PercentageWidth>()?.Text;
  }
  
  private static bool CmpPercentageWidth(DXO2010WDraw.RelativeWidth openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2010WDraw.PercentageWidth>()?.Text == value;
  }
  
  private static void SetPercentageWidth(DXO2010WDraw.RelativeWidth openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010WDraw.PercentageWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010WDraw.PercentageWidth { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMWDraws.RelativeWidth? CreateModelElement(DXO2010WDraw.RelativeWidth? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWDraws.RelativeWidth();
      value.ObjectId = GetObjectId(openXmlElement);
      value.PercentageWidth = GetPercentageWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010WDraw.RelativeWidth? openXmlElement, DMWDraws.RelativeWidth? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWDraws.RelativeWidth? value)
    where OpenXmlElementType: DXO2010WDraw.RelativeWidth, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetObjectId(openXmlElement, value?.ObjectId);
      SetPercentageWidth(openXmlElement, value?.PercentageWidth);
      return openXmlElement;
    }
    return default;
  }
}
