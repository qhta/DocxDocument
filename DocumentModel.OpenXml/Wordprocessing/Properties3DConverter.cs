namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public static class Properties3DConverter
{
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetExtrusionHeight(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }
  
  public static void SetExtrusionHeight(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetContourWidth(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }
  
  public static void SetContourWidth(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.PresetMaterialKind? GetPresetMaterialType(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues, DocumentModel.Wordprocessing.PresetMaterialKind>(openXmlElement?.PresetMaterialType?.Value);
  }
  
  public static void SetPresetMaterialType(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.PresetMaterialKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetMaterialType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues, DocumentModel.Wordprocessing.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public static DocumentModel.Wordprocessing.BevelType? GetBevelTop(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelTop>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBevelTop(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.BevelType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelTop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.BevelTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.BevelTop>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public static DocumentModel.Wordprocessing.BevelType? GetBevelBottom(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelBottom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBevelBottom(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.BevelType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.BevelTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.BevelBottom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public static DocumentModel.Wordprocessing.ExtrusionColor? GetExtrusionColor(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ExtrusionColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtrusionColor(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.ExtrusionColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ExtrusionColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public static DocumentModel.Wordprocessing.ContourColor? GetContourColor(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContourColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ContourColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetContourColor(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.ContourColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContourColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ContourColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.ContourColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Properties3D? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Properties3D();
      value.ExtrusionHeight = GetExtrusionHeight(openXmlElement);
      value.ContourWidth = GetContourWidth(openXmlElement);
      value.PresetMaterialType = GetPresetMaterialType(openXmlElement);
      value.BevelTop = GetBevelTop(openXmlElement);
      value.BevelBottom = GetBevelBottom(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      value.ContourColor = GetContourColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Properties3D? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Properties3D, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
