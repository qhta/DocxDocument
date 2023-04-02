namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run Properties.
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
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region RunProperties model conversion.
  public static DMW.RunProperties? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunProperties();
      UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }

  public static void UpdateModelElement(DMW.RunProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
    RunPropertiesBaseConverter.UpdateModelElement(value, openXmlElement);
    value.RunPropertiesChange = GetRunPropertiesChange(openXmlElement);
  }

  public static bool CompareModelElement(DXW.RunProperties? openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!RunPropertiesBaseConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpRunPropertiesChange(openXmlElement, value.RunPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.RunProperties CreateOpenXmlElement(DMW.RunProperties value)
  {
    var openXmlElement = new DXW.RunProperties();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.RunProperties openXmlElement, DMW.RunProperties value)
  {
    RunPropertiesBaseConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetRunPropertiesChange(openXmlElement, value.RunPropertiesChange);
  }
  #endregion

}
