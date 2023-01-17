namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Cell Properties.
/// </summary>
public static class TableCellPropertiesConverter
{
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  private static DocumentModel.Wordprocessing.ConditionalFormatStyle? GetConditionalFormatStyle(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ConditionalFormatStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConditionalFormatStyle(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.ConditionalFormatStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ConditionalFormatStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellWidth.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableWidthType? GetTableCellWidth(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellWidth>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellWidth(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellWidth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GridSpan.
  /// </summary>
  private static Int32? GetGridSpan(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GridSpan>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGridSpan(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GridSpan>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.GridSpan{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// HorizontalMerge.
  /// </summary>
  private static DocumentModel.Wordprocessing.MergedCellKind? GetHorizontalMerge(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HorizontalMerge>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DocumentModel.Wordprocessing.MergedCellKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHorizontalMerge(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.MergedCellKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HorizontalMerge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HorizontalMerge, DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DocumentModel.Wordprocessing.MergedCellKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VerticalMerge.
  /// </summary>
  private static DocumentModel.Wordprocessing.MergedCellKind? GetVerticalMerge(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalMerge>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DocumentModel.Wordprocessing.MergedCellKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetVerticalMerge(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.MergedCellKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalMerge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalMerge, DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DocumentModel.Wordprocessing.MergedCellKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableCellBorders? GetTableCellBorders(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableCellBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellBorders(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.TableCellBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableCellBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShading(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetNoWrap(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoWrap>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNoWrap(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoWrap, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableCellMargin? GetTableCellMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableCellMarginConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.TableCellMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableCellMarginConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  private static DocumentModel.Wordprocessing.TextDirectionKind? GetTextDirection(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DocumentModel.Wordprocessing.TextDirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTextDirection(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DocumentModel.Wordprocessing.TextDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellFitText.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetTableCellFitText(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellFitText>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableCellFitText(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellFitText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellFitText, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DocumentModel.Wordprocessing.TableVerticalAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableCellVerticalAlignment(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.TableVerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment, DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DocumentModel.Wordprocessing.TableVerticalAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// HideMark.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetHideMark(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideMark>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideMark(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideMark>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HideMark, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCellInsertion(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CellInsertion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCellInsertion(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CellInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CellInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCellDeletion(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CellDeletion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCellDeletion(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CellDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CellDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.CellMerge? GetCellMerge(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CellMerge>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CellMergeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCellMerge(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.CellMerge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CellMerge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.CellMergeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CellMerge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TableCellPropertiesChange? GetTableCellPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableCellPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties openXmlElement, DocumentModel.Wordprocessing.TableCellPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableCellPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TableCellProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableCellProperties();
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
      value.TableCellPropertiesChange = GetTableCellPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableCellProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableCellProperties, new()
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
      SetTableCellPropertiesChange(openXmlElement, value?.TableCellPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}
