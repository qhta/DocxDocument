using DocumentFormat.OpenXml.Drawing;
using Run = DocumentFormat.OpenXml.Drawing.Run;
using RunProperties = DocumentModel.Drawings.RunProperties;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Text Run.
/// </summary>
public static class RunConverter
{
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  public static RunProperties? GetRunProperties(Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
    if (itemElement != null)
      return RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunProperties(Run? openXmlElement, RunProperties? value)
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

  /// <summary>
  ///   Text String.
  /// </summary>
  public static String? GetText(Run? openXmlElement)
  {
    return openXmlElement?.Text?.Text;
  }

  public static void SetText(Run? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Text = new Text(value);
      else
        openXmlElement.Text = null;
    }
  }

  public static DocumentModel.Drawings.Run? CreateModelElement(Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Run();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.Text = GetText(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Run? value)
    where OpenXmlElementType : Run, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetText(openXmlElement, value?.Text);
      return openXmlElement;
    }
    return default;
  }
}