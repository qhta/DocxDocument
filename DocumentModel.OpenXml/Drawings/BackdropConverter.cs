namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Backdrop Plane.
/// </summary>
public static class BackdropConverter
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  private static DMD.Anchor? GetAnchor(DXD.Backdrop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Anchor>();
    if (element != null)
      return DMXD.AnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAnchor(DXD.Backdrop openXmlElement, DMD.Anchor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Anchor>(), value, diffs, objName, propName);
  }
  
  private static void SetAnchor(DXD.Backdrop openXmlElement, DMD.Anchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Anchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AnchorConverter.CreateOpenXmlElement<DXD.Anchor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Normal.
  /// </summary>
  private static DMD.Vector3DType? GetNormal(DXD.Backdrop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Normal>();
    if (element != null)
      return DMXD.Vector3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNormal(DXD.Backdrop openXmlElement, DMD.Vector3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Vector3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Normal>(), value, diffs, objName, propName);
  }
  
  private static void SetNormal(DXD.Backdrop openXmlElement, DMD.Vector3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Normal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Vector3DTypeConverter.CreateOpenXmlElement<DXD.Normal>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  private static DMD.Vector3DType? GetUpVector(DXD.Backdrop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.UpVector>();
    if (element != null)
      return DMXD.Vector3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUpVector(DXD.Backdrop openXmlElement, DMD.Vector3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Vector3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.UpVector>(), value, diffs, objName, propName);
  }
  
  private static void SetUpVector(DXD.Backdrop openXmlElement, DMD.Vector3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.UpVector>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Vector3DTypeConverter.CreateOpenXmlElement<DXD.UpVector>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.Backdrop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.Backdrop openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.Backdrop openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Backdrop? CreateModelElement(DXD.Backdrop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Backdrop();
      value.Anchor = GetAnchor(openXmlElement);
      value.Normal = GetNormal(openXmlElement);
      value.UpVector = GetUpVector(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Backdrop? openXmlElement, DMD.Backdrop? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAnchor(openXmlElement, value.Anchor, diffs, objName, propName))
        ok = false;
      if (!CmpNormal(openXmlElement, value.Normal, diffs, objName, propName))
        ok = false;
      if (!CmpUpVector(openXmlElement, value.UpVector, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Backdrop value)
    where OpenXmlElementType: DXD.Backdrop, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Backdrop openXmlElement, DMD.Backdrop value)
  {
    SetAnchor(openXmlElement, value?.Anchor);
    SetNormal(openXmlElement, value?.Normal);
    SetUpVector(openXmlElement, value?.UpVector);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
