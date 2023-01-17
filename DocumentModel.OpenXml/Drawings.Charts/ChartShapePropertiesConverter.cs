namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartShapeProperties Class.
/// </summary>
public static class ChartShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  private static DocumentModel.Drawings.BlackWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static void SetBlackWhiteMode(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  private static DocumentModel.Drawings.Transform2D? GetTransform2D(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Transform2DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTransform2D(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.Transform2D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Transform2DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Transform2D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.CustomGeometry? GetCustomGeometry(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CustomGeometryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomGeometry(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.CustomGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.CustomGeometryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.PresetGeometry? GetPresetGeometry(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetGeometryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetGeometry(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.PresetGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PresetGeometryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
    return itemElement != null;
  }
  
  private static void SetNoFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.SolidFill? value)
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
  
  private static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.GradientFill? value)
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
  
  private static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlipFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.BlipFill? value)
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
  
  private static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPatternFill(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.PatternFill? value)
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
  
  private static DocumentModel.Drawings.Outline? GetOutline(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OutlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOutline(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.OutlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.EffectList? GetEffectList(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectList(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.EffectListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.EffectDag? GetEffectDag(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectDag(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.EffectDagConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Scene3DType? GetScene3DType(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Scene3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScene3DType(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Scene3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Shape3DType? GetShape3DType(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Shape3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape3DType(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Shape3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartShapeProperties();
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.Transform2D = GetTransform2D(openXmlElement);
      value.CustomGeometry = GetCustomGeometry(openXmlElement);
      value.PresetGeometry = GetPresetGeometry(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.Outline = GetOutline(openXmlElement);
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartShapeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlackWhiteMode(openXmlElement, value?.BlackWhiteMode);
      SetTransform2D(openXmlElement, value?.Transform2D);
      SetCustomGeometry(openXmlElement, value?.CustomGeometry);
      SetPresetGeometry(openXmlElement, value?.PresetGeometry);
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetOutline(openXmlElement, value?.Outline);
      SetEffectList(openXmlElement, value?.EffectList);
      SetEffectDag(openXmlElement, value?.EffectDag);
      SetScene3DType(openXmlElement, value?.Scene3DType);
      SetShape3DType(openXmlElement, value?.Shape3DType);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
