namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public static class FillOverlayConverter
{
  /// <summary>
  /// Blend
  /// </summary>
  public static DocumentModel.Drawings.BlendMode? GetBlend(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DocumentModel.Drawings.BlendMode>(openXmlElement?.Blend?.Value);
  }
  
  public static void SetBlend(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.BlendMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Blend = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DocumentModel.Drawings.BlendMode>(value);
  }
  
  /// <summary>
  /// NoFill.
  /// </summary>
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.NoFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SolidFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBlipFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.BlipFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BlipFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PatternFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  public static Boolean? GetGroupFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGroupFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.GroupFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.FillOverlay? CreateModelElement(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FillOverlay();
      value.Blend = GetBlend(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FillOverlay? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.FillOverlay, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
