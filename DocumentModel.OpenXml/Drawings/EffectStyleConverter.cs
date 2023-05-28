namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Style.
/// </summary>
public static class EffectStyleConverter
{
  private static DMD.EffectList? GetEffectList(DXD.EffectStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXD.EffectStyle openXmlElement, DMD.EffectList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectList(DXD.EffectStyle openXmlElement, DMD.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectDag? GetEffectDag(DXD.EffectStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXD.EffectStyle openXmlElement, DMD.EffectDag? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectDag(DXD.EffectStyle openXmlElement, DMD.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Scene3DType? GetScene3DType(DXD.EffectStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Scene3DType>();
    if (element != null)
      return DMXD.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXD.EffectStyle openXmlElement, DMD.Scene3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Scene3DType>(), value, diffs, objName, propName);
  }
  
  private static void SetScene3DType(DXD.EffectStyle openXmlElement, DMD.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Shape3DType? GetShape3DType(DXD.EffectStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Shape3DType>();
    if (element != null)
      return DMXD.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXD.EffectStyle openXmlElement, DMD.Shape3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), value, diffs, objName, propName);
  }
  
  private static void SetShape3DType(DXD.EffectStyle openXmlElement, DMD.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.EffectStyle? CreateModelElement(DXD.EffectStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.EffectStyle();
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.Shape3DType = GetShape3DType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.EffectStyle? openXmlElement, DMD.EffectStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEffectList(openXmlElement, value.EffectList, diffs, objName, propName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, value.EffectDag, diffs, objName, propName))
        ok = false;
      if (!CmpScene3DType(openXmlElement, value.Scene3DType, diffs, objName, propName))
        ok = false;
      if (!CmpShape3DType(openXmlElement, value.Shape3DType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXD.EffectStyle CreateOpenXmlElement(DMD.EffectStyle value)
  {
    var openXmlElement = new DXD.EffectStyle();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXD.EffectStyle openXmlElement, DMD.EffectStyle value)
  {
    SetEffectList(openXmlElement, value?.EffectList);
    SetEffectDag(openXmlElement, value?.EffectDag);
    SetScene3DType(openXmlElement, value?.Scene3DType);
    SetShape3DType(openXmlElement, value?.Shape3DType);
    return true;
  }
}
