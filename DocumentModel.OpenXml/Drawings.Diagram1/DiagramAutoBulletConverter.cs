namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the DiagramAutoBullet Class.
/// </summary>
public static class DiagramAutoBulletConverter
{
  /// <summary>
  /// prefix, this property is only available in Office 2019 and later.
  /// </summary>
  private static String? GetAutoBulletPrefix(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    return openXmlElement?.AutoBulletPrefix?.Value;
  }
  
  private static void SetAutoBulletPrefix(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AutoBulletPrefix = new StringValue { Value = value };
    else
      openXmlElement.AutoBulletPrefix = null;
  }
  
  /// <summary>
  /// leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  private static Boolean? GetLeadZeros(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    return openXmlElement?.LeadZeros?.Value;
  }
  
  private static void SetLeadZeros(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LeadZeros = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LeadZeros = null;
  }
  
  /// <summary>
  /// No Bullet.
  /// </summary>
  private static Boolean? GetNoBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NoBullet>();
    return itemElement != null;
  }
  
  private static void SetNoBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.NoBullet>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.NoBullet();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Auto-Numbered Bullet.
  /// </summary>
  private static DMDraws.AutoNumberedBullet? GetAutoNumberedBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AutoNumberedBullet>();
    if (itemElement != null)
      return DMXDraws.AutoNumberedBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAutoNumberedBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.AutoNumberedBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AutoNumberedBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AutoNumberedBulletConverter.CreateOpenXmlElement<DXDraw.AutoNumberedBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Character Bullet.
  /// </summary>
  private static DMDraws.CharacterBullet? GetCharacterBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.CharacterBullet>();
    if (itemElement != null)
      return DMXDraws.CharacterBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCharacterBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.CharacterBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CharacterBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CharacterBulletConverter.CreateOpenXmlElement<DXDraw.CharacterBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Bullet.
  /// </summary>
  private static DMDraws.PictureBullet? GetPictureBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PictureBullet>();
    if (itemElement != null)
      return DMXDraws.PictureBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureBullet(DXO2019DrawDgm11.DiagramAutoBullet openXmlElement, DMDraws.PictureBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PictureBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PictureBulletConverter.CreateOpenXmlElement<DXDraw.PictureBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgm1.DiagramAutoBullet? CreateModelElement(DXO2019DrawDgm11.DiagramAutoBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgm1.DiagramAutoBullet();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgm1.DiagramAutoBullet? value)
    where OpenXmlElementType: DXO2019DrawDgm11.DiagramAutoBullet, new()
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
