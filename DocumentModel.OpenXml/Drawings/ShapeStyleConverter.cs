namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Style.
/// </summary>
public static class ShapeStyleConverter
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public static DocumentModel.Drawings.LineReference? GetLineReference(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineReference(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement, DocumentModel.Drawings.LineReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LineReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public static DocumentModel.Drawings.FillReference? GetFillReference(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillReference(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement, DocumentModel.Drawings.FillReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.FillReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public static DocumentModel.Drawings.EffectReference? GetEffectReference(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectReference(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement, DocumentModel.Drawings.EffectReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.EffectReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public static DocumentModel.Drawings.FontReference? GetFontReference(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FontReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFontReference(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement, DocumentModel.Drawings.FontReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.FontReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FontReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ShapeStyle? CreateModelElement(DocumentFormat.OpenXml.Drawing.ShapeStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapeStyle();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapeStyle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ShapeStyle, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
