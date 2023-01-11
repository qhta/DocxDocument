namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
public static class DiagramAutoBulletConverter
{
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  public static String? GetAutoBulletPrefix(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement)
  {
    return openXmlElement?.AutoBulletPrefix?.Value;
  }
  
  public static void SetAutoBulletPrefix(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AutoBulletPrefix = new StringValue { Value = value };
      else
        openXmlElement.AutoBulletPrefix = null;
  }
  
  /// <summary>
  /// leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  public static Boolean? GetLeadZeros(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement)
  {
    return openXmlElement?.LeadZeros?.Value;
  }
  
  public static void SetLeadZeros(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LeadZeros = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LeadZeros = null;
  }
  
  /// <summary>
  /// No Bullet.
  /// </summary>
  public static Boolean? GetNoBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  public static DocumentModel.Drawings.AutoNumberedBullet? GetAutoNumberedBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AutoNumberedBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAutoNumberedBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement, DocumentModel.Drawings.AutoNumberedBullet? value)
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
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  public static DocumentModel.Drawings.CharacterBullet? GetCharacterBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CharacterBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCharacterBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement, DocumentModel.Drawings.CharacterBullet? value)
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
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  public static DocumentModel.Drawings.PictureBullet? GetPictureBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PictureBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPictureBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement, DocumentModel.Drawings.PictureBullet? value)
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
  
  public static DocumentModel.Drawings.Diagram1.DiagramAutoBullet? CreateModelElement(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
