namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run-Level Structured Document Tag.
/// </summary>
public static class SdtRunConverter
{
  #region SdtProperties conversion
  private static DMW.SdtProperties? GetSdtProperties(DXW.SdtRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtProperties>();
    if (element != null)
      return DMXW.SdtPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtProperties(DXW.SdtRun openXmlElement, DMW.SdtProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtProperties>(), value, diffs, objName);
  }
  
  private static void SetSdtProperties(DXW.SdtRun openXmlElement, DMW.SdtProperties? value)
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
  private static DMW.SdtEndCharProperties? GetSdtEndCharProperties(DXW.SdtRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtEndCharProperties>();
    if (element != null)
      return DMXW.SdtEndCharPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtEndCharProperties(DXW.SdtRun openXmlElement, DMW.SdtEndCharProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtEndCharPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>(), value, diffs, objName);
  }
  
  private static void SetSdtEndCharProperties(DXW.SdtRun openXmlElement, DMW.SdtEndCharProperties? value)
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

  #region SdtRun elements conversion
  public static DMW.ISdtRunElement? CreateSdtRunElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.SdtContentRun sdtContentRun)
      return DMXW.SdtContentRunConverter.CreateModelElement(sdtContentRun);

    var result = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (result != null)
      return result;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in SdtRunConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareSdtRunElement(DX.OpenXmlElement? openXmlElement, DMW.ISdtRunElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.SdtContentRun sdtContentRun && value is DMW.SdtContentRun sdtContentRunModel)
        return DMXW.SdtContentRunConverter.CompareModelElement(sdtContentRun, sdtContentRunModel, diffs, objName);

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

  public static OpenXmlElement CreateOpenXmlElement(DMW.ISdtRunElement value)
  {
    if (value is DMW.SdtContentRun sdtContentRun)
      return DMXW.SdtContentRunConverter.CreateOpenXmlElement(sdtContentRun);

    var result = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonElement);
    if (result != null) return result;
    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in SdtRunConverter.CreateOpenXmlElement method");
  }
  #endregion

  #region SdtRun conversion
  public static DMW.SdtRun? CreateModelElement(DXW.SdtRun? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtRun();
      value.SdtProperties = GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = GetSdtEndCharProperties(openXmlElement);
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        if (element is DXW.SdtProperties)
          continue;
        if (element is DXW.SdtEndCharProperties)
          continue;
        var item = CreateSdtRunElement(element);
        if (item != null)
          value.Add(item);
      }
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtRun? openXmlElement, DMW.SdtRun? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName))
        ok = false;
      if (!CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName))
        ok = false;
      var sdtRunItems = value.ToArray();
      var elements = openXmlElement.Elements().Where(item => !(item is DXW.SdtProperties) && !(item is DXW.SdtEndCharProperties)).ToArray();
      for (int i = 0; i < System.Math.Min(sdtRunItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = sdtRunItems[i];
        if (!CompareSdtRunElement(element, item, diffs, objName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), sdtRunItems.Count(), diffs, objName, "TableRun.Items.Count"))
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
    SetSdtProperties(openXmlElement, value.SdtProperties);
    SetSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties);
    var sdtRunItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < sdtRunItems.Count(); i++)
    {
      var item = sdtRunItems[i];
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
