namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Column.
/// </summary>
public static class MatrixColumnConverter
{
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  public static DocumentModel.Math.MatrixColumnProperties? GetMatrixColumnProperties(DocumentFormat.OpenXml.Math.MatrixColumn? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.MatrixColumnPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMatrixColumnProperties(DocumentFormat.OpenXml.Math.MatrixColumn? openXmlElement, DocumentModel.Math.MatrixColumnProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.MatrixColumnPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixColumnProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.MatrixColumn? CreateModelElement(DocumentFormat.OpenXml.Math.MatrixColumn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MatrixColumn();
      value.MatrixColumnProperties = GetMatrixColumnProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.MatrixColumn? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.MatrixColumn, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMatrixColumnProperties(openXmlElement, value?.MatrixColumnProperties);
      return openXmlElement;
    }
    return default;
  }
}
