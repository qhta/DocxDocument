namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Style.
/// </summary>
public static class EffectStyleConverter
{
  private static DMDraws.EffectList? GetEffectList(DXDraw.EffectStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectList>();
    if (element != null)
      return DMXDraws.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXDraw.EffectStyle openXmlElement, DMDraws.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectList(DXDraw.EffectStyle openXmlElement, DMDraws.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectListConverter.CreateOpenXmlElement<DXDraw.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.EffectDag? GetEffectDag(DXDraw.EffectStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectDag>();
    if (element != null)
      return DMXDraws.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXDraw.EffectStyle openXmlElement, DMDraws.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectDag>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectDag(DXDraw.EffectStyle openXmlElement, DMDraws.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectDagConverter.CreateOpenXmlElement<DXDraw.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Scene3DType? GetScene3DType(DXDraw.EffectStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Scene3DType>();
    if (element != null)
      return DMXDraws.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXDraw.EffectStyle openXmlElement, DMDraws.Scene3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Scene3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScene3DType(DXDraw.EffectStyle openXmlElement, DMDraws.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Scene3DTypeConverter.CreateOpenXmlElement<DXDraw.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Shape3DType? GetShape3DType(DXDraw.EffectStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Shape3DType>();
    if (element != null)
      return DMXDraws.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXDraw.EffectStyle openXmlElement, DMDraws.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Shape3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape3DType(DXDraw.EffectStyle openXmlElement, DMDraws.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Shape3DTypeConverter.CreateOpenXmlElement<DXDraw.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.EffectStyle? CreateModelElement(DXDraw.EffectStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectStyle();
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.Shape3DType = GetShape3DType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.EffectStyle? openXmlElement, DMDraws.EffectStyle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEffectList(openXmlElement, value.EffectList, diffs, objName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, value.EffectDag, diffs, objName))
        ok = false;
      if (!CmpScene3DType(openXmlElement, value.Scene3DType, diffs, objName))
        ok = false;
      if (!CmpShape3DType(openXmlElement, value.Shape3DType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EffectStyle value)
    where OpenXmlElementType: DXDraw.EffectStyle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.EffectStyle openXmlElement, DMDraws.EffectStyle value)
  {
    SetEffectList(openXmlElement, value?.EffectList);
    SetEffectDag(openXmlElement, value?.EffectDag);
    SetScene3DType(openXmlElement, value?.Scene3DType);
    SetShape3DType(openXmlElement, value?.Shape3DType);
  }
}
