using DocumentFormat.OpenXml.Office2021.Word.CommentsExt;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the CommentExtensible Class.
/// </summary>
public static class CommentExtensibleConverter
{
  /// <summary>
  ///   durableId, this property is only available in Office 2021 and later.
  /// </summary>
  public static Byte[]? GetDurableId(CommentExtensible? openXmlElement)
  {
    if (openXmlElement?.DurableId?.Value != null)
      return Convert.FromHexString(openXmlElement.DurableId.Value);
    return null;
  }

  public static void SetDurableId(CommentExtensible? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.DurableId = Convert.ToHexString(value);
      else
        openXmlElement.DurableId = null;
    }
  }

  /// <summary>
  ///   dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  public static DateTime? GetDateUtc(CommentExtensible? openXmlElement)
  {
    return openXmlElement?.DateUtc?.Value;
  }

  public static void SetDateUtc(CommentExtensible? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.DateUtc = value;
  }

  /// <summary>
  ///   intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  public static Boolean? GetIntelligentPlaceholder(CommentExtensible? openXmlElement)
  {
    return openXmlElement?.IntelligentPlaceholder?.Value;
  }

  public static void SetIntelligentPlaceholder(CommentExtensible? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IntelligentPlaceholder = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.IntelligentPlaceholder = null;
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Wordprocessing.ExtensionList? GetExtensionList(CommentExtensible? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(CommentExtensible? openXmlElement, DocumentModel.Wordprocessing.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.CommentExtensible? CreateModelElement(CommentExtensible? openXmlElement)
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
    where OpenXmlElementType : CommentExtensible, new()
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