namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category.
/// </summary>
public static class CategoryConverter
{
  /// <summary>
  /// Category Type
  /// </summary>
  private static String? GetType(DXDrawDgms.Category openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static void SetType(DXDrawDgms.Category openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  private static UInt32? GetPriority(DXDrawDgms.Category openXmlElement)
  {
    return openXmlElement.Priority?.Value;
  }
  
  private static void SetPriority(DXDrawDgms.Category openXmlElement, UInt32? value)
  {
    openXmlElement.Priority = value;
  }
  
  public static DMDrawsDgms.Category? CreateModelElement(DXDrawDgms.Category? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Category();
      value.Type = GetType(openXmlElement);
      value.Priority = GetPriority(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Category? value)
    where OpenXmlElementType: DXDrawDgms.Category, new()
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
