namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public static class RubyConverter
{
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  private static DMW.RubyProperties? GetRubyProperties(DXW.Ruby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RubyProperties>();
    if (itemElement != null)
      return DMXW.RubyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRubyProperties(DXW.Ruby openXmlElement, DMW.RubyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyPropertiesConverter.CreateOpenXmlElement<DXW.RubyProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  private static DMW.RubyContent? GetRubyContent(DXW.Ruby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RubyContent>();
    if (itemElement != null)
      return DMXW.RubyContentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRubyContent(DXW.Ruby openXmlElement, DMW.RubyContent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyContent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyContentConverter.CreateOpenXmlElement<DXW.RubyContent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  private static DMW.RubyBase? GetRubyBase(DXW.Ruby openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RubyBase>();
    if (itemElement != null)
      return DMXW.RubyBaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRubyBase(DXW.Ruby openXmlElement, DMW.RubyBase? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyBase>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyBaseConverter.CreateOpenXmlElement<DXW.RubyBase>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Ruby? CreateModelElement(DXW.Ruby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Ruby();
      value.RubyProperties = GetRubyProperties(openXmlElement);
      value.RubyContent = GetRubyContent(openXmlElement);
      value.RubyBase = GetRubyBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Ruby? value)
    where OpenXmlElementType: DXW.Ruby, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRubyProperties(openXmlElement, value?.RubyProperties);
      SetRubyContent(openXmlElement, value?.RubyContent);
      SetRubyBase(openXmlElement, value?.RubyBase);
      return openXmlElement;
    }
    return default;
  }
}
