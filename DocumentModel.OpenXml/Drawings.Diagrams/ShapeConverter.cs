namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Double? GetRotation(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement.Rotation?.Value;
  }
  
  private static void SetRotation(DXDrawDgms.Shape openXmlElement, Double? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  private static String? GetType(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static void SetType(DXDrawDgms.Shape openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  private static String? GetBlip(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.Blip?.Value;
  }
  
  private static void SetBlip(DXDrawDgms.Shape openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Blip = new StringValue { Value = value };
    else
      openXmlElement.Blip = null;
  }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  private static Int32? GetZOrderOffset(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement.ZOrderOffset?.Value;
  }
  
  private static void SetZOrderOffset(DXDrawDgms.Shape openXmlElement, Int32? value)
  {
    openXmlElement.ZOrderOffset = value;
  }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  private static Boolean? GetHideGeometry(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.HideGeometry?.Value;
  }
  
  private static void SetHideGeometry(DXDrawDgms.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HideGeometry = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HideGeometry = null;
  }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  private static Boolean? GetLockedText(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.LockedText?.Value;
  }
  
  private static void SetLockedText(DXDrawDgms.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockedText = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LockedText = null;
  }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  private static Boolean? GetBlipPlaceholder(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.BlipPlaceholder?.Value;
  }
  
  private static void SetBlipPlaceholder(DXDrawDgms.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BlipPlaceholder = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BlipPlaceholder = null;
  }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  private static DMDrawsDgms.AdjustList? GetAdjustList(DXDrawDgms.Shape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.AdjustList>();
    if (itemElement != null)
      return DMXDrawsDgms.AdjustListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAdjustList(DXDrawDgms.Shape openXmlElement, DMDrawsDgms.AdjustList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.AdjustList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.AdjustListConverter.CreateOpenXmlElement<DXDrawDgms.AdjustList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.Shape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawDgms.Shape openXmlElement, DMDrawsDgms.ExtensionList? value)
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
  
  public static DMDrawsDgms.Shape? CreateModelElement(DXDrawDgms.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Shape();
      value.Rotation = GetRotation(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Blip = GetBlip(openXmlElement);
      value.ZOrderOffset = GetZOrderOffset(openXmlElement);
      value.HideGeometry = GetHideGeometry(openXmlElement);
      value.LockedText = GetLockedText(openXmlElement);
      value.BlipPlaceholder = GetBlipPlaceholder(openXmlElement);
      value.AdjustList = GetAdjustList(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Shape? value)
    where OpenXmlElementType: DXDrawDgms.Shape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotation(openXmlElement, value?.Rotation);
      SetType(openXmlElement, value?.Type);
      SetBlip(openXmlElement, value?.Blip);
      SetZOrderOffset(openXmlElement, value?.ZOrderOffset);
      SetHideGeometry(openXmlElement, value?.HideGeometry);
      SetLockedText(openXmlElement, value?.LockedText);
      SetBlipPlaceholder(openXmlElement, value?.BlipPlaceholder);
      SetAdjustList(openXmlElement, value?.AdjustList);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
