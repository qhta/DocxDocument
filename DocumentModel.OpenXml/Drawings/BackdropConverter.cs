namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Backdrop Plane.
/// </summary>
public static class BackdropConverter
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  private static DMDraws.Anchor? GetAnchor(DXDraw.Backdrop openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Anchor>();
    if (itemElement != null)
      return DMXDraws.AnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAnchor(DXDraw.Backdrop openXmlElement, DMDraws.Anchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Anchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AnchorConverter.CreateOpenXmlElement<DXDraw.Anchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Normal.
  /// </summary>
  private static DMDraws.Vector3DType? GetNormal(DXDraw.Backdrop openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Normal>();
    if (itemElement != null)
      return DMXDraws.Vector3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNormal(DXDraw.Backdrop openXmlElement, DMDraws.Vector3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Normal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Vector3DTypeConverter.CreateOpenXmlElement<DXDraw.Normal>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  private static DMDraws.Vector3DType? GetUpVector(DXDraw.Backdrop openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.UpVector>();
    if (itemElement != null)
      return DMXDraws.Vector3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUpVector(DXDraw.Backdrop openXmlElement, DMDraws.Vector3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.UpVector>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Vector3DTypeConverter.CreateOpenXmlElement<DXDraw.UpVector>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.Backdrop openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.Backdrop openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.Backdrop? CreateModelElement(DXDraw.Backdrop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Backdrop();
      value.Anchor = GetAnchor(openXmlElement);
      value.Normal = GetNormal(openXmlElement);
      value.UpVector = GetUpVector(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Backdrop? value)
    where OpenXmlElementType: DXDraw.Backdrop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAnchor(openXmlElement, value?.Anchor);
      SetNormal(openXmlElement, value?.Normal);
      SetUpVector(openXmlElement, value?.UpVector);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
