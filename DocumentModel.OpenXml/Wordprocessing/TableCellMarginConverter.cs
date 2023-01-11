namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableCellMargin Class.
/// </summary>
public static class TableCellMarginConverter
{
  /// <summary>
  /// Table Cell Top Margin Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetTopMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTopMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
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
  /// Table Cell Left Margin Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetLeftMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLeftMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LeftMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetStartMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StartMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStartMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
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
  /// Table Cell Bottom Margin Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetBottomMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBottomMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
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
  /// Table Cell Right Margin Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetRightMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRightMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RightMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetEndMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEndMargin(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
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
  
  public static DocumentModel.Wordprocessing.TableCellMargin? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableCellMargin();
      value.TopMargin = GetTopMargin(openXmlElement);
      value.LeftMargin = GetLeftMargin(openXmlElement);
      value.StartMargin = GetStartMargin(openXmlElement);
      value.BottomMargin = GetBottomMargin(openXmlElement);
      value.RightMargin = GetRightMargin(openXmlElement);
      value.EndMargin = GetEndMargin(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableCellMargin? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableCellMargin, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
