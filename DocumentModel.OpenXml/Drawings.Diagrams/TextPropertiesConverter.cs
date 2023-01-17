namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Text Properties.
/// </summary>
public static class TextPropertiesConverter
{
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  private static DocumentModel.Drawings.Shape3DType? GetShape3DType(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Shape3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape3DType(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties openXmlElement, DocumentModel.Drawings.Shape3DType? value)
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
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  private static DocumentModel.Drawings.FlatText? GetFlatText(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FlatTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFlatText(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties openXmlElement, DocumentModel.Drawings.FlatText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.FlatTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FlatText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.TextProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.TextProperties();
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.FlatText = GetFlatText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.TextProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShape3DType(openXmlElement, value?.Shape3DType);
      SetFlatText(openXmlElement, value?.FlatText);
      return openXmlElement;
    }
    return default;
  }
}
