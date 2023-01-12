namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Radical Function.
/// </summary>
public static class RadicalConverter
{
  /// <summary>
  /// Radical Properties.
  /// </summary>
  public static DocumentModel.Math.RadicalProperties? GetRadicalProperties(DocumentFormat.OpenXml.Math.Radical? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.RadicalProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.RadicalPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRadicalProperties(DocumentFormat.OpenXml.Math.Radical? openXmlElement, DocumentModel.Math.RadicalProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.RadicalProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.RadicalPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.RadicalProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Degree.
  /// </summary>
  public static DocumentModel.Math.Degree? GetDegree(DocumentFormat.OpenXml.Math.Radical? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Degree>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.DegreeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDegree(DocumentFormat.OpenXml.Math.Radical? openXmlElement, DocumentModel.Math.Degree? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Degree>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.DegreeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Degree>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.Radical? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.Radical? openXmlElement, DocumentModel.Math.Base? value)
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
  
  public static DocumentModel.Math.Radical? CreateModelElement(DocumentFormat.OpenXml.Math.Radical? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Radical();
      value.RadicalProperties = GetRadicalProperties(openXmlElement);
      value.Degree = GetDegree(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Radical? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Radical, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadicalProperties(openXmlElement, value?.RadicalProperties);
      SetDegree(openXmlElement, value?.Degree);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
