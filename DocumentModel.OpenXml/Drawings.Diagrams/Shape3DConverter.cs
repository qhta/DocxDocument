namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// 3-D Shape Properties.
/// </summary>
public static class Shape3DConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  public static Int64? GetZ(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  public static void SetZ(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Z = value;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public static Int64? GetExtrusionHeight(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }
  
  public static void SetExtrusionHeight(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public static Int64? GetContourWidth(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }
  
  public static void SetContourWidth(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public static DocumentModel.Drawings.PresetMaterialKind? GetPresetMaterial(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DocumentModel.Drawings.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  public static void SetPresetMaterial(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, DocumentModel.Drawings.PresetMaterialKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DocumentModel.Drawings.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public static DocumentModel.Drawings.BevelType? GetBevelTop(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelTop>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBevelTop(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, DocumentModel.Drawings.BevelType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelTop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BevelTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BevelTop>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public static DocumentModel.Drawings.BevelType? GetBevelBottom(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelBottom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBevelBottom(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, DocumentModel.Drawings.BevelType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BevelTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BevelBottom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public static DocumentModel.Drawings.ExtrusionColor? GetExtrusionColor(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtrusionColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtrusionColor(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, DocumentModel.Drawings.ExtrusionColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtrusionColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtrusionColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public static DocumentModel.Drawings.ContourColor? GetContourColor(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ContourColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetContourColor(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, DocumentModel.Drawings.ContourColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ContourColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ContourColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.Shape3D? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Shape3D();
      value.Z = GetZ(openXmlElement);
      value.ExtrusionHeight = GetExtrusionHeight(openXmlElement);
      value.ContourWidth = GetContourWidth(openXmlElement);
      value.PresetMaterial = GetPresetMaterial(openXmlElement);
      value.BevelTop = GetBevelTop(openXmlElement);
      value.BevelBottom = GetBevelBottom(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      value.ContourColor = GetContourColor(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Shape3D? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
