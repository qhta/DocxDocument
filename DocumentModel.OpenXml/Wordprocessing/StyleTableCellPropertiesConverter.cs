namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Table Cell Properties.
/// </summary>
public static class StyleTableCellPropertiesConverter
{
  /// <summary>
  /// Shading.
  /// </summary>
  public static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShading(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetNoWrap(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoWrap>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNoWrap(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableCellMargin? GetTableCellMargin(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableCellMarginConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTableCellMargin(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement, DocumentModel.Wordprocessing.TableCellMargin? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DocumentModel.Wordprocessing.TableVerticalAlignmentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTableCellVerticalAlignment(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement, DocumentModel.Wordprocessing.TableVerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.StyleTableCellProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StyleTableCellProperties();
      value.Shading = GetShading(openXmlElement);
      value.NoWrap = GetNoWrap(openXmlElement);
      value.TableCellMargin = GetTableCellMargin(openXmlElement);
      value.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StyleTableCellProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties, new()
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
