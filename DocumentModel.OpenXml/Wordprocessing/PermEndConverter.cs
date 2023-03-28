namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public static class PermEndConverter
{
  /// <summary>
  /// Annotation ID
  /// </summary>
  private static Int32? GetId(DXW.PermEnd openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.PermEnd openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.PermEnd openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.PermEnd openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static bool CmpDisplacedByCustomXml(DXW.PermEnd openXmlElement, DMW.DisplacedByCustomXmlKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value, value, diffs, objName);
  }
  
  private static void SetDisplacedByCustomXml(DXW.PermEnd openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  public static DMW.PermEnd? CreateModelElement(DXW.PermEnd? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PermEnd();
      value.Id = GetId(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PermEnd? openXmlElement, DMW.PermEnd? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpDisplacedByCustomXml(openXmlElement, value.DisplacedByCustomXml, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.PermEnd CreateOpenXmlElement(DMW.PermEnd value)
  {
    var openXmlElement = new DXW.PermEnd();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.PermEnd openXmlElement, DMW.PermEnd value)
  {
    SetId(openXmlElement, value?.Id);
    SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
    return true;
  }
}
