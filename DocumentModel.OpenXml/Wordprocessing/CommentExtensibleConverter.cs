namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public static class CommentExtensibleConverter
{
  /// <summary>
  /// durableId, this property is only available in Office 2021 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetDurableId(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetDurableId(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  public static DateTime? GetDateUtc(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement)
  {
    return openXmlElement?.DateUtc?.Value;
  }
  
  public static void SetDateUtc(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.DateUtc = value;
  }
  
  /// <summary>
  /// intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  public static Boolean? GetIntelligentPlaceholder(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement)
  {
    return openXmlElement?.IntelligentPlaceholder?.Value;
  }
  
  public static void SetIntelligentPlaceholder(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IntelligentPlaceholder = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.IntelligentPlaceholder = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Wordprocessing.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement, DocumentModel.Wordprocessing.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CommentExtensible? CreateModelElement(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentExtensible();
      value.DurableId = GetDurableId(openXmlElement);
      value.DateUtc = GetDateUtc(openXmlElement);
      value.IntelligentPlaceholder = GetIntelligentPlaceholder(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CommentExtensible? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
