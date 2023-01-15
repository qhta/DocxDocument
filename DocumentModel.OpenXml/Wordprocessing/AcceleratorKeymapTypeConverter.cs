using DocumentFormat.OpenXml.Office.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the AcceleratorKeymapType Class.
/// </summary>
public static class AcceleratorKeymapTypeConverter
{
  /// <summary>
  ///   acdName
  /// </summary>
  public static String? GetAcceleratorName(AcceleratorKeymapType? openXmlElement)
  {
    return openXmlElement?.AcceleratorName?.Value;
  }

  public static void SetAcceleratorName(AcceleratorKeymapType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AcceleratorName = new StringValue { Value = value };
      else
        openXmlElement.AcceleratorName = null;
  }

  public static DocumentModel.Wordprocessing.AcceleratorKeymapType? CreateModelElement(AcceleratorKeymapType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AcceleratorKeymapType();
      value.AcceleratorName = GetAcceleratorName(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AcceleratorKeymapType? value)
    where OpenXmlElementType : AcceleratorKeymapType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAcceleratorName(openXmlElement, value?.AcceleratorName);
      return openXmlElement;
    }
    return default;
  }
}