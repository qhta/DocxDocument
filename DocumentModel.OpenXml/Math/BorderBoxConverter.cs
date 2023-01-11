namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public static class BorderBoxConverter
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public static DocumentModel.Math.BorderBoxProperties? GetBorderBoxProperties(DocumentFormat.OpenXml.Math.BorderBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBoxProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BorderBoxPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBorderBoxProperties(DocumentFormat.OpenXml.Math.BorderBox? openXmlElement, DocumentModel.Math.BorderBoxProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBoxProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.BorderBoxPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BorderBoxProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.BorderBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.BorderBox? openXmlElement, DocumentModel.Math.Base? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.BorderBox? CreateModelElement(DocumentFormat.OpenXml.Math.BorderBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.BorderBox();
      value.BorderBoxProperties = GetBorderBoxProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.BorderBox? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.BorderBox, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
