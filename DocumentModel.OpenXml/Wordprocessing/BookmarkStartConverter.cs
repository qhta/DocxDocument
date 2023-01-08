namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BookmarkStart Class.
/// </summary>
public static class BookmarkStartConverter
{
  /// <summary>
  /// name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetName(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public static Int32? GetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public static Int32? GetColumnLast(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnLast(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public static DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  public static void SetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
