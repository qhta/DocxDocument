namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table Cell Properties.
/// </summary>
public static class PreviousTableCellPropertiesConverter
{
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  private static DMW.ConditionalFormatStyle? GetConditionalFormatStyle(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (itemElement != null)
      return DMXW.ConditionalFormatStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConditionalFormatStyle(DXW.PreviousTableCellProperties openXmlElement, DMW.ConditionalFormatStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ConditionalFormatStyleConverter.CreateOpenXmlElement<DXW.ConditionalFormatStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellWidth.
  /// </summary>
  private static DMW.TableWidthType? GetTableCellWidth(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellWidth>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellWidth(DXW.PreviousTableCellProperties openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableCellWidth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GridSpan.
  /// </summary>
  private static Int32? GetGridSpan(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.GridSpan>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGridSpan(DXW.PreviousTableCellProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.GridSpan>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.GridSpan{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// HorizontalMerge.
  /// </summary>
  private static DMW.MergedCellKind? GetHorizontalMerge(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HorizontalMerge>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHorizontalMerge(DXW.PreviousTableCellProperties openXmlElement, DMW.MergedCellKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HorizontalMerge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.HorizontalMerge, DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VerticalMerge.
  /// </summary>
  private static DMW.MergedCellKind? GetVerticalMerge(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalMerge>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetVerticalMerge(DXW.PreviousTableCellProperties openXmlElement, DMW.MergedCellKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalMerge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.VerticalMerge, DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  private static DMW.TableCellBorders? GetTableCellBorders(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellBorders>();
    if (itemElement != null)
      return DMXW.TableCellBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellBorders(DXW.PreviousTableCellProperties openXmlElement, DMW.TableCellBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellBordersConverter.CreateOpenXmlElement<DXW.TableCellBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      return DMXW.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShading(DXW.PreviousTableCellProperties openXmlElement, DMW.Shading? value)
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
  private static DMW.OnOffOnlyKind? GetNoWrap(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoWrap>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNoWrap(DXW.PreviousTableCellProperties openXmlElement, DMW.OnOffOnlyKind? value)
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
  private static DMW.TableCellMargin? GetTableCellMargin(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellMargin>();
    if (itemElement != null)
      return DMXW.TableCellMarginConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellMargin(DXW.PreviousTableCellProperties openXmlElement, DMW.TableCellMargin? value)
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
  /// TextDirection.
  /// </summary>
  private static DMW.TextDirectionKind? GetTextDirection(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTextDirection(DXW.PreviousTableCellProperties openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellFitText.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetTableCellFitText(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellFitText>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableCellFitText(DXW.PreviousTableCellProperties openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellFitText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TableCellFitText, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  private static DMW.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableCellVerticalAlignment(DXW.PreviousTableCellProperties openXmlElement, DMW.TableVerticalAlignmentKind? value)
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
  
  /// <summary>
  /// HideMark.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetHideMark(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HideMark>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideMark(DXW.PreviousTableCellProperties openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HideMark>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.HideMark, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCellInsertion(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CellInsertion>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCellInsertion(DXW.PreviousTableCellProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CellInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CellInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCellDeletion(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CellDeletion>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCellDeletion(DXW.PreviousTableCellProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CellDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CellDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CellMerge? GetCellMerge(DXW.PreviousTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CellMerge>();
    if (itemElement != null)
      return DMXW.CellMergeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCellMerge(DXW.PreviousTableCellProperties openXmlElement, DMW.CellMerge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CellMerge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CellMergeConverter.CreateOpenXmlElement<DXW.CellMerge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.PreviousTableCellProperties? CreateModelElement(DXW.PreviousTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousTableCellProperties();
      value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
      value.TableCellWidth = GetTableCellWidth(openXmlElement);
      value.GridSpan = GetGridSpan(openXmlElement);
      value.HorizontalMerge = GetHorizontalMerge(openXmlElement);
      value.VerticalMerge = GetVerticalMerge(openXmlElement);
      value.TableCellBorders = GetTableCellBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.NoWrap = GetNoWrap(openXmlElement);
      value.TableCellMargin = GetTableCellMargin(openXmlElement);
      value.TextDirection = GetTextDirection(openXmlElement);
      value.TableCellFitText = GetTableCellFitText(openXmlElement);
      value.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
      value.HideMark = GetHideMark(openXmlElement);
      value.CellInsertion = GetCellInsertion(openXmlElement);
      value.CellDeletion = GetCellDeletion(openXmlElement);
      value.CellMerge = GetCellMerge(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableCellProperties? value)
    where OpenXmlElementType: DXW.PreviousTableCellProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
      SetTableCellWidth(openXmlElement, value?.TableCellWidth);
      SetGridSpan(openXmlElement, value?.GridSpan);
      SetHorizontalMerge(openXmlElement, value?.HorizontalMerge);
      SetVerticalMerge(openXmlElement, value?.VerticalMerge);
      SetTableCellBorders(openXmlElement, value?.TableCellBorders);
      SetShading(openXmlElement, value?.Shading);
      SetNoWrap(openXmlElement, value?.NoWrap);
      SetTableCellMargin(openXmlElement, value?.TableCellMargin);
      SetTextDirection(openXmlElement, value?.TextDirection);
      SetTableCellFitText(openXmlElement, value?.TableCellFitText);
      SetTableCellVerticalAlignment(openXmlElement, value?.TableCellVerticalAlignment);
      SetHideMark(openXmlElement, value?.HideMark);
      SetCellInsertion(openXmlElement, value?.CellInsertion);
      SetCellDeletion(openXmlElement, value?.CellDeletion);
      SetCellMerge(openXmlElement, value?.CellMerge);
      return openXmlElement;
    }
    return default;
  }
}
