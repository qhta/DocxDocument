namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public static class SaveThroughXsltConverter
{
  /// <summary>
  /// XSL Transformation Location
  /// </summary>
  private static String? GetId(DXW.SaveThroughXslt openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.SaveThroughXslt openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.SaveThroughXslt openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Local Identifier for XSL Transform
  /// </summary>
  private static String? GetSolutionId(DXW.SaveThroughXslt openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SolutionId);
  }
  
  private static bool CmpSolutionId(DXW.SaveThroughXslt openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SolutionId, value, diffs, objName, "SolutionId");
  }
  
  private static void SetSolutionId(DXW.SaveThroughXslt openXmlElement, String? value)
  {
    openXmlElement.SolutionId = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.SaveThroughXslt? CreateModelElement(DXW.SaveThroughXslt? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SaveThroughXslt();
      value.Id = GetId(openXmlElement);
      value.SolutionId = GetSolutionId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SaveThroughXslt? openXmlElement, DMW.SaveThroughXslt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpSolutionId(openXmlElement, value.SolutionId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SaveThroughXslt value)
    where OpenXmlElementType: DXW.SaveThroughXslt, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SaveThroughXslt openXmlElement, DMW.SaveThroughXslt value)
  {
    SetId(openXmlElement, value?.Id);
    SetSolutionId(openXmlElement, value?.SolutionId);
  }
}
