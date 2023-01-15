using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using BevelType = DocumentFormat.OpenXml.Office2010.Word.BevelType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetWidth(BevelType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(BevelType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   h, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetHeight(BevelType? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }

  public static void SetHeight(BevelType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }

  /// <summary>
  ///   prst, this property is only available in Office 2010 and later.
  /// </summary>
  public static BevelPresetKind? GetPresetProfileType(BevelType? openXmlElement)
  {
    return EnumValueConverter.GetValue<BevelPresetTypeValues, BevelPresetKind>(openXmlElement?.PresetProfileType?.Value);
  }

  public static void SetPresetProfileType(BevelType? openXmlElement, BevelPresetKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetProfileType = EnumValueConverter.CreateEnumValue<BevelPresetTypeValues, BevelPresetKind>(value);
  }

  public static DocumentModel.Wordprocessing.BevelType? CreateModelElement(BevelType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.BevelType();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.PresetProfileType = GetPresetProfileType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.BevelType? value)
    where OpenXmlElementType : BevelType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetPresetProfileType(openXmlElement, value?.PresetProfileType);
      return openXmlElement;
    }
    return default;
  }
}