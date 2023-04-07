namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// RunPropertiesDefault class from/to OpenXml converter.
/// </summary>
public static class RunPropertiesDefaultConverter
{
  #region RunPropertiesDefault model conversion.
  public static DMW.DefaultRunProperties? CreateModelElement(DXW.RunPropertiesDefault? openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null)
    {
      var value = new DMW.DefaultRunProperties();
      RunPropertiesBaseStyleConverter.UpdateModelElement(value, element);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.RunPropertiesDefault? openXmlElement, DMW.DefaultRunProperties? value, DiffList? diffs, string? objName)
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

  public static DXW.RunPropertiesDefault CreateOpenXmlElement(DMW.DefaultRunProperties value)
  {
    var openXmlElement = new DXW.RunPropertiesDefault();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.RunPropertiesDefault openXmlElement, DMW.DefaultRunProperties value)
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
  #endregion
}
