namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public static class SdtRowConverter
{
  ///// <summary>
  ///// Row-Level Structured Document Tag Content.
  ///// </summary>
  //private static DMW.SdtContentRow? GetSdtContentRow(DXW.SdtRow openXmlElement)
  //{
  //  var element = openXmlElement?.GetFirstChild<DXW.SdtContentRow>();
  //  if (element != null)
  //    return DMXW.SdtContentRowConverter.CreateModelElement(element);
  //  return null;
  //}

  //private static bool CmpSdtContentRow(DXW.SdtRow openXmlElement, DMW.SdtContentRow? value, DiffList? diffs, string? objName)
  //{
  //  return DMXW.SdtContentRowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentRow>(), value, diffs, objName);
  //}

  //private static void SetSdtContentRow(DXW.SdtRow openXmlElement, DMW.SdtContentRow? value)
  //{
  //  var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentRow>();
  //  if (itemElement != null)
  //    itemElement.Remove();
  //  if (value != null)
  //  {
  //    itemElement = DMXW.SdtContentRowConverter.CreateOpenXmlElement(value);
  //    if (itemElement != null)
  //      openXmlElement.AddChild(itemElement);
  //  }
  //}

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
