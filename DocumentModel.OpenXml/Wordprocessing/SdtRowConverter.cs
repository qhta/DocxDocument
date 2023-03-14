namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public static class SdtRowConverter
{
  #region StdRow conversion
  public static DMW.SdtRow? CreateModelElement(DXW.SdtRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtRow();
      value.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      SdtContentRowConverter.FillModelElement(openXmlElement.GetFirstChild<DXW.SdtContentRow>(), value);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.SdtRow? openXmlElement, DMW.SdtRow? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!SdtContentRowConverter.CompareSdtContentRowElement(openXmlElement, value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.SdtRow CreateOpenXmlElement(DMW.SdtRow value)
  {
    var openXmlElement = new DXW.SdtRow();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.SdtRow openXmlElement, DMW.SdtRow value)
  {
    SdtElementConverter.SetSdtProperties(openXmlElement, value.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties);
    openXmlElement.SdtContentRow = SdtContentRowConverter.CreateSdtContentRow(value);
  }
  #endregion
}
