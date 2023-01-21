namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
public static class ObjectDefaultsConverter
{
  /// <summary>
  /// Shape Default.
  /// </summary>
  private static DMDraws.ShapeDefault? GetShapeDefault(DXDraw.ObjectDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ShapeDefault>();
    if (itemElement != null)
      return DMXDraws.ShapeDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.ShapeDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ShapeDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ShapeDefaultConverter.CreateOpenXmlElement<DXDraw.ShapeDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  private static DMDraws.LineDefault? GetLineDefault(DXDraw.ObjectDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LineDefault>();
    if (itemElement != null)
      return DMXDraws.LineDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.LineDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineDefaultConverter.CreateOpenXmlElement<DXDraw.LineDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  private static DMDraws.TextDefault? GetTextDefault(DXDraw.ObjectDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.TextDefault>();
    if (itemElement != null)
      return DMXDraws.TextDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextDefault(DXDraw.ObjectDefaults openXmlElement, DMDraws.TextDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TextDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextDefaultConverter.CreateOpenXmlElement<DXDraw.TextDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.ObjectDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.ObjectDefaults openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.ObjectDefaults? CreateModelElement(DXDraw.ObjectDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ObjectDefaults();
      value.ShapeDefault = GetShapeDefault(openXmlElement);
      value.LineDefault = GetLineDefault(openXmlElement);
      value.TextDefault = GetTextDefault(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ObjectDefaults? value)
    where OpenXmlElementType: DXDraw.ObjectDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeDefault(openXmlElement, value?.ShapeDefault);
      SetLineDefault(openXmlElement, value?.LineDefault);
      SetTextDefault(openXmlElement, value?.TextDefault);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
