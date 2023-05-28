namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Text Properties.
/// </summary>
public static class TextPropertiesConverter
{
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  private static DMD.Shape3DType? GetShape3DType(DXDD.TextProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Shape3DType>();
    if (element != null)
      return DMXD.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXDD.TextProperties openXmlElement, DMD.Shape3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), value, diffs, objName, propName);
  }
  
  private static void SetShape3DType(DXDD.TextProperties openXmlElement, DMD.Shape3DType? value)
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
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  private static DMD.FlatText? GetFlatText(DXDD.TextProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FlatText>();
    if (element != null)
      return DMXD.FlatTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFlatText(DXDD.TextProperties openXmlElement, DMD.FlatText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FlatTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FlatText>(), value, diffs, objName, propName);
  }
  
  private static void SetFlatText(DXDD.TextProperties openXmlElement, DMD.FlatText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FlatText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FlatTextConverter.CreateOpenXmlElement<DXD.FlatText>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.TextProperties? CreateModelElement(DXDD.TextProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.TextProperties();
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.FlatText = GetFlatText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.TextProperties? openXmlElement, DMDD.TextProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShape3DType(openXmlElement, value.Shape3DType, diffs, objName, propName))
        ok = false;
      if (!CmpFlatText(openXmlElement, value.FlatText, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.TextProperties value)
    where OpenXmlElementType: DXDD.TextProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.TextProperties openXmlElement, DMDD.TextProperties value)
  {
    SetShape3DType(openXmlElement, value?.Shape3DType);
    SetFlatText(openXmlElement, value?.FlatText);
  }
}
