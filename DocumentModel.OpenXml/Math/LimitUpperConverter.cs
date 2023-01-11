namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Upper-Limit Function.
/// </summary>
public static class LimitUpperConverter
{
  /// <summary>
  /// Upper Limit Properties.
  /// </summary>
  public static DocumentModel.Math.LimitUpperProperties? GetLimitUpperProperties(DocumentFormat.OpenXml.Math.LimitUpper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpperProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitUpperPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLimitUpperProperties(DocumentFormat.OpenXml.Math.LimitUpper? openXmlElement, DocumentModel.Math.LimitUpperProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpperProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.LimitUpperPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitUpperProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.LimitUpper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.LimitUpper? openXmlElement, DocumentModel.Math.Base? value)
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
  /// Limit (Upper).
  /// </summary>
  public static DocumentModel.Math.Limit? GetLimit(DocumentFormat.OpenXml.Math.LimitUpper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLimit(DocumentFormat.OpenXml.Math.LimitUpper? openXmlElement, DocumentModel.Math.Limit? value)
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
  
  public static DocumentModel.Math.LimitUpper? CreateModelElement(DocumentFormat.OpenXml.Math.LimitUpper? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.LimitUpper();
      value.LimitUpperProperties = GetLimitUpperProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.LimitUpper? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.LimitUpper, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
