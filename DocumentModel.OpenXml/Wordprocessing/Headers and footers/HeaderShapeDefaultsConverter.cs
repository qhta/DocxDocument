namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public static class HeaderShapeDefaultsConverter
{
  private static DMV.ShapeDefaults? GetShapeDefaults(DXW.HeaderShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ShapeDefaults>();
    if (element != null)
      return DMXV.ShapeDefaultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeDefaults(DXW.HeaderShapeDefaults openXmlElement, DMV.ShapeDefaults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShapeDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ShapeDefaults>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeDefaults(DXW.HeaderShapeDefaults openXmlElement, DMV.ShapeDefaults? value)
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
  
  private static DMV.ShapeLayout? GetShapeLayout(DXW.HeaderShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ShapeLayout>();
    if (element != null)
      return DMXV.ShapeLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeLayout(DXW.HeaderShapeDefaults openXmlElement, DMV.ShapeLayout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShapeLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ShapeLayout>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeLayout(DXW.HeaderShapeDefaults openXmlElement, DMV.ShapeLayout? value)
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
  
  public static DMW.HeaderShapeDefaults? CreateModelElement(DXW.HeaderShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.HeaderShapeDefaults();
      value.ShapeDefaults = GetShapeDefaults(openXmlElement);
      value.ShapeLayout = GetShapeLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.HeaderShapeDefaults? openXmlElement, DMW.HeaderShapeDefaults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeDefaults(openXmlElement, value.ShapeDefaults, diffs, objName, propName))
        ok = false;
      if (!CmpShapeLayout(openXmlElement, value.ShapeLayout, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.HeaderShapeDefaults value)
    where OpenXmlElementType: DXW.HeaderShapeDefaults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.HeaderShapeDefaults openXmlElement, DMW.HeaderShapeDefaults value)
  {
    SetShapeDefaults(openXmlElement, value?.ShapeDefaults);
    SetShapeLayout(openXmlElement, value?.ShapeLayout);
  }
}
