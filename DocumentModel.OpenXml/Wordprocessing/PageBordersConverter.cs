namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
public static class PageBordersConverter
{
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  public static DocumentModel.Wordprocessing.PageBorderZOrderKind? GetZOrder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues, DocumentModel.Wordprocessing.PageBorderZOrderKind>(openXmlElement?.ZOrder?.Value);
  }
  
  public static void SetZOrder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.PageBorderZOrderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ZOrder = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues, DocumentModel.Wordprocessing.PageBorderZOrderKind>(value);
  }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  public static DocumentModel.Wordprocessing.PageBorderDisplayKind? GetDisplay(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues, DocumentModel.Wordprocessing.PageBorderDisplayKind>(openXmlElement?.Display?.Value);
  }
  
  public static void SetDisplay(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.PageBorderDisplayKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Display = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues, DocumentModel.Wordprocessing.PageBorderDisplayKind>(value);
  }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  public static DocumentModel.Wordprocessing.PageBorderOffsetKind? GetOffsetFrom(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues, DocumentModel.Wordprocessing.PageBorderOffsetKind>(openXmlElement?.OffsetFrom?.Value);
  }
  
  public static void SetOffsetFrom(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.PageBorderOffsetKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.OffsetFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues, DocumentModel.Wordprocessing.PageBorderOffsetKind>(value);
  }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetTopBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTopBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetRightBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRightBorder(DocumentFormat.OpenXml.Wordprocessing.PageBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
