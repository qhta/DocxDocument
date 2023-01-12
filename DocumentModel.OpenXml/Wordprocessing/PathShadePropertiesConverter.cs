namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public static class PathShadePropertiesConverter
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.PathShadeKind? GetPath(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DocumentModel.Wordprocessing.PathShadeKind>(openXmlElement?.Path?.Value);
  }
  
  public static void SetPath(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement, DocumentModel.Wordprocessing.PathShadeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Path = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DocumentModel.Wordprocessing.PathShadeKind>(value);
  }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  public static DocumentModel.Wordprocessing.FillToRectangle? GetFillToRectangle(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillToRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FillToRectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillToRectangle(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement, DocumentModel.Wordprocessing.FillToRectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillToRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.FillToRectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.FillToRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.PathShadeProperties? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PathShadeProperties();
      value.Path = GetPath(openXmlElement);
      value.FillToRectangle = GetFillToRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PathShadeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPath(openXmlElement, value?.Path);
      SetFillToRectangle(openXmlElement, value?.FillToRectangle);
      return openXmlElement;
    }
    return default;
  }
}
