namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Group Shape Properties.
/// </summary>
public static class GroupShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  private static DocumentModel.Drawings.BlackWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static void SetBlackWhiteMode(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  private static DocumentModel.Drawings.TransformGroup? GetTransformGroup(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TransformGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TransformGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTransformGroup(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.TransformGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TransformGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.TransformGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TransformGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
    return itemElement != null;
  }
  
  private static void SetNoFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.SolidFill? value)
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
  
  private static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.GradientFill? value)
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
  
  private static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlipFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.BlipFill? value)
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
  
  private static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPatternFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.PatternFill? value)
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
  
  private static Boolean? GetGroupFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
    return itemElement != null;
  }
  
  private static void SetGroupFill(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.EffectList? GetEffectList(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectList(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.EffectList? value)
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
  
  private static DocumentModel.Drawings.EffectDag? GetEffectDag(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectDag(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.EffectDag? value)
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
  
  private static DocumentModel.Drawings.Scene3DType? GetScene3DType(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Scene3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScene3DType(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.Scene3DType? value)
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
  
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawing.GroupShapeProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.GroupShapeProperties();
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.TransformGroup = GetTransformGroup(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.GroupShapeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlackWhiteMode(openXmlElement, value?.BlackWhiteMode);
      SetTransformGroup(openXmlElement, value?.TransformGroup);
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetGroupFill(openXmlElement, value?.GroupFill);
      SetEffectList(openXmlElement, value?.EffectList);
      SetEffectDag(openXmlElement, value?.EffectDag);
      SetScene3DType(openXmlElement, value?.Scene3DType);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
