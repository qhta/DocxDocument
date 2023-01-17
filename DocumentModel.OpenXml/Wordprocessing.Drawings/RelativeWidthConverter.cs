namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public static class RelativeWidthConverter
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind? GetObjectId(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind>(openXmlElement?.ObjectId?.Value);
  }
  
  private static void SetObjectId(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth openXmlElement, DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind? value)
  {
    openXmlElement.ObjectId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues, DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind>(value);
  }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  private static String? GetPercentageWidth(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetPercentageWidth(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Drawings.RelativeWidth? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Drawings.RelativeWidth();
      value.ObjectId = GetObjectId(openXmlElement);
      value.PercentageWidth = GetPercentageWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Drawings.RelativeWidth? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetObjectId(openXmlElement, value?.ObjectId);
      SetPercentageWidth(openXmlElement, value?.PercentageWidth);
      return openXmlElement;
    }
    return default;
  }
}
