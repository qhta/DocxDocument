namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag Content.
/// </summary>
public static class SdtContentRowConverter
{
 
  #region SdtContentRow elements conversion
  public static DMW.ISdtRowElement? CreateSdtContentRowElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.TableRow tableRow)
      return DMXW.TableRowConverter.CreateModelElement(tableRow);
    if (openXmlElement is DXW.SdtRow sdtRow)
      return DMXW.SdtRowConverter.CreateModelElement(sdtRow);
    if (openXmlElement is DXW.CustomXmlRow customXmlRow)
      return DMXW.CustomXmlRowConverter.CreateModelElement(customXmlRow);

    var result = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (result != null)
      return result;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in TableRowConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareSdtContentRowElement(DX.OpenXmlElement? openXmlElement, DMW.ISdtRowElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.TableRow tableRow && value is DMW.TableRow tableRowModel)
        return DMXW.TableRowConverter.CompareModelElement(tableRow, tableRowModel, diffs, objName);
      if (openXmlElement is DXW.SdtRow sdtRow && value is DMW.SdtRow sdtRowModel)
        return DMXW.SdtRowConverter.CompareModelElement(sdtRow, sdtRowModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRow customXmlRow && value is DMW.CustomXmlRow customXmlRowModel)
        return DMXW.CustomXmlRowConverter.CompareModelElement(customXmlRow, customXmlRowModel, diffs, objName);

      if (value is DMW.ICommonElement commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, value.GetType().Name);
      return false;
     }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DMW.ISdtRowElement value)
  {
    if (value is DMW.TableRow tableRow)
      return DMXW.TableRowConverter.CreateOpenXmlElement(tableRow);
    if (value is DMW.SdtRow sdtRow)
      return DMXW.SdtRowConverter.CreateOpenXmlElement(sdtRow);
    if (value is DMW.CustomXmlRow customXmlRow)
      return DMXW.CustomXmlRowConverter.CreateOpenXmlElement(customXmlRow);

    var result = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonElement);
    if (result != null) return result;
    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in TableRowConverter.CreateOpenXmlElement method");
  }
  #endregion

  #region SdtContentRow conversion
  public static void FillModelElement(DXW.SdtContentRow? openXmlElement, ElementCollection<DMW.ISdtRowElement> value)
  {
    if (openXmlElement != null)
    {
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        var item = CreateSdtContentRowElement(element);
        if (item != null)
          value.Add(item);
      }
    }
  }

  public static bool CompareModelElement(DXW.SdtContentRow? openXmlElement, ElementCollection<DMW.ISdtRowElement>? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      var sdtRowItems = value.ToArray();
      var elements = openXmlElement.Elements().Where(item => !(item is DXW.SdtProperties) && !(item is DXW.SdtEndCharProperties)).ToArray();
      for (int i = 0; i < System.Math.Min(sdtRowItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = sdtRowItems[i];
        if (!CompareSdtContentRowElement(element, item, diffs, objName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), sdtRowItems.Count(), diffs, objName, "SdtContentRow.Items.Count"))
        ok = false;

      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.SdtContentRow CreateSdtContentRow(ElementCollection<DMW.ISdtRowElement> value)
  {
    var openXmlElement = new DXW.SdtContentRow();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.SdtContentRow openXmlElement, ElementCollection<DMW.ISdtRowElement> value)
  {
    var sdtContentRowItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < sdtContentRowItems.Count(); i++)
    {
      var item = sdtContentRowItems[i];
      OpenXmlElement? element = elementsEnumerator.MoveNext() ? elementsEnumerator.Current : null;
      if (element == null)
      {
        element = CreateOpenXmlElement(item);
        openXmlElement.AddChild(element);
      }
    }
  }
  #endregion
}
