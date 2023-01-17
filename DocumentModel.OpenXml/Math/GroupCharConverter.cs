namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public static class GroupCharConverter
{
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  private static DocumentModel.Math.GroupCharProperties? GetGroupCharProperties(DocumentFormat.OpenXml.Math.GroupChar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.GroupCharProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.GroupCharPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupCharProperties(DocumentFormat.OpenXml.Math.GroupChar openXmlElement, DocumentModel.Math.GroupCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GroupCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.GroupCharPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.GroupCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.GroupChar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DocumentFormat.OpenXml.Math.GroupChar openXmlElement, DocumentModel.Math.Base? value)
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
  
  public static DocumentModel.Math.GroupChar? CreateModelElement(DocumentFormat.OpenXml.Math.GroupChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.GroupChar();
      value.GroupCharProperties = GetGroupCharProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.GroupChar? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.GroupChar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupCharProperties(openXmlElement, value?.GroupCharProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
