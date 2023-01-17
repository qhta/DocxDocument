namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category.
/// </summary>
public static class StyleDisplayCategoryConverter
{
  /// <summary>
  /// Category Type
  /// </summary>
  private static String? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  private static UInt32? GetPriority(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory openXmlElement)
  {
    return openXmlElement.Priority?.Value;
  }
  
  private static void SetPriority(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory openXmlElement, UInt32? value)
  {
    openXmlElement.Priority = value;
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleDisplayCategory? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDisplayCategory();
      value.Type = GetType(openXmlElement);
      value.Priority = GetPriority(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleDisplayCategory? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetPriority(openXmlElement, value?.Priority);
      return openXmlElement;
    }
    return default;
  }
}
