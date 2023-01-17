namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List Level 2 Text Style.
/// </summary>
public static class Level2ParagraphPropertiesConverter
{
  private static DocumentModel.Drawings.LineSpacing? GetLineSpacing(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineSpacingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineSpacing(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.LineSpacing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.LineSpacingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.SpaceBefore? GetSpaceBefore(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SpaceBeforeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSpaceBefore(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.SpaceBefore? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.SpaceBeforeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SpaceBefore>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.SpaceAfter? GetSpaceAfter(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SpaceAfterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSpaceAfter(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.SpaceAfter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.SpaceAfterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SpaceAfter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBulletColorText(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletColorText>();
    return itemElement != null;
  }
  
  private static void SetBulletColorText(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletColorText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.BulletColorText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.BulletColor? GetBulletColor(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BulletColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBulletColor(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.BulletColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BulletColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BulletColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBulletSizeText(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizeText>();
    return itemElement != null;
  }
  
  private static void SetBulletSizeText(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizeText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.BulletSizeText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBulletSizePercentage(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizePercentage>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBulletSizePercentage(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizePercentage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.BulletSizePercentage{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBulletSizePoints(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizePoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBulletSizePoints(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizePoints>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.BulletSizePoints{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBulletFontText(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletFontText>();
    return itemElement != null;
  }
  
  private static void SetBulletFontText(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletFontText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.BulletFontText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.TextFontType? GetBulletFont(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBulletFont(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BulletFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoBullet(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
    return itemElement != null;
  }
  
  private static void SetNoBullet(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.NoBullet();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AutoNumberedBullet? GetAutoNumberedBullet(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AutoNumberedBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAutoNumberedBullet(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.AutoNumberedBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AutoNumberedBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.CharacterBullet? GetCharacterBullet(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CharacterBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCharacterBullet(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.CharacterBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.CharacterBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CharacterBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.PictureBullet? GetPictureBullet(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PictureBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureBullet(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.PictureBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PictureBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PictureBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.TabStopList? GetTabStopList(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TabStopList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TabStopListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTabStopList(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.TabStopList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TabStopList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.TabStopListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TabStopList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.DefaultRunProperties? GetDefaultRunProperties(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.DefaultRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDefaultRunProperties(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.DefaultRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.DefaultRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Level2ParagraphProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Level2ParagraphProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Level2ParagraphProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties, new()
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
