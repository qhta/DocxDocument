namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category.
/// </summary>
public static class CategoryConverter
{
  /// <summary>
  /// Category Type
  /// </summary>
  private static String? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Category openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Category openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  private static UInt32? GetPriority(DocumentFormat.OpenXml.Drawing.Diagrams.Category openXmlElement)
  {
    return openXmlElement.Priority?.Value;
  }
  
  private static void SetPriority(DocumentFormat.OpenXml.Drawing.Diagrams.Category openXmlElement, UInt32? value)
  {
    openXmlElement.Priority = value;
  }
  
  public static DocumentModel.Drawings.Diagrams.Category? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Category? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Category();
      value.Type = GetType(openXmlElement);
      value.Priority = GetPriority(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Category? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Category, new()
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
