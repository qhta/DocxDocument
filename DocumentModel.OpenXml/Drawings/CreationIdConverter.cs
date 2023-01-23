namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CreationId Class.
/// </summary>
public static class CreationIdConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetId(DXO2016Draw.CreationId openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2016Draw.CreationId openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2016Draw.CreationId openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMDraws.CreationId? CreateModelElement(DXO2016Draw.CreationId? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CreationId();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016Draw.CreationId? openXmlElement, DMDraws.CreationId? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CreationId? value)
    where OpenXmlElementType: DXO2016Draw.CreationId, new()
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
