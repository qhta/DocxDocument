namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Run Properties.
/// </summary>
public static class RunPropertiesDefaultConverter
{
  //private static DMW.RunPropertiesBaseStyle? GetRunPropertiesBaseStyle(DXW.RunPropertiesDefault openXmlElement)
  //{
  //  var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
  //  if (element != null)
  //    return DMXW.RunPropertiesBaseStyleConverter.CreateModelElement(element);
  //  return null;
  //}

  //private static bool CmpRunPropertiesBaseStyle(DXW.RunPropertiesDefault openXmlElement, DMW.RunPropertiesBaseStyle? value, DiffList? diffs, string? objName)
  //{
  //  return DMXW.RunPropertiesBaseStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>(), value, diffs, objName);
  //}

  //private static void SetRunPropertiesBaseStyle(DXW.RunPropertiesDefault openXmlElement, DMW.RunPropertiesBaseStyle? value)
  //{
  //  var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>();
  //  if (itemElement != null)
  //    itemElement.Remove();
  //  if (value != null)
  //  {
  //    itemElement = DMXW.RunPropertiesBaseStyleConverter.CreateOpenXmlElement<DXW.RunPropertiesBaseStyle>(value);
  //    if (itemElement != null)
  //      openXmlElement.AddChild(itemElement);
  //  }
  //}

  public static DMW.RunPropertiesDefault? CreateModelElement(DXW.RunPropertiesDefault? openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null)
    {
      var value = new DMW.RunPropertiesDefault();
      RunPropertiesBaseStyleConverter.UpdateModelElement(value, element);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.RunPropertiesDefault? openXmlElement, DMW.RunPropertiesDefault? value, DiffList? diffs, string? objName)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null && value != null)
    {
      var ok = true;
      if (!RunPropertiesBaseStyleConverter.CompareModelElement(element, value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.RunPropertiesDefault CreateOpenXmlElement(DMW.RunPropertiesDefault value)
  {
    var openXmlElement = new DXW.RunPropertiesDefault();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.RunPropertiesDefault openXmlElement, DMW.RunPropertiesDefault value)
  {
    var element = openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null)
      RunPropertiesBaseStyleConverter.UpdateOpenXmlElement(element, value);
    else
    {
      element = RunPropertiesBaseStyleConverter.CreateOpenXmlElement(value);
      openXmlElement.AddChild(element);
    }
  }
}
