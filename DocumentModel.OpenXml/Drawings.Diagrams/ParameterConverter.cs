using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Parameter = DocumentFormat.OpenXml.Drawing.Diagrams.Parameter;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Parameter.
/// </summary>
public static class ParameterConverter
{
  /// <summary>
  ///   Parameter Type
  /// </summary>
  public static ParameterIdKind? GetType(Parameter? openXmlElement)
  {
    return EnumValueConverter.GetValue<ParameterIdValues, ParameterIdKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Parameter? openXmlElement, ParameterIdKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<ParameterIdValues, ParameterIdKind>(value);
  }

  /// <summary>
  ///   Value
  /// </summary>
  public static String? GetVal(Parameter? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(Parameter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Drawings.Diagrams.Parameter? CreateModelElement(Parameter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Parameter();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Parameter? value)
    where OpenXmlElementType : Parameter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}