namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Lower-Limit Function.
/// </summary>
public static class LimitLowerConverter
{
  /// <summary>
  /// Lower Limit Properties.
  /// </summary>
  private static DocumentModel.Math.LimitLowerProperties? GetLimitLowerProperties(DocumentFormat.OpenXml.Math.LimitLower openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLowerProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitLowerPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLimitLowerProperties(DocumentFormat.OpenXml.Math.LimitLower openXmlElement, DocumentModel.Math.LimitLowerProperties? value)
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
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.LimitLower openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DocumentFormat.OpenXml.Math.LimitLower openXmlElement, DocumentModel.Math.Base? value)
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
  
  /// <summary>
  /// Limit (Lower).
  /// </summary>
  private static DocumentModel.Math.Limit? GetLimit(DocumentFormat.OpenXml.Math.LimitLower openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLimit(DocumentFormat.OpenXml.Math.LimitLower openXmlElement, DocumentModel.Math.Limit? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimitLowerProperties(openXmlElement, value?.LimitLowerProperties);
      SetBase(openXmlElement, value?.Base);
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}
