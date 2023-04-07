namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.DefaultRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class DefaultRunPropertiesConverter
{
  #region DefaultRunProperties model conversion.
  public static DMW.DefaultRunProperties? CreateModelElement(DXW.RunPropertiesDefault? openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null)
    {
      var value = new DMW.DefaultRunProperties();
      BaseRunPropertiesConverter.UpdateModelElement(value, element);
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
      if (!BaseRunPropertiesConverter.CompareModelElement(element, value, diffs, objName))
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
      BaseRunPropertiesConverter.UpdateOpenXmlElement(element, value);
    else
    {
      element = BaseRunPropertiesConverter.CreateOpenXmlElement(value);
      openXmlElement.AddChild(element);
    }
  }
  #endregion
}
