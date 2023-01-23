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
    return DMXDraws.AnchorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Anchor>());
  }
  
  private static bool CmpAnchor(DXDraw.Backdrop openXmlElement, DMDraws.Anchor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AnchorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Anchor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Vector3DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Normal>());
  }
  
  private static bool CmpNormal(DXDraw.Backdrop openXmlElement, DMDraws.Vector3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Vector3DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Normal>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Vector3DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.UpVector>());
  }
  
  private static bool CmpUpVector(DXDraw.Backdrop openXmlElement, DMDraws.Vector3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Vector3DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.UpVector>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.Backdrop openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDraw.Backdrop? openXmlElement, DMDraws.Backdrop? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAnchor(openXmlElement, value.Anchor, diffs, objName))
        ok = false;
      if (!CmpNormal(openXmlElement, value.Normal, diffs, objName))
        ok = false;
      if (!CmpUpVector(openXmlElement, value.UpVector, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
