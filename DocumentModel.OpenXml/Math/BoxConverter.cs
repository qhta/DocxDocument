namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Box Function.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// Box Properties.
  /// </summary>
  public static DocumentModel.Math.BoxProperties? GetBoxProperties(DocumentFormat.OpenXml.Math.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BoxProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BoxPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBoxProperties(DocumentFormat.OpenXml.Math.Box? openXmlElement, DocumentModel.Math.BoxProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BoxProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.BoxPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BoxProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.Box? openXmlElement, DocumentModel.Math.Base? value)
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
  
  public static DocumentModel.Math.Box? CreateModelElement(DocumentFormat.OpenXml.Math.Box? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Box();
      value.BoxProperties = GetBoxProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Box? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Box, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
