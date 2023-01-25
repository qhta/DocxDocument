namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MarkupType Class.
/// </summary>
public static class MarkupTypeConverter
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.MarkupType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.MarkupType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.MarkupType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.MarkupType? CreateModelElement(DXW.MarkupType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MarkupType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.MarkupType? openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MarkupType? value)
    where OpenXmlElementType: DXW.MarkupType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
