using DocumentModel.Math;
using GroupChar = DocumentFormat.OpenXml.Math.GroupChar;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Group-Character Function.
/// </summary>
public static class GroupCharConverter
{
  /// <summary>
  ///   Group-Character Properties.
  /// </summary>
  public static GroupCharProperties? GetGroupCharProperties(GroupChar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.GroupCharProperties>();
    if (itemElement != null)
      return GroupCharPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroupCharProperties(GroupChar? openXmlElement, GroupCharProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GroupCharProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupCharPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.GroupCharProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(GroupChar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(GroupChar? openXmlElement, Base? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.GroupChar? CreateModelElement(GroupChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.GroupChar();
      value.GroupCharProperties = GetGroupCharProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.GroupChar? value)
    where OpenXmlElementType : GroupChar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupCharProperties(openXmlElement, value?.GroupCharProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}