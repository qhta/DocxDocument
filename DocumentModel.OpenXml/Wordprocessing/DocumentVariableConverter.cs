using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Single Document Variable.
/// </summary>
public static class DocumentVariableConverter
{
  /// <summary>
  ///   Document Variable Name
  /// </summary>
  public static String? GetName(DocumentVariable? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(DocumentVariable? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Document Variable Value
  /// </summary>
  public static String? GetVal(DocumentVariable? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(DocumentVariable? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Wordprocessing.DocumentVariable? CreateModelElement(DocumentVariable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocumentVariable();
      value.Name = GetName(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocumentVariable? value)
    where OpenXmlElementType : DocumentVariable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}