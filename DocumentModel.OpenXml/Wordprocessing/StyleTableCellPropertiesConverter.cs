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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      return DMXW.ShadingConverter.CreateModelElement(itemElement);
    return null;
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
  private static DMW.OnOffOnlyKind? GetNoWrap(DXW.StyleTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoWrap>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNoWrap(DXW.StyleTableCellProperties openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.NoWrap, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  private static DMW.TableCellMargin? GetTableCellMargin(DXW.StyleTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellMargin>();
    if (itemElement != null)
      return DMXW.TableCellMarginConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(itemElement.Val.Value);
    return null;
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
