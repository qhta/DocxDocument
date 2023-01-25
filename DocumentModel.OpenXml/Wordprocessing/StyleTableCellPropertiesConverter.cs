namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Table Cell Properties.
/// </summary>
public static class StyleTableCellPropertiesConverter
{
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.StyleTableCellProperties openXmlElement)
  {
    return DMXW.ShadingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Shading>());
  }
  
  private static bool CmpShading(DXW.StyleTableCellProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.StyleTableCellProperties openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  private static Boolean? GetNoWrap(DXW.StyleTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoWrap>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpNoWrap(DXW.StyleTableCellProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoWrap>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNoWrap(DXW.StyleTableCellProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoWrap>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoWrap();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  private static DMW.TableCellMargin? GetTableCellMargin(DXW.StyleTableCellProperties openXmlElement)
  {
    return DMXW.TableCellMarginConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableCellMargin>());
  }
  
  private static bool CmpTableCellMargin(DXW.StyleTableCellProperties openXmlElement, DMW.TableCellMargin? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMargin>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellMargin(DXW.StyleTableCellProperties openXmlElement, DMW.TableCellMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellMarginConverter.CreateOpenXmlElement<DXW.TableCellMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  private static DMW.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DXW.StyleTableCellProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value);
  }
  
  private static bool CmpTableCellVerticalAlignment(DXW.StyleTableCellProperties openXmlElement, DMW.TableVerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellVerticalAlignment(DXW.StyleTableCellProperties openXmlElement, DMW.TableVerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TableCellVerticalAlignment, DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.StyleTableCellProperties? CreateModelElement(DXW.StyleTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StyleTableCellProperties();
      value.Shading = GetShading(openXmlElement);
      value.NoWrap = GetNoWrap(openXmlElement);
      value.TableCellMargin = GetTableCellMargin(openXmlElement);
      value.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StyleTableCellProperties? openXmlElement, DMW.StyleTableCellProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpNoWrap(openXmlElement, value.NoWrap, diffs, objName))
        ok = false;
      if (!CmpTableCellMargin(openXmlElement, value.TableCellMargin, diffs, objName))
        ok = false;
      if (!CmpTableCellVerticalAlignment(openXmlElement, value.TableCellVerticalAlignment, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleTableCellProperties? value)
    where OpenXmlElementType: DXW.StyleTableCellProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShading(openXmlElement, value?.Shading);
      SetNoWrap(openXmlElement, value?.NoWrap);
      SetTableCellMargin(openXmlElement, value?.TableCellMargin);
      SetTableCellVerticalAlignment(openXmlElement, value?.TableCellVerticalAlignment);
      return openXmlElement;
    }
    return default;
  }
}
