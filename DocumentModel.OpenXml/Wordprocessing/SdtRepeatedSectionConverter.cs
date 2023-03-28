namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
public static class SdtRepeatedSectionConverter
{
  /// <summary>
  /// SectionTitle.
  /// </summary>
  private static String? GetSectionTitle(DXO2013W.SdtRepeatedSection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2013W.SectionTitle>()?.Val);
  }
  
  private static bool CmpSectionTitle(DXO2013W.SdtRepeatedSection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2013W.SectionTitle>()?.Val, value, diffs, objName, "SectionTitle");
  }
  
  private static void SetSectionTitle(DXO2013W.SdtRepeatedSection openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXO2013W.SectionTitle>(openXmlElement, value);
  }
  
  /// <summary>
  /// DoNotAllowInsertDeleteSection.
  /// </summary>
  private static Boolean? GetDoNotAllowInsertDeleteSection(DXO2013W.SdtRepeatedSection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013W.DoNotAllowInsertDeleteSection>() != null;
  }
  
  private static bool CmpDoNotAllowInsertDeleteSection(DXO2013W.SdtRepeatedSection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2013W.DoNotAllowInsertDeleteSection>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2013W.DoNotAllowInsertDeleteSection", val, value);
    return false;
  }
  
  private static void SetDoNotAllowInsertDeleteSection(DXO2013W.SdtRepeatedSection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013W.DoNotAllowInsertDeleteSection>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013W.DoNotAllowInsertDeleteSection();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtRepeatedSection? CreateModelElement(DXO2013W.SdtRepeatedSection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtRepeatedSection();
      value.SectionTitle = GetSectionTitle(openXmlElement);
      value.DoNotAllowInsertDeleteSection = GetDoNotAllowInsertDeleteSection(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013W.SdtRepeatedSection? openXmlElement, DMW.SdtRepeatedSection? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSectionTitle(openXmlElement, value.SectionTitle, diffs, objName))
        ok = false;
      if (!CmpDoNotAllowInsertDeleteSection(openXmlElement, value.DoNotAllowInsertDeleteSection, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtRepeatedSection value)
    where OpenXmlElementType: DXO2013W.SdtRepeatedSection, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013W.SdtRepeatedSection openXmlElement, DMW.SdtRepeatedSection value)
  {
    SetSectionTitle(openXmlElement, value?.SectionTitle);
    SetDoNotAllowInsertDeleteSection(openXmlElement, value?.DoNotAllowInsertDeleteSection);
  }
}
