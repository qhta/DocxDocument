namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public static class RelativeHeightConverter
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind? GetRelativeFrom(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  public static void SetRelativeFrom(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement, DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind>(value);
  }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  public static String? GetPercentageHeight(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetPercentageHeight(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Drawings.RelativeHeight? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Drawings.RelativeHeight();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.PercentageHeight = GetPercentageHeight(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Drawings.RelativeHeight? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeFrom(openXmlElement, value?.RelativeFrom);
      SetPercentageHeight(openXmlElement, value?.PercentageHeight);
      return openXmlElement;
    }
    return default;
  }
}
