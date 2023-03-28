namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CreationId Class converter from/to OpenXml.
///</summary>
public static class CreationIdConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetId(DXO2016Draw.CreationId openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2016Draw.CreationId openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2016Draw.CreationId openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.CreationId? CreateModelElement(DXO2016Draw.CreationId? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CreationId();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CreationId value)
    where OpenXmlElementType: DXO2016Draw.CreationId, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016Draw.CreationId openXmlElement, DMDraws.CreationId value)
  {
    SetId(openXmlElement, value?.Id);
  }
}
