namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public static class AbstractNumConverter
{
  /// <summary>
  /// Abstract Numbering Definition ID
  /// </summary>
  private static Int32? GetAbstractNumberId(DXW.AbstractNum openXmlElement)
  {
    return openXmlElement.AbstractNumberId?.Value;
  }
  
  private static void SetAbstractNumberId(DXW.AbstractNum openXmlElement, Int32? value)
  {
    openXmlElement.AbstractNumberId = value;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  private static UInt32? GetNsid(DXW.AbstractNum openXmlElement)
  {
    if (openXmlElement.Nsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Nsid.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetNsid(DXW.AbstractNum openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.Nsid = new DXW.Nsid { Val = ((UInt32)value).ToString("X8") };
      else
        openXmlElement.Nsid = null;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  private static DMW.MultiLevelKind? GetMultiLevelType(DXW.AbstractNum openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MultiLevelType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMultiLevelType(DXW.AbstractNum openXmlElement, DMW.MultiLevelKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MultiLevelType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.MultiLevelType, DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  private static UInt32? GetTemplateCode(DXW.AbstractNum openXmlElement)
  {
    if (openXmlElement.TemplateCode?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.TemplateCode.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetTemplateCode(DXW.AbstractNum openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.TemplateCode = new DXW.TemplateCode { Val = ((UInt32)value).ToString("X8") };
      else
        openXmlElement.TemplateCode = null;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  private static String? GetAbstractNumDefinitionName(DXW.AbstractNum openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.AbstractNumDefinitionName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAbstractNumDefinitionName(DXW.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AbstractNumDefinitionName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.AbstractNumDefinitionName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  private static String? GetStyleLink(DXW.AbstractNum openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StyleLink>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetStyleLink(DXW.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.StyleLink { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  private static String? GetNumberingStyleLink(DXW.AbstractNum openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.NumberingStyleLink>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberingStyleLink(DXW.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingStyleLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.NumberingStyleLink { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.Level> GetLevels(DXW.AbstractNum openXmlElement)
  {
    var collection = new Collection<DMW.Level>();
    foreach (var item in openXmlElement.Elements<DXW.Level>())
    {
      var newItem = DMXW.LevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetLevels(DXW.AbstractNum openXmlElement, Collection<DMW.Level>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Level>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.LevelConverter.CreateOpenXmlElement<DXW.Level>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.AbstractNum? CreateModelElement(DXW.AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AbstractNum();
      value.AbstractNumberId = GetAbstractNumberId(openXmlElement);
      value.Nsid = GetNsid(openXmlElement);
      value.MultiLevelType = GetMultiLevelType(openXmlElement);
      value.TemplateCode = GetTemplateCode(openXmlElement);
      value.AbstractNumDefinitionName = GetAbstractNumDefinitionName(openXmlElement);
      value.StyleLink = GetStyleLink(openXmlElement);
      value.NumberingStyleLink = GetNumberingStyleLink(openXmlElement);
      value.Levels = GetLevels(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AbstractNum? value)
    where OpenXmlElementType: DXW.AbstractNum, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAbstractNumberId(openXmlElement, value?.AbstractNumberId);
      SetNsid(openXmlElement, value?.Nsid);
      SetMultiLevelType(openXmlElement, value?.MultiLevelType);
      SetTemplateCode(openXmlElement, value?.TemplateCode);
      SetAbstractNumDefinitionName(openXmlElement, value?.AbstractNumDefinitionName);
      SetStyleLink(openXmlElement, value?.StyleLink);
      SetNumberingStyleLink(openXmlElement, value?.NumberingStyleLink);
      SetLevels(openXmlElement, value?.Levels);
      return openXmlElement;
    }
    return default;
  }
}
