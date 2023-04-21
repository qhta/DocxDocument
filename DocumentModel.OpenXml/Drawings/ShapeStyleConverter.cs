namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Style.
/// </summary>
public static class ShapeStyleConverter
{
  /// <summary>
  /// LineReference.
  /// </summary>
  private static DMD.LineReference? GetLineReference(DXD.ShapeStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LineReference>();
    if (element != null)
      return DMXD.LineReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineReference(DXD.ShapeStyle openXmlElement, DMD.LineReference? value, DiffList? diffs, string? objName)
  {
    return DMXD.LineReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LineReference>(), value, diffs, objName);
  }
  
  private static void SetLineReference(DXD.ShapeStyle openXmlElement, DMD.LineReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LineReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineReferenceConverter.CreateOpenXmlElement<DXD.LineReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  private static DMD.FillReference? GetFillReference(DXD.ShapeStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillReference>();
    if (element != null)
      return DMXD.FillReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillReference(DXD.ShapeStyle openXmlElement, DMD.FillReference? value, DiffList? diffs, string? objName)
  {
    return DMXD.FillReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillReference>(), value, diffs, objName);
  }
  
  private static void SetFillReference(DXD.ShapeStyle openXmlElement, DMD.FillReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillReferenceConverter.CreateOpenXmlElement<DXD.FillReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  private static DMD.EffectReference? GetEffectReference(DXD.ShapeStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectReference>();
    if (element != null)
      return DMXD.EffectReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectReference(DXD.ShapeStyle openXmlElement, DMD.EffectReference? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectReference>(), value, diffs, objName);
  }
  
  private static void SetEffectReference(DXD.ShapeStyle openXmlElement, DMD.EffectReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectReferenceConverter.CreateOpenXmlElement<DXD.EffectReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  private static DMD.FontReference? GetFontReference(DXD.ShapeStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FontReference>();
    if (element != null)
      return DMXD.FontReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontReference(DXD.ShapeStyle openXmlElement, DMD.FontReference? value, DiffList? diffs, string? objName)
  {
    return DMXD.FontReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FontReference>(), value, diffs, objName);
  }
  
  private static void SetFontReference(DXD.ShapeStyle openXmlElement, DMD.FontReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FontReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FontReferenceConverter.CreateOpenXmlElement<DXD.FontReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ShapeStyle? CreateModelElement(DXD.ShapeStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapeStyle();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ShapeStyle? openXmlElement, DMD.ShapeStyle? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ShapeStyle value)
    where OpenXmlElementType: DXD.ShapeStyle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ShapeStyle openXmlElement, DMD.ShapeStyle value)
  {
    SetLineReference(openXmlElement, value?.LineReference);
    SetFillReference(openXmlElement, value?.FillReference);
    SetEffectReference(openXmlElement, value?.EffectReference);
    SetFontReference(openXmlElement, value?.FontReference);
  }
}
