namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ToolbarData Class.
/// </summary>
public static class ToolbarDataConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOW.ToolbarData openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOW.ToolbarData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXOW.ToolbarData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.ToolbarData? CreateModelElement(DXOW.ToolbarData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ToolbarData();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.ToolbarData? openXmlElement, DMW.ToolbarData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ToolbarData? value)
    where OpenXmlElementType: DXOW.ToolbarData, new()
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
