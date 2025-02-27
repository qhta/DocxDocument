namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the ShapeStyle Class.
/// </summary>
public static class ShapeStyleConverter
{
  /// <summary>
  /// LineReference.
  /// </summary>
  private static DMDraws.LineReference? GetLineReference(DXODraw.ShapeStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.LineReference>();
    if (element != null)
      return DMXDraws.LineReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineReference(DXODraw.ShapeStyle openXmlElement, DMDraws.LineReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LineReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineReference(DXODraw.ShapeStyle openXmlElement, DMDraws.LineReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineReferenceConverter.CreateOpenXmlElement<DXDraw.LineReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  private static DMDraws.FillReference? GetFillReference(DXODraw.ShapeStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.FillReference>();
    if (element != null)
      return DMXDraws.FillReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillReference(DXODraw.ShapeStyle openXmlElement, DMDraws.FillReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FillReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FillReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFillReference(DXODraw.ShapeStyle openXmlElement, DMDraws.FillReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FillReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FillReferenceConverter.CreateOpenXmlElement<DXDraw.FillReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  private static DMDraws.EffectReference? GetEffectReference(DXODraw.ShapeStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectReference>();
    if (element != null)
      return DMXDraws.EffectReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectReference(DXODraw.ShapeStyle openXmlElement, DMDraws.EffectReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectReference(DXODraw.ShapeStyle openXmlElement, DMDraws.EffectReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectReferenceConverter.CreateOpenXmlElement<DXDraw.EffectReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  private static DMDraws.FontReference? GetFontReference(DXODraw.ShapeStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.FontReference>();
    if (element != null)
      return DMXDraws.FontReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontReference(DXODraw.ShapeStyle openXmlElement, DMDraws.FontReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FontReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FontReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontReference(DXODraw.ShapeStyle openXmlElement, DMDraws.FontReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FontReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FontReferenceConverter.CreateOpenXmlElement<DXDraw.FontReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.ShapeStyle? CreateModelElement(DXODraw.ShapeStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.ShapeStyle();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODraw.ShapeStyle? openXmlElement, DMDrawsO.ShapeStyle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineReference(openXmlElement, value.LineReference, diffs, objName))
        ok = false;
      if (!CmpFillReference(openXmlElement, value.FillReference, diffs, objName))
        ok = false;
      if (!CmpEffectReference(openXmlElement, value.EffectReference, diffs, objName))
        ok = false;
      if (!CmpFontReference(openXmlElement, value.FontReference, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.ShapeStyle value)
    where OpenXmlElementType: DXODraw.ShapeStyle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODraw.ShapeStyle openXmlElement, DMDrawsO.ShapeStyle value)
  {
    SetLineReference(openXmlElement, value?.LineReference);
    SetFillReference(openXmlElement, value?.FillReference);
    SetEffectReference(openXmlElement, value?.EffectReference);
    SetFontReference(openXmlElement, value?.FontReference);
  }
}
