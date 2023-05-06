namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.MatrixColumn"/> class from/to OpenXml converter.
/// </summary>
public static class MatrixColumnConverter
{
  #region Matrix Column Properties. conversion.
  private static DMM.MatrixColumnProperties? GetMatrixColumnProperties(DXM.MatrixColumn openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.MatrixColumnProperties>();
    if (element != null)
      return DMXM.MatrixColumnPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrixColumnProperties(DXM.MatrixColumn openXmlElement, DMM.MatrixColumnProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.MatrixColumnPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.MatrixColumnProperties>(), value, diffs, objName);
  }
  
  private static void SetMatrixColumnProperties(DXM.MatrixColumn openXmlElement, DMM.MatrixColumnProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.MatrixColumnProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.MatrixColumnPropertiesConverter.CreateOpenXmlElement<DXM.MatrixColumnProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region MatrixColumn model conversion.
  public static DMM.MatrixColumn? CreateModelElement(DXM.MatrixColumn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.MatrixColumn();
      model.MatrixColumnProperties = GetMatrixColumnProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.MatrixColumn? openXmlElement, DMM.MatrixColumn? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpMatrixColumnProperties(openXmlElement, model.MatrixColumnProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.MatrixColumn model)
    where OpenXmlElementType: DXM.MatrixColumn, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.MatrixColumn openXmlElement, DMM.MatrixColumn model)
  {
    SetMatrixColumnProperties(openXmlElement, model?.MatrixColumnProperties);
  }
  #endregion
}
