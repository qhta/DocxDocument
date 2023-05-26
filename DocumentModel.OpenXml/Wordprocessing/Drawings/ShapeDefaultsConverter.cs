namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public static class ShapeDefaultsConverter
{
  private static DMV.ShapeDefaults? GetChildShapeDefaults(DXW.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ShapeDefaults>();
    if (element != null)
      return DMXV.ShapeDefaultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildShapeDefaults(DXW.ShapeDefaults openXmlElement, DMV.ShapeDefaults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShapeDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ShapeDefaults>(), value, diffs, objName, propName);
  }
  
  private static void SetChildShapeDefaults(DXW.ShapeDefaults openXmlElement, DMV.ShapeDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.ShapeDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapeDefaultsConverter.CreateOpenXmlElement<DXVO.ShapeDefaults>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.ShapeLayout? GetShapeLayout(DXW.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ShapeLayout>();
    if (element != null)
      return DMXV.ShapeLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeLayout(DXW.ShapeDefaults openXmlElement, DMV.ShapeLayout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShapeLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ShapeLayout>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeLayout(DXW.ShapeDefaults openXmlElement, DMV.ShapeLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.ShapeLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapeLayoutConverter.CreateOpenXmlElement<DXVO.ShapeLayout>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }

  #region ShapeDefaults model conversion.
  public static DMW.ShapeDefaults? CreateModelElement(DXW.ShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ShapeDefaults();
      value.ChildShapeDefaults = GetChildShapeDefaults(openXmlElement);
      value.ShapeLayout = GetShapeLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ShapeDefaults? openXmlElement, DMW.ShapeDefaults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChildShapeDefaults(openXmlElement, value.ChildShapeDefaults, diffs, objName, propName))
        ok = false;
      if (!CmpShapeLayout(openXmlElement, value.ShapeLayout, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ShapeDefaults value)
    where OpenXmlElementType: DXW.ShapeDefaults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ShapeDefaults openXmlElement, DMW.ShapeDefaults value)
  {
    SetChildShapeDefaults(openXmlElement, value?.ChildShapeDefaults);
    SetShapeLayout(openXmlElement, value?.ShapeLayout);
  }
  #endregion
}
