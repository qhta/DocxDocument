namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Style.
/// </summary>
public static class StyleConverter
{
  /// <summary>
  /// LineReference.
  /// </summary>
  private static DMD.LineReference? GetLineReference(DXDD.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LineReference>();
    if (element != null)
      return DMXD.LineReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineReference(DXDD.Style openXmlElement, DMD.LineReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LineReference>(), value, diffs, objName, propName);
  }
  
  private static void SetLineReference(DXDD.Style openXmlElement, DMD.LineReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LineReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineReferenceConverter.CreateOpenXmlElement<DXD.LineReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  private static DMD.FillReference? GetFillReference(DXDD.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillReference>();
    if (element != null)
      return DMXD.FillReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillReference(DXDD.Style openXmlElement, DMD.FillReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FillReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillReference>(), value, diffs, objName, propName);
  }
  
  private static void SetFillReference(DXDD.Style openXmlElement, DMD.FillReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillReferenceConverter.CreateOpenXmlElement<DXD.FillReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  private static DMD.EffectReference? GetEffectReference(DXDD.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectReference>();
    if (element != null)
      return DMXD.EffectReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectReference(DXDD.Style openXmlElement, DMD.EffectReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectReference>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectReference(DXDD.Style openXmlElement, DMD.EffectReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectReferenceConverter.CreateOpenXmlElement<DXD.EffectReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  private static DMD.FontReference? GetFontReference(DXDD.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FontReference>();
    if (element != null)
      return DMXD.FontReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontReference(DXDD.Style openXmlElement, DMD.FontReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FontReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FontReference>(), value, diffs, objName, propName);
  }
  
  private static void SetFontReference(DXDD.Style openXmlElement, DMD.FontReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FontReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FontReferenceConverter.CreateOpenXmlElement<DXD.FontReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.Style? CreateModelElement(DXDD.Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.Style();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.Style? openXmlElement, DMDD.Style? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineReference(openXmlElement, value.LineReference, diffs, objName, propName))
        ok = false;
      if (!CmpFillReference(openXmlElement, value.FillReference, diffs, objName, propName))
        ok = false;
      if (!CmpEffectReference(openXmlElement, value.EffectReference, diffs, objName, propName))
        ok = false;
      if (!CmpFontReference(openXmlElement, value.FontReference, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Style value)
    where OpenXmlElementType: DXDD.Style, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Style openXmlElement, DMDD.Style value)
  {
    SetLineReference(openXmlElement, value?.LineReference);
    SetFillReference(openXmlElement, value?.FillReference);
    SetEffectReference(openXmlElement, value?.EffectReference);
    SetFontReference(openXmlElement, value?.FontReference);
  }
}
