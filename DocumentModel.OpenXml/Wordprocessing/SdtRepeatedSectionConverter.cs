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
      return openXmlElement?.GetFirstChild<DXO2013W.SectionTitle>()?.Val?.Value;
  }
  
  private static bool CmpSectionTitle(DXO2013W.SdtRepeatedSection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2013W.SectionTitle>()?.Val?.Value == value;
  }
  
  private static void SetSectionTitle(DXO2013W.SdtRepeatedSection openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.SectionTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013W.SectionTitle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
    return openXmlElement.GetFirstChild<DXO2013W.DoNotAllowInsertDeleteSection>() != null == value;
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtRepeatedSection? value)
    where OpenXmlElementType: DXO2013W.SdtRepeatedSection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSectionTitle(openXmlElement, value?.SectionTitle);
      SetDoNotAllowInsertDeleteSection(openXmlElement, value?.DoNotAllowInsertDeleteSection);
      return openXmlElement;
    }
    return default;
  }
}
