namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Style.
/// </summary>
public static class StyleConverter
{
  /// <summary>
  /// LineReference.
  /// </summary>
  private static DMDraws.LineReference? GetLineReference(DXDrawChartDraw.Style openXmlElement)
  {
    return DMXDraws.LineReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.LineReference>());
  }
  
  private static bool CmpLineReference(DXDrawChartDraw.Style openXmlElement, DMDraws.LineReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LineReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineReference(DXDrawChartDraw.Style openXmlElement, DMDraws.LineReference? value)
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
  private static DMDraws.FillReference? GetFillReference(DXDrawChartDraw.Style openXmlElement)
  {
    return DMXDraws.FillReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.FillReference>());
  }
  
  private static bool CmpFillReference(DXDrawChartDraw.Style openXmlElement, DMDraws.FillReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FillReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FillReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFillReference(DXDrawChartDraw.Style openXmlElement, DMDraws.FillReference? value)
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
  private static DMDraws.EffectReference? GetEffectReference(DXDrawChartDraw.Style openXmlElement)
  {
    return DMXDraws.EffectReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectReference>());
  }
  
  private static bool CmpEffectReference(DXDrawChartDraw.Style openXmlElement, DMDraws.EffectReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectReference(DXDrawChartDraw.Style openXmlElement, DMDraws.EffectReference? value)
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
  private static DMDraws.FontReference? GetFontReference(DXDrawChartDraw.Style openXmlElement)
  {
    return DMXDraws.FontReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.FontReference>());
  }
  
  private static bool CmpFontReference(DXDrawChartDraw.Style openXmlElement, DMDraws.FontReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FontReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FontReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontReference(DXDrawChartDraw.Style openXmlElement, DMDraws.FontReference? value)
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
  
  public static DMDrawsChartDraw.Style? CreateModelElement(DXDrawChartDraw.Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.Style();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.Style? openXmlElement, DMDrawsChartDraw.Style? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.Style? value)
    where OpenXmlElementType: DXDrawChartDraw.Style, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineReference(openXmlElement, value?.LineReference);
      SetFillReference(openXmlElement, value?.FillReference);
      SetEffectReference(openXmlElement, value?.EffectReference);
      SetFontReference(openXmlElement, value?.FontReference);
      return openXmlElement;
    }
    return default;
  }
}
