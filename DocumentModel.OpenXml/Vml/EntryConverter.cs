using DocumentFormat.OpenXml.Vml.Office;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Regroup Entry.
/// </summary>
public static class EntryConverter
{
  /// <summary>
  ///   New Group ID
  /// </summary>
  public static Int32? GetNew(Entry? openXmlElement)
  {
    return openXmlElement?.New?.Value;
  }

  public static void SetNew(Entry? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.New = value;
  }

  /// <summary>
  ///   Old Group ID
  /// </summary>
  public static Int32? GetOld(Entry? openXmlElement)
  {
    return openXmlElement?.Old?.Value;
  }

  public static void SetOld(Entry? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Old = value;
  }

  public static DocumentModel.Vml.Entry? CreateModelElement(Entry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Entry();
      value.New = GetNew(openXmlElement);
      value.Old = GetOld(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Entry? value)
    where OpenXmlElementType : Entry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNew(openXmlElement, value?.New);
      SetOld(openXmlElement, value?.Old);
      return openXmlElement;
    }
    return default;
  }
}