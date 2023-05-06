namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.RunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class RunPropertiesConverter
{
  #region RunPropertiesChange conversion.
  public static DMW.RunPropertiesChange? GetRunPropertiesChange(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesChange>();
    if (element != null)
      return DMXW.RunPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpRunPropertiesChange(DX.OpenXmlCompositeElement openXmlElement, DMW.RunPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunPropertiesChange>(), value, diffs, objName);
  }

  public static void SetRunPropertiesChange(DX.OpenXmlCompositeElement openXmlElement, DMW.RunPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesChangeConverter.CreateOpenXmlElement<DXW.RunPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region RunProperties model conversion.
  public static DMW.RunProperties? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunProperties();
      UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }

  public static void UpdateModelElement(DMW.RunProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    ExtBaseRunPropertiesConverter.UpdateModelElement(model, openXmlElement);
    model.RunPropertiesChange = GetRunPropertiesChange(openXmlElement);
  }

  public static bool CompareModelElement(DXW.RunProperties? openXmlElement, DMW.RunProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ExtBaseRunPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!CmpRunPropertiesChange(openXmlElement, model.RunPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.RunProperties CreateOpenXmlElement(DMW.RunProperties model)
  {
    var openXmlElement = new DXW.RunProperties();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.RunProperties openXmlElement, DMW.RunProperties model)
  {
    ExtBaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetRunPropertiesChange(openXmlElement, model.RunPropertiesChange);
  }
  #endregion
}
