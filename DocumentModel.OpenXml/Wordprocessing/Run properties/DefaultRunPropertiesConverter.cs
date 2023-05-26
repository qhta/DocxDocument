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
      var model = new DMW.DefaultRunProperties();
      BaseRunPropertiesConverter.UpdateModelElement(model, element);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.RunPropertiesDefault? openXmlElement, DMW.DefaultRunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null && model != null)
    {
      var ok = true;
      if (!BaseRunPropertiesConverter.CompareModelElement(element, model, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.RunPropertiesDefault CreateOpenXmlElement(DMW.DefaultRunProperties model)
  {
    var openXmlElement = new DXW.RunPropertiesDefault();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.RunPropertiesDefault openXmlElement, DMW.DefaultRunProperties model)
  {
    var element = openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null)
      BaseRunPropertiesConverter.UpdateOpenXmlElement(element, model);
    else
    {
      element = BaseRunPropertiesConverter.CreateOpenXmlElement(model);
      openXmlElement.AppendChild(element);
    }
  }
  #endregion
}
