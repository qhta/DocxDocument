namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public static class DivBorderConverter
{
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetTopBorder(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopBorder(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  /// Left Border for HTML div.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  /// Bottom Border for HTML div.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  /// Right Border for HTML div.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetRightBorder(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightBorder(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  
  public static DocumentModel.Wordprocessing.DivBorder? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DivBorder? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DivBorder();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DivBorder? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DivBorder, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      return openXmlElement;
    }
    return default;
  }
}
