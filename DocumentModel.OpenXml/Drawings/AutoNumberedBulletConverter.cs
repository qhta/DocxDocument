using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using AutoNumberedBullet = DocumentFormat.OpenXml.Drawing.AutoNumberedBullet;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Auto-Numbered Bullet.
/// </summary>
public static class AutoNumberedBulletConverter
{
  /// <summary>
  ///   Bullet Autonumbering Type
  /// </summary>
  public static TextAutoNumberSchemeKind? GetType(AutoNumberedBullet? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextAutoNumberSchemeValues, TextAutoNumberSchemeKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(AutoNumberedBullet? openXmlElement, TextAutoNumberSchemeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<TextAutoNumberSchemeValues, TextAutoNumberSchemeKind>(value);
  }

  /// <summary>
  ///   Start Numbering At
  /// </summary>
  public static Int32? GetStartAt(AutoNumberedBullet? openXmlElement)
  {
    return openXmlElement?.StartAt?.Value;
  }

  public static void SetStartAt(AutoNumberedBullet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartAt = value;
  }

  public static DocumentModel.Drawings.AutoNumberedBullet? CreateModelElement(AutoNumberedBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AutoNumberedBullet();
      value.Type = GetType(openXmlElement);
      value.StartAt = GetStartAt(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AutoNumberedBullet? value)
    where OpenXmlElementType : AutoNumberedBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetStartAt(openXmlElement, value?.StartAt);
      return openXmlElement;
    }
    return default;
  }
}