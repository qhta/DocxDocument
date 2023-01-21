namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public static class StyleLabelConverter
{
  /// <summary>
  /// Style Name
  /// </summary>
  private static String? GetName(DXDrawDgms.StyleLabel openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDrawDgms.StyleLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  private static DMDrawsDgms.Scene3D? GetScene3D(DXDrawDgms.StyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Scene3D>();
    if (itemElement != null)
      return DMXDrawsDgms.Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScene3D(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.Scene3DConverter.CreateOpenXmlElement<DXDrawDgms.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  private static DMDrawsDgms.Shape3D? GetShape3D(DXDrawDgms.StyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Shape3D>();
    if (itemElement != null)
      return DMXDrawsDgms.Shape3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape3D(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Shape3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Shape3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.Shape3DConverter.CreateOpenXmlElement<DXDrawDgms.Shape3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  private static DMDrawsDgms.TextProperties? GetTextProperties(DXDrawDgms.StyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.TextProperties>();
    if (itemElement != null)
      return DMXDrawsDgms.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextProperties(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextPropertiesConverter.CreateOpenXmlElement<DXDrawDgms.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  private static DMDrawsDgms.Style? GetStyle(DXDrawDgms.StyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Style>();
    if (itemElement != null)
      return DMXDrawsDgms.StyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyle(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.Style? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.StyleConverter.CreateOpenXmlElement<DXDrawDgms.Style>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.StyleLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawDgms.StyleLabel openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.StyleLabel? CreateModelElement(DXDrawDgms.StyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.StyleLabel();
      value.Name = GetName(openXmlElement);
      value.Scene3D = GetScene3D(openXmlElement);
      value.Shape3D = GetShape3D(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleLabel? value)
    where OpenXmlElementType: DXDrawDgms.StyleLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetScene3D(openXmlElement, value?.Scene3D);
      SetShape3D(openXmlElement, value?.Shape3D);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetStyle(openXmlElement, value?.Style);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
