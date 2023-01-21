namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Category.
/// </summary>
public static class ColorTransformCategoryConverter
{
  /// <summary>
  /// Category Type
  /// </summary>
  private static String? GetType(DXDrawDgms.ColorTransformCategory openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static void SetType(DXDrawDgms.ColorTransformCategory openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  private static UInt32? GetPriority(DXDrawDgms.ColorTransformCategory openXmlElement)
  {
    return openXmlElement.Priority?.Value;
  }
  
  private static void SetPriority(DXDrawDgms.ColorTransformCategory openXmlElement, UInt32? value)
  {
    openXmlElement.Priority = value;
  }
  
  public static DMDrawsDgms.ColorTransformCategory? CreateModelElement(DXDrawDgms.ColorTransformCategory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ColorTransformCategory();
      value.Type = GetType(openXmlElement);
      value.Priority = GetPriority(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorTransformCategory? value)
    where OpenXmlElementType: DXDrawDgms.ColorTransformCategory, new()
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
