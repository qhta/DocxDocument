namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
public static class TableCellMarginDefaultConverter
{
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetTopMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTopMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TopMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthDxaNilType? GetTableCellLeftMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthDxaNilTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTableCellLeftMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement, DocumentModel.Wordprocessing.TableWidthDxaNilType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthDxaNilTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellLeftMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetStartMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StartMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStartMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StartMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StartMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Table Cell Bottom Margin Default.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetBottomMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBottomMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BottomMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthDxaNilType? GetTableCellRightMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthDxaNilTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTableCellRightMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement, DocumentModel.Wordprocessing.TableWidthDxaNilType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthDxaNilTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellRightMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetEndMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEndMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TableCellMarginDefault? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableCellMarginDefault();
      value.TopMargin = GetTopMargin(openXmlElement);
      value.TableCellLeftMargin = GetTableCellLeftMargin(openXmlElement);
      value.StartMargin = GetStartMargin(openXmlElement);
      value.BottomMargin = GetBottomMargin(openXmlElement);
      value.TableCellRightMargin = GetTableCellRightMargin(openXmlElement);
      value.EndMargin = GetEndMargin(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableCellMarginDefault? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopMargin(openXmlElement, value?.TopMargin);
      SetTableCellLeftMargin(openXmlElement, value?.TableCellLeftMargin);
      SetStartMargin(openXmlElement, value?.StartMargin);
      SetBottomMargin(openXmlElement, value?.BottomMargin);
      SetTableCellRightMargin(openXmlElement, value?.TableCellRightMargin);
      SetEndMargin(openXmlElement, value?.EndMargin);
      return openXmlElement;
    }
    return default;
  }
}
