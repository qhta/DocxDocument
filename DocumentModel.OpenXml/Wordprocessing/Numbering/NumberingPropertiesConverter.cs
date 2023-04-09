namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.NumberingProperties"/> class from/to OpenXml converter.
/// </summary>
public static class NumberingPropertiesConverter
{
  #region NumberingLevelReference conversion.
  private static Int32? GetNumberingLevelReference(DXW.NumberingProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingLevelReference>()?.Val);
  }
  
  private static bool CmpNumberingLevelReference(DXW.NumberingProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingLevelReference>()?.Val, value, diffs, objName, "NumberingLevelReference");
  }
  
  private static void SetNumberingLevelReference(DXW.NumberingProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.NumberingLevelReference,System.Int32>(openXmlElement, value);
  }
  #endregion

  #region NumberingId conversion.
  private static Int32? GetNumberingId(DXW.NumberingProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingId>()?.Val);
  }
  
  private static bool CmpNumberingId(DXW.NumberingProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingId>()?.Val, value, diffs, objName, "NumberingId");
  }
  
  private static void SetNumberingId(DXW.NumberingProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.NumberingId,System.Int32>(openXmlElement, value);
  }
  #endregion

  #region NumberingChange conversion.
  private static DMW.NumberingChange? GetNumberingChange(DXW.NumberingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingChange>();
    if (element != null)
      return DMXW.NumberingChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingChange(DXW.NumberingProperties openXmlElement, DMW.NumberingChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingChange>(), value, diffs, objName);
  }
  
  private static void SetNumberingChange(DXW.NumberingProperties openXmlElement, DMW.NumberingChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingChangeConverter.CreateOpenXmlElement<DXW.NumberingChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Inserted Numbering Properties.
  private static DMW.TrackChangeType? GetInserted(DXW.NumberingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Inserted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInserted(DXW.NumberingProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Inserted>(), value, diffs, objName);
  }
  
  private static void SetInserted(DXW.NumberingProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Inserted>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.Inserted>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region NumberingProperties model conversion.
  public static DMW.NumberingProperties? CreateModelElement(DXW.NumberingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NumberingProperties();
      model.NumberingLevelReference = GetNumberingLevelReference(openXmlElement);
      model.NumberingId = GetNumberingId(openXmlElement);
      model.NumberingChange = GetNumberingChange(openXmlElement);
      model.Inserted = GetInserted(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NumberingProperties? openXmlElement, DMW.NumberingProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpNumberingLevelReference(openXmlElement, model.NumberingLevelReference, diffs, objName))
        ok = false;
      if (!CmpNumberingId(openXmlElement, model.NumberingId, diffs, objName))
        ok = false;
      if (!CmpNumberingChange(openXmlElement, model.NumberingChange, diffs, objName))
        ok = false;
      if (!CmpInserted(openXmlElement, model.Inserted, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingProperties model)
    where OpenXmlElementType: DXW.NumberingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.NumberingProperties openXmlElement, DMW.NumberingProperties model)
  {
    SetNumberingLevelReference(openXmlElement, model?.NumberingLevelReference);
    SetNumberingId(openXmlElement, model?.NumberingId);
    SetNumberingChange(openXmlElement, model?.NumberingChange);
    SetInserted(openXmlElement, model?.Inserted);
  }
  #endregion
}
