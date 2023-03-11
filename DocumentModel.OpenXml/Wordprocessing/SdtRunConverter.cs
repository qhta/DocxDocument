namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run-Level Structured Document Tag.
/// </summary>
public static class SdtRunConverter
{
  /// <summary>
  /// Run-Level Structured Document Tag Content.
  /// </summary>
  private static DMW.SdtContentRun? GetSdtContentRun(DXW.SdtRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtContentRun>();
    if (element != null)
      return DMXW.SdtContentRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtContentRun(DXW.SdtRun openXmlElement, DMW.SdtContentRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentRun>(), value, diffs, objName);
  }
  
  private static void SetSdtContentRun(DXW.SdtRun openXmlElement, DMW.SdtContentRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentRunConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  #region StdRun conversion
  public static DMW.SdtRun? CreateModelElement(DXW.SdtRun? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtRun();
      value.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      value.SdtContentRun = GetSdtContentRun(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtRun? openXmlElement, DMW.SdtRun? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!CmpSdtContentRun(openXmlElement, value.SdtContentRun, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.SdtRun CreateOpenXmlElement(DMW.SdtRun value)
  {
    var openXmlElement = new DXW.SdtRun();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtRun openXmlElement, DMW.SdtRun value)
  {
    SdtElementConverter.SetSdtProperties(openXmlElement, value?.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, value?.SdtEndCharProperties);
    SetSdtContentRun(openXmlElement, value?.SdtContentRun);
  }
  #endregion
}
