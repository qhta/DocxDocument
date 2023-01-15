using DocumentModel.Math;
using Delimiter = DocumentFormat.OpenXml.Math.Delimiter;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Delimiter Function.
/// </summary>
public static class DelimiterConverter
{
  /// <summary>
  ///   Delimiter Properties.
  /// </summary>
  public static DelimiterProperties? GetDelimiterProperties(Delimiter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.DelimiterProperties>();
    if (itemElement != null)
      return DelimiterPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDelimiterProperties(Delimiter? openXmlElement, DelimiterProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DelimiterProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DelimiterPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.DelimiterProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<Base>? GetBases(Delimiter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Base>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.Base>())
      {
        var newItem = BaseConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBases(Delimiter? openXmlElement, Collection<Base>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.Base>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Math.Delimiter? CreateModelElement(Delimiter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Delimiter();
      value.DelimiterProperties = GetDelimiterProperties(openXmlElement);
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Delimiter? value)
    where OpenXmlElementType : Delimiter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDelimiterProperties(openXmlElement, value?.DelimiterProperties);
      SetBases(openXmlElement, value?.Bases);
      return openXmlElement;
    }
    return default;
  }
}