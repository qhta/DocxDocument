namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Style.
/// </summary>
public static class StyleConverter
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public static DocumentModel.Drawings.LineReference? GetLineReference(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineReference(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement, DocumentModel.Drawings.LineReference? value)
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
  public static DocumentModel.Drawings.FillReference? GetFillReference(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillReference(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement, DocumentModel.Drawings.FillReference? value)
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
  public static DocumentModel.Drawings.EffectReference? GetEffectReference(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectReference(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement, DocumentModel.Drawings.EffectReference? value)
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
  public static DocumentModel.Drawings.FontReference? GetFontReference(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FontReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFontReference(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement, DocumentModel.Drawings.FontReference? value)
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
  
  public static DocumentModel.Drawings.Diagrams.Style? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Style();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Style? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Style, new()
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
