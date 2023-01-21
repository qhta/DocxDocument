namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Style.
/// </summary>
public static class StyleConverter
{
  /// <summary>
  /// LineReference.
  /// </summary>
  private static DMDraws.LineReference? GetLineReference(DXDrawDgms.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LineReference>();
    if (itemElement != null)
      return DMXDraws.LineReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineReference(DXDrawDgms.Style openXmlElement, DMDraws.LineReference? value)
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
  private static DMDraws.FillReference? GetFillReference(DXDrawDgms.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FillReference>();
    if (itemElement != null)
      return DMXDraws.FillReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillReference(DXDrawDgms.Style openXmlElement, DMDraws.FillReference? value)
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
  private static DMDraws.EffectReference? GetEffectReference(DXDrawDgms.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectReference>();
    if (itemElement != null)
      return DMXDraws.EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectReference(DXDrawDgms.Style openXmlElement, DMDraws.EffectReference? value)
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
  private static DMDraws.FontReference? GetFontReference(DXDrawDgms.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FontReference>();
    if (itemElement != null)
      return DMXDraws.FontReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontReference(DXDrawDgms.Style openXmlElement, DMDraws.FontReference? value)
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
  
  public static DMDrawsDgms.Style? CreateModelElement(DXDrawDgms.Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Style();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Style? value)
    where OpenXmlElementType: DXDrawDgms.Style, new()
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
