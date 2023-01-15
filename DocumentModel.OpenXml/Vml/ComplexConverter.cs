using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using Complex = DocumentFormat.OpenXml.Vml.Office.Complex;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Complex.
/// </summary>
public static class ComplexConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(Complex? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(Complex? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  public static DocumentModel.Vml.Complex? CreateModelElement(Complex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Complex();
      value.Extension = GetExtension(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Complex? value)
    where OpenXmlElementType : Complex, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      return openXmlElement;
    }
    return default;
  }
}