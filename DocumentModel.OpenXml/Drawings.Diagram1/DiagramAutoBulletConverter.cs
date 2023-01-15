using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2019.Drawing.Diagram11;
using AutoNumberedBullet = DocumentModel.Drawings.AutoNumberedBullet;
using CharacterBullet = DocumentModel.Drawings.CharacterBullet;
using PictureBullet = DocumentModel.Drawings.PictureBullet;

namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
///   Defines the DiagramAutoBullet Class.
/// </summary>
public static class DiagramAutoBulletConverter
{
  /// <summary>
  ///   prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public static String? GetAutoBulletPrefix(DiagramAutoBullet? openXmlElement)
  {
    return openXmlElement?.AutoBulletPrefix?.Value;
  }

  public static void SetAutoBulletPrefix(DiagramAutoBullet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AutoBulletPrefix = new StringValue { Value = value };
      else
        openXmlElement.AutoBulletPrefix = null;
  }

  /// <summary>
  ///   leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  public static Boolean? GetLeadZeros(DiagramAutoBullet? openXmlElement)
  {
    return openXmlElement?.LeadZeros?.Value;
  }

  public static void SetLeadZeros(DiagramAutoBullet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LeadZeros = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LeadZeros = null;
  }

  /// <summary>
  ///   No Bullet.
  /// </summary>
  public static Boolean? GetNoBullet(DiagramAutoBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoBullet>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoBullet(DiagramAutoBullet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoBullet>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoBullet();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Auto-Numbered Bullet.
  /// </summary>
  public static AutoNumberedBullet? GetAutoNumberedBullet(DiagramAutoBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
    if (itemElement != null)
      return AutoNumberedBulletConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAutoNumberedBullet(DiagramAutoBullet? openXmlElement, AutoNumberedBullet? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoNumberedBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Character Bullet.
  /// </summary>
  public static CharacterBullet? GetCharacterBullet(DiagramAutoBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
    if (itemElement != null)
      return CharacterBulletConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCharacterBullet(DiagramAutoBullet? openXmlElement, CharacterBullet? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CharacterBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CharacterBullet>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Picture Bullet.
  /// </summary>
  public static PictureBullet? GetPictureBullet(DiagramAutoBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
    if (itemElement != null)
      return PictureBulletConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPictureBullet(DiagramAutoBullet? openXmlElement, PictureBullet? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PictureBullet>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagram1.DiagramAutoBullet? CreateModelElement(DiagramAutoBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram1.DiagramAutoBullet();
      value.AutoBulletPrefix = GetAutoBulletPrefix(openXmlElement);
      value.LeadZeros = GetLeadZeros(openXmlElement);
      value.NoBullet = GetNoBullet(openXmlElement);
      value.AutoNumberedBullet = GetAutoNumberedBullet(openXmlElement);
      value.CharacterBullet = GetCharacterBullet(openXmlElement);
      value.PictureBullet = GetPictureBullet(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagram1.DiagramAutoBullet? value)
    where OpenXmlElementType : DiagramAutoBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAutoBulletPrefix(openXmlElement, value?.AutoBulletPrefix);
      SetLeadZeros(openXmlElement, value?.LeadZeros);
      SetNoBullet(openXmlElement, value?.NoBullet);
      SetAutoNumberedBullet(openXmlElement, value?.AutoNumberedBullet);
      SetCharacterBullet(openXmlElement, value?.CharacterBullet);
      SetPictureBullet(openXmlElement, value?.PictureBullet);
      return openXmlElement;
    }
    return default;
  }
}