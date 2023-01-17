namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
public static class PageBordersConverter
{
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  private static DocumentModel.Wordprocessing.PageBorderZOrderKind? GetZOrder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues, DocumentModel.Wordprocessing.PageBorderZOrderKind>(openXmlElement?.ZOrder?.Value);
  }
  
  private static void SetZOrder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement, DocumentModel.Wordprocessing.PageBorderZOrderKind? value)
  {
    openXmlElement.ZOrder = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues, DocumentModel.Wordprocessing.PageBorderZOrderKind>(value);
  }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  private static DocumentModel.Wordprocessing.PageBorderDisplayKind? GetDisplay(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues, DocumentModel.Wordprocessing.PageBorderDisplayKind>(openXmlElement?.Display?.Value);
  }
  
  private static void SetDisplay(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement, DocumentModel.Wordprocessing.PageBorderDisplayKind? value)
  {
    openXmlElement.Display = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues, DocumentModel.Wordprocessing.PageBorderDisplayKind>(value);
  }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  private static DocumentModel.Wordprocessing.PageBorderOffsetKind? GetOffsetFrom(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues, DocumentModel.Wordprocessing.PageBorderOffsetKind>(openXmlElement?.OffsetFrom?.Value);
  }
  
  private static void SetOffsetFrom(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement, DocumentModel.Wordprocessing.PageBorderOffsetKind? value)
  {
    openXmlElement.OffsetFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues, DocumentModel.Wordprocessing.PageBorderOffsetKind>(value);
  }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetTopBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetRightBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.PageBorders? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PageBorders();
      value.ZOrder = GetZOrder(openXmlElement);
      value.Display = GetDisplay(openXmlElement);
      value.OffsetFrom = GetOffsetFrom(openXmlElement);
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PageBorders? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PageBorders, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetZOrder(openXmlElement, value?.ZOrder);
      SetDisplay(openXmlElement, value?.Display);
      SetOffsetFrom(openXmlElement, value?.OffsetFrom);
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      return openXmlElement;
    }
    return default;
  }
}
