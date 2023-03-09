namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public static class SdtRowConverter
{
  #region SdtProperties conversion
  private static DMW.SdtProperties? GetSdtProperties(DXW.SdtRow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtProperties>();
    if (element != null)
      return DMXW.SdtPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtProperties(DXW.SdtRow openXmlElement, DMW.SdtProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtProperties>(), value, diffs, objName);
  }
  
  private static void SetSdtProperties(DXW.SdtRow openXmlElement, DMW.SdtProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtPropertiesConverter.CreateOpenXmlElement<DXW.SdtProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region SdtEndCharProperties conversion
  private static DMW.SdtEndCharProperties? GetSdtEndCharProperties(DXW.SdtRow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtEndCharProperties>();
    if (element != null)
      return DMXW.SdtEndCharPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtEndCharProperties(DXW.SdtRow openXmlElement, DMW.SdtEndCharProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtEndCharPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>(), value, diffs, objName);
  }
  
  private static void SetSdtEndCharProperties(DXW.SdtRow openXmlElement, DMW.SdtEndCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtEndCharPropertiesConverter.CreateOpenXmlElement<DXW.SdtEndCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region SdtRow elements conversion
  public static DMW.ISdtRowElement? CreateSdtRowElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.SdtContentRow sdtContentRow)
      return DMXW.SdtContentRowConverter.CreateModelElement(sdtContentRow);

    var result = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (result != null)
      return result;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in SdtRowConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareSdtRowElement(DX.OpenXmlElement? openXmlElement, DMW.ISdtRowElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.SdtContentRow sdtContentRow && value is DMW.SdtContentRow sdtContentRowModel)
        return DMXW.SdtContentRowConverter.CompareModelElement(sdtContentRow, sdtContentRowModel, diffs, objName);

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
    if (value is DMW.SdtContentRow sdtContentRow)
      return DMXW.SdtContentRowConverter.CreateOpenXmlElement(sdtContentRow);

    var result = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonElement);
    if (result != null) return result;
    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in SdtRowConverter.CreateOpenXmlElement method");
  }
  #endregion

  #region SdtRow conversion
  public static DMW.SdtRow? CreateModelElement(DXW.SdtRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtRow();
      value.SdtProperties = GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = GetSdtEndCharProperties(openXmlElement);
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        if (element is DXW.SdtProperties)
          continue;
        if (element is DXW.SdtEndCharProperties)
          continue;
        var item = CreateSdtRowElement(element);
        if (item != null)
          value.Add(item);
      }
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtRow? openXmlElement, DMW.SdtRow? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName))
        ok = false;
      if (!CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName))
        ok = false;
      var sdtRowItems = value.ToArray();
      var elements = openXmlElement.Elements().Where(item => !(item is DXW.SdtProperties) && !(item is DXW.SdtEndCharProperties)).ToArray();
      for (int i = 0; i < System.Math.Min(sdtRowItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = sdtRowItems[i];
        if (!CompareSdtRowElement(element, item, diffs, objName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), sdtRowItems.Count(), diffs, objName, "TableRow.Items.Count"))
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
    SetSdtProperties(openXmlElement, value.SdtProperties);
    SetSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties);
    var sdtRowItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < sdtRowItems.Count(); i++)
    {
      var item = sdtRowItems[i];
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
