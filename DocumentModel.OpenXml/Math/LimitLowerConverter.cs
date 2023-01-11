namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Lower-Limit Function.
/// </summary>
public static class LimitLowerConverter
{
  /// <summary>
  /// Lower Limit Properties.
  /// </summary>
  public static DocumentModel.Math.LimitLowerProperties? GetLimitLowerProperties(DocumentFormat.OpenXml.Math.LimitLower? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLowerProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitLowerPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLimitLowerProperties(DocumentFormat.OpenXml.Math.LimitLower? openXmlElement, DocumentModel.Math.LimitLowerProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLowerProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.LimitLowerPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLowerProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.LimitLower? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.LimitLower? openXmlElement, DocumentModel.Math.Base? value)
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
  
  /// <summary>
  /// Limit (Lower).
  /// </summary>
  public static DocumentModel.Math.Limit? GetLimit(DocumentFormat.OpenXml.Math.LimitLower? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLimit(DocumentFormat.OpenXml.Math.LimitLower? openXmlElement, DocumentModel.Math.Limit? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.LimitConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Limit>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.LimitLower? CreateModelElement(DocumentFormat.OpenXml.Math.LimitLower? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.LimitLower();
      value.LimitLowerProperties = GetLimitLowerProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.LimitLower? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.LimitLower, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
