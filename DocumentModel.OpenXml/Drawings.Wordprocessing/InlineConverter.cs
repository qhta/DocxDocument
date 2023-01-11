namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
public static class InlineConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public static UInt32? GetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }
  
  public static void SetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }
  
  public static void SetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  public static void SetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  public static void SetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetAnchorId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetAnchorId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetEditId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetEditId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Drawing Object Size.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.Extent? GetExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.ExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, DocumentModel.Drawings.Wordprocessing.Extent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.ExtentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Inline Wrapping Extent.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? GetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, DocumentModel.Drawings.Wordprocessing.EffectExtent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.EffectExtentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.DocProperties? GetDocProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.DocPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDocProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, DocumentModel.Drawings.Wordprocessing.DocProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.DocPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualGraphicFrameDrawingProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public static DocumentModel.Drawings.Graphic? GetGraphic(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GraphicConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGraphic(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement, DocumentModel.Drawings.Graphic? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.GraphicConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Graphic>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.Inline? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.Inline();
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.AnchorId = GetAnchorId(openXmlElement);
      value.EditId = GetEditId(openXmlElement);
      value.Extent = GetExtent(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      value.DocProperties = GetDocProperties(openXmlElement);
      value.NonVisualGraphicFrameDrawingProperties = GetNonVisualGraphicFrameDrawingProperties(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.Inline? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
