using DocumentModel.Wordprocessing;
using RunPropertiesDefault = DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Default Run Properties.
/// </summary>
public static class RunPropertiesDefaultConverter
{
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public static RunPropertiesBaseStyle? GetRunPropertiesBaseStyle(RunPropertiesDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
    if (itemElement != null)
      return RunPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunPropertiesBaseStyle(RunPropertiesDefault? openXmlElement, RunPropertiesBaseStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesBaseStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.RunPropertiesDefault? CreateModelElement(RunPropertiesDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunPropertiesDefault();
      value.RunPropertiesBaseStyle = GetRunPropertiesBaseStyle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RunPropertiesDefault? value)
    where OpenXmlElementType : RunPropertiesDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunPropertiesBaseStyle(openXmlElement, value?.RunPropertiesBaseStyle);
      return openXmlElement;
    }
    return default;
  }
}