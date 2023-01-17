namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public static class CommentExtensibleConverter
{
  /// <summary>
  /// durableId, this property is only available in Office 2021 and later.
  /// </summary>
  private static UInt32? GetDurableId(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement)
  {
    if (openXmlElement.DurableId?.Value != null)
      return UInt32.Parse(openXmlElement.DurableId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetDurableId(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.DurableId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.DurableId = null;
  }
  
  /// <summary>
  /// dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetDateUtc(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement)
  {
    return openXmlElement.DateUtc?.Value;
  }
  
  private static void SetDateUtc(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement, DateTime? value)
  {
    openXmlElement.DateUtc = value;
  }
  
  /// <summary>
  /// intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  private static Boolean? GetIntelligentPlaceholder(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement)
  {
    return openXmlElement?.IntelligentPlaceholder?.Value;
  }
  
  private static void SetIntelligentPlaceholder(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IntelligentPlaceholder = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.IntelligentPlaceholder = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Wordprocessing.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement, DocumentModel.Wordprocessing.ExtensionList? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDurableId(openXmlElement, value?.DurableId);
      SetDateUtc(openXmlElement, value?.DateUtc);
      SetIntelligentPlaceholder(openXmlElement, value?.IntelligentPlaceholder);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
