namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public static class ParagraphBordersConverter
{
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetTopBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTopBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  /// Left Paragraph Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLeftBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBottomBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  /// Right Paragraph Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetRightBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRightBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetBetweenBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BetweenBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBetweenBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BetweenBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BetweenBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetBarBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BarBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBarBorder(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BarBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BarBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ParagraphBorders? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphBorders();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      value.BetweenBorder = GetBetweenBorder(openXmlElement);
      value.BarBorder = GetBarBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphBorders? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      SetBetweenBorder(openXmlElement, value?.BetweenBorder);
      SetBarBorder(openXmlElement, value?.BarBorder);
      return openXmlElement;
    }
    return default;
  }
}
