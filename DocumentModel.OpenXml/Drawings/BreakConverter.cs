using DocumentModel.Drawings;
using Break = DocumentFormat.OpenXml.Drawing.Break;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Text Line Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  ///   Text Run Properties.
  /// </summary>
  public static RunProperties? GetRunProperties(Break? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
    if (itemElement != null)
      return RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunProperties(Break? openXmlElement, RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Break? CreateModelElement(Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Break();
      value.RunProperties = GetRunProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Break? value)
    where OpenXmlElementType : Break, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      return openXmlElement;
    }
    return default;
  }
}