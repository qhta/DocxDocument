using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Effect.
/// </summary>
public static class EffectConverter
{
  /// <summary>
  ///   Reference
  /// </summary>
  public static String? GetReference(Effect? openXmlElement)
  {
    return openXmlElement?.Reference?.Value;
  }

  public static void SetReference(Effect? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Reference = new StringValue { Value = value };
      else
        openXmlElement.Reference = null;
  }

  public static DocumentModel.Drawings.Effect? CreateModelElement(Effect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Effect();
      value.Reference = GetReference(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Effect? value)
    where OpenXmlElementType : Effect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetReference(openXmlElement, value?.Reference);
      return openXmlElement;
    }
    return default;
  }
}