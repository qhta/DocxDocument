namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Accent.
/// </summary>
public static class AccentConverter
{
  /// <summary>
  /// Accent Properties.
  /// </summary>
  private static DocumentModel.Math.AccentProperties? GetAccentProperties(DocumentFormat.OpenXml.Math.Accent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.AccentProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.AccentPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccentProperties(DocumentFormat.OpenXml.Math.Accent openXmlElement, DocumentModel.Math.AccentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AccentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.AccentPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.AccentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.Accent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DocumentFormat.OpenXml.Math.Accent openXmlElement, DocumentModel.Math.Base? value)
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
  
  public static DocumentModel.Math.Accent? CreateModelElement(DocumentFormat.OpenXml.Math.Accent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Accent();
      value.AccentProperties = GetAccentProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Accent? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Accent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentProperties(openXmlElement, value?.AccentProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
