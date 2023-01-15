using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using AbstractNum = DocumentFormat.OpenXml.Wordprocessing.AbstractNum;
using Level = DocumentModel.Wordprocessing.Level;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Abstract Numbering Definition.
/// </summary>
public static class AbstractNumConverter
{
  /// <summary>
  ///   Abstract Numbering Definition ID
  /// </summary>
  public static Int32? GetAbstractNumberId(AbstractNum? openXmlElement)
  {
    return openXmlElement?.AbstractNumberId?.Value;
  }

  public static void SetAbstractNumberId(AbstractNum? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.AbstractNumberId = value;
  }

  /// <summary>
  ///   Abstract Numbering Definition Identifier.
  /// </summary>
  public static NumId? GetNsid(AbstractNum? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Nsid>();
    if (itemElement != null)
      return NumIdConverter.GetValue(itemElement);
    return null;
  }

  public static void SetNsid(AbstractNum? openXmlElement, NumId? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Nsid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumIdConverter.CreateOpenXmlElement<Nsid>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Abstract Numbering Definition Type.
  /// </summary>
  public static MultiLevelKind? GetMultiLevelType(AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MultiLevelType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<MultiLevelValues, MultiLevelKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMultiLevelType(AbstractNum? openXmlElement, MultiLevelKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MultiLevelType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MultiLevelType, MultiLevelValues, MultiLevelKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Template Code.
  /// </summary>
  public static NumId? GetTemplateCode(AbstractNum? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TemplateCode>();
    if (itemElement != null)
      return NumIdConverter.GetValue(itemElement);
    return null;
  }

  public static void SetTemplateCode(AbstractNum? openXmlElement, NumId? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TemplateCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumIdConverter.CreateOpenXmlElement<TemplateCode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Abstract Numbering Definition Name.
  /// </summary>
  public static String? GetAbstractNumDefinitionName(AbstractNum? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AbstractNumDefinitionName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAbstractNumDefinitionName(AbstractNum? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AbstractNumDefinitionName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new AbstractNumDefinitionName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Style Definition.
  /// </summary>
  public static String? GetStyleLink(AbstractNum? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StyleLink>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetStyleLink(AbstractNum? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StyleLink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new StyleLink { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Style Reference.
  /// </summary>
  public static String? GetNumberingStyleLink(AbstractNum? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingStyleLink>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberingStyleLink(AbstractNum? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingStyleLink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumberingStyleLink { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<Level>? GetLevels(AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Level>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Level>())
      {
        var newItem = LevelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLevels(AbstractNum? openXmlElement, Collection<Level>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Level>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Level>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.AbstractNum? CreateModelElement(AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AbstractNum();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AbstractNum? value)
    where OpenXmlElementType : AbstractNum, new()
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