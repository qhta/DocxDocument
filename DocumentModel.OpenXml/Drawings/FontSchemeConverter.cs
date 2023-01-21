namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Font Scheme.
/// </summary>
public static class FontSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDraw.FontScheme openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDraw.FontScheme openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Major Font.
  /// </summary>
  private static DMDraws.MajorFont? GetMajorFont(DXDraw.FontScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.MajorFont>();
    if (itemElement != null)
      return DMXDraws.MajorFontConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMajorFont(DXDraw.FontScheme openXmlElement, DMDraws.MajorFont? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.MajorFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.MajorFontConverter.CreateOpenXmlElement<DXDraw.MajorFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  private static DMDraws.MinorFont? GetMinorFont(DXDraw.FontScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.MinorFont>();
    if (itemElement != null)
      return DMXDraws.MinorFontConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMinorFont(DXDraw.FontScheme openXmlElement, DMDraws.MinorFont? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.MinorFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.MinorFontConverter.CreateOpenXmlElement<DXDraw.MinorFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.FontScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.FontScheme openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.FontScheme? CreateModelElement(DXDraw.FontScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.FontScheme();
      value.Name = GetName(openXmlElement);
      value.MajorFont = GetMajorFont(openXmlElement);
      value.MinorFont = GetMinorFont(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.FontScheme? value)
    where OpenXmlElementType: DXDraw.FontScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetMajorFont(openXmlElement, value?.MajorFont);
      SetMinorFont(openXmlElement, value?.MinorFont);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
