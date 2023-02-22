namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Text Properties.
/// </summary>
public static class TextPropertiesConverter
{
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  private static DMDraws.Shape3DType? GetShape3DType(DXDrawDgms.TextProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Shape3DType>();
    if (element != null)
      return DMXDraws.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXDrawDgms.TextProperties openXmlElement, DMDraws.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Shape3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape3DType(DXDrawDgms.TextProperties openXmlElement, DMDraws.Shape3DType? value)
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
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  private static DMDraws.FlatText? GetFlatText(DXDrawDgms.TextProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.FlatText>();
    if (element != null)
      return DMXDraws.FlatTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFlatText(DXDrawDgms.TextProperties openXmlElement, DMDraws.FlatText? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FlatTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FlatText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFlatText(DXDrawDgms.TextProperties openXmlElement, DMDraws.FlatText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FlatText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FlatTextConverter.CreateOpenXmlElement<DXDraw.FlatText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.TextProperties? CreateModelElement(DXDrawDgms.TextProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.TextProperties();
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.FlatText = GetFlatText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.TextProperties? openXmlElement, DMDrawsDgms.TextProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShape3DType(openXmlElement, value.Shape3DType, diffs, objName))
        ok = false;
      if (!CmpFlatText(openXmlElement, value.FlatText, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.TextProperties value)
    where OpenXmlElementType: DXDrawDgms.TextProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.TextProperties openXmlElement, DMDrawsDgms.TextProperties value)
  {
    SetShape3DType(openXmlElement, value?.Shape3DType);
    SetFlatText(openXmlElement, value?.FlatText);
    }
  }
