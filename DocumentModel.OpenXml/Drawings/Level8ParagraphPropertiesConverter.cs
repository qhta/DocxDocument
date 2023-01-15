using DocumentFormat.OpenXml.Drawing;
using AutoNumberedBullet = DocumentModel.Drawings.AutoNumberedBullet;
using BulletColor = DocumentModel.Drawings.BulletColor;
using CharacterBullet = DocumentModel.Drawings.CharacterBullet;
using DefaultRunProperties = DocumentModel.Drawings.DefaultRunProperties;
using Level8ParagraphProperties = DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties;
using LineSpacing = DocumentModel.Drawings.LineSpacing;
using PictureBullet = DocumentModel.Drawings.PictureBullet;
using SpaceAfter = DocumentModel.Drawings.SpaceAfter;
using SpaceBefore = DocumentModel.Drawings.SpaceBefore;
using TabStopList = DocumentModel.Drawings.TabStopList;
using TextFontType = DocumentModel.Drawings.TextFontType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   List Level 8 Text Style.
/// </summary>
public static class Level8ParagraphPropertiesConverter
{
  public static LineSpacing? GetLineSpacing(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
    if (itemElement != null)
      return LineSpacingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineSpacing(Level8ParagraphProperties? openXmlElement, LineSpacing? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSpacingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineSpacing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SpaceBefore? GetSpaceBefore(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
    if (itemElement != null)
      return SpaceBeforeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSpaceBefore(Level8ParagraphProperties? openXmlElement, SpaceBefore? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceBeforeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SpaceBefore>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SpaceAfter? GetSpaceAfter(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
    if (itemElement != null)
      return SpaceAfterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSpaceAfter(Level8ParagraphProperties? openXmlElement, SpaceAfter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceAfterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SpaceAfter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBulletColorText(Level8ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BulletColorText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBulletColorText(Level8ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BulletColorText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BulletColorText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BulletColor? GetBulletColor(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletColor>();
    if (itemElement != null)
      return BulletColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBulletColor(Level8ParagraphProperties? openXmlElement, BulletColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BulletColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BulletColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBulletSizeText(Level8ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BulletSizeText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBulletSizeText(Level8ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BulletSizeText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BulletSizeText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetBulletSizePercentage(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BulletSizePercentage>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBulletSizePercentage(Level8ParagraphProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BulletSizePercentage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BulletSizePercentage { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetBulletSizePoints(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BulletSizePoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBulletSizePoints(Level8ParagraphProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BulletSizePoints>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BulletSizePoints { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBulletFontText(Level8ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BulletFontText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBulletFontText(Level8ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BulletFontText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BulletFontText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextFontType? GetBulletFont(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BulletFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBulletFont(Level8ParagraphProperties? openXmlElement, TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BulletFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFontTypeConverter.CreateOpenXmlElement<BulletFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetNoBullet(Level8ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoBullet>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoBullet(Level8ParagraphProperties? openXmlElement, Boolean? value)
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

  public static AutoNumberedBullet? GetAutoNumberedBullet(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
    if (itemElement != null)
      return AutoNumberedBulletConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAutoNumberedBullet(Level8ParagraphProperties? openXmlElement, AutoNumberedBullet? value)
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

  public static CharacterBullet? GetCharacterBullet(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
    if (itemElement != null)
      return CharacterBulletConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCharacterBullet(Level8ParagraphProperties? openXmlElement, CharacterBullet? value)
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

  public static PictureBullet? GetPictureBullet(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
    if (itemElement != null)
      return PictureBulletConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPictureBullet(Level8ParagraphProperties? openXmlElement, PictureBullet? value)
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

  public static TabStopList? GetTabStopList(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TabStopList>();
    if (itemElement != null)
      return TabStopListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTabStopList(Level8ParagraphProperties? openXmlElement, TabStopList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TabStopList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TabStopListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TabStopList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DefaultRunProperties? GetDefaultRunProperties(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>();
    if (itemElement != null)
      return DefaultRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDefaultRunProperties(Level8ParagraphProperties? openXmlElement, DefaultRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DefaultRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(Level8ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Level8ParagraphProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Level8ParagraphProperties? CreateModelElement(Level8ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Level8ParagraphProperties();
      value.LineSpacing = GetLineSpacing(openXmlElement);
      value.SpaceBefore = GetSpaceBefore(openXmlElement);
      value.SpaceAfter = GetSpaceAfter(openXmlElement);
      value.BulletColorText = GetBulletColorText(openXmlElement);
      value.BulletColor = GetBulletColor(openXmlElement);
      value.BulletSizeText = GetBulletSizeText(openXmlElement);
      value.BulletSizePercentage = GetBulletSizePercentage(openXmlElement);
      value.BulletSizePoints = GetBulletSizePoints(openXmlElement);
      value.BulletFontText = GetBulletFontText(openXmlElement);
      value.BulletFont = GetBulletFont(openXmlElement);
      value.NoBullet = GetNoBullet(openXmlElement);
      value.AutoNumberedBullet = GetAutoNumberedBullet(openXmlElement);
      value.CharacterBullet = GetCharacterBullet(openXmlElement);
      value.PictureBullet = GetPictureBullet(openXmlElement);
      value.TabStopList = GetTabStopList(openXmlElement);
      value.DefaultRunProperties = GetDefaultRunProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Level8ParagraphProperties? value)
    where OpenXmlElementType : Level8ParagraphProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineSpacing(openXmlElement, value?.LineSpacing);
      SetSpaceBefore(openXmlElement, value?.SpaceBefore);
      SetSpaceAfter(openXmlElement, value?.SpaceAfter);
      SetBulletColorText(openXmlElement, value?.BulletColorText);
      SetBulletColor(openXmlElement, value?.BulletColor);
      SetBulletSizeText(openXmlElement, value?.BulletSizeText);
      SetBulletSizePercentage(openXmlElement, value?.BulletSizePercentage);
      SetBulletSizePoints(openXmlElement, value?.BulletSizePoints);
      SetBulletFontText(openXmlElement, value?.BulletFontText);
      SetBulletFont(openXmlElement, value?.BulletFont);
      SetNoBullet(openXmlElement, value?.NoBullet);
      SetAutoNumberedBullet(openXmlElement, value?.AutoNumberedBullet);
      SetCharacterBullet(openXmlElement, value?.CharacterBullet);
      SetPictureBullet(openXmlElement, value?.PictureBullet);
      SetTabStopList(openXmlElement, value?.TabStopList);
      SetDefaultRunProperties(openXmlElement, value?.DefaultRunProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}