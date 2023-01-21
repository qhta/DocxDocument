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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LineReference>();
    if (itemElement != null)
      return DMXDraws.LineReferenceConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FillReference>();
    if (itemElement != null)
      return DMXDraws.FillReferenceConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectReference>();
    if (itemElement != null)
      return DMXDraws.EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FontReference>();
    if (itemElement != null)
      return DMXDraws.FontReferenceConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsO.ShapeStyle? CreateModelElement(DXODraw.ShapeStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.ShapeStyle();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.ShapeStyle? value)
    where OpenXmlElementType: DXODraw.ShapeStyle, new()
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
