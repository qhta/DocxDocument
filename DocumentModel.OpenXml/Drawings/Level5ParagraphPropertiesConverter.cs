namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List Level 5 Text Style.
/// </summary>
public static class Level5ParagraphPropertiesConverter
{
  public static DocumentModel.Drawings.LineSpacing? GetLineSpacing(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineSpacingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineSpacing(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.LineSpacing? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.SpaceBefore? GetSpaceBefore(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SpaceBeforeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSpaceBefore(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.SpaceBefore? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.SpaceAfter? GetSpaceAfter(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SpaceAfterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSpaceAfter(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.SpaceAfter? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetBulletColorText(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletColorText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBulletColorText(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.BulletColor? GetBulletColor(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BulletColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBulletColor(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.BulletColor? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetBulletSizeText(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizeText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBulletSizeText(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Int32? GetBulletSizePercentage(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizePercentage>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetBulletSizePercentage(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Int32? GetBulletSizePoints(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletSizePoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetBulletSizePoints(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetBulletFontText(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletFontText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBulletFontText(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.TextFontType? GetBulletFont(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BulletFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBulletFont(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetNoBullet(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoBullet(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.AutoNumberedBullet? GetAutoNumberedBullet(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AutoNumberedBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAutoNumberedBullet(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.AutoNumberedBullet? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.CharacterBullet? GetCharacterBullet(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CharacterBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCharacterBullet(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.CharacterBullet? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.PictureBullet? GetPictureBullet(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PictureBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPictureBullet(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.PictureBullet? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.TabStopList? GetTabStopList(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TabStopList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TabStopListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTabStopList(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.TabStopList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.DefaultRunProperties? GetDefaultRunProperties(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.DefaultRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDefaultRunProperties(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.DefaultRunProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Level5ParagraphProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Level5ParagraphProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Level5ParagraphProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties, new()
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
