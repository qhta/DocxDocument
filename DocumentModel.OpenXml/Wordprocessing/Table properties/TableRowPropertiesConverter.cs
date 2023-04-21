namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableRowProperties"/> class from/to OpenXml converter.
/// </summary>
public static class TableRowPropertiesConverter
{
  #region Inserted conversion.
  private static DMW.TrackChangeType? GetInserted(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Inserted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInserted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Inserted>(), value, diffs, objName);
  }
  
  private static void SetInserted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value)
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

  #region Deleted conversion.
  private static DMW.TrackChangeType? GetDeleted(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Deleted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeleted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Deleted>(), value, diffs, objName);
  }
  
  private static void SetDeleted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Deleted>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.Deleted>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableRowPropertiesChange conversion.
  private static DMW.TableRowPropertiesChange? GetTableRowPropertiesChange(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableRowPropertiesChange>();
    if (element != null)
      return DMXW.TableRowPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableRowPropertiesChange(DXW.TableRowProperties openXmlElement, DMW.TableRowPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowPropertiesChange>(), value, diffs, objName);
  }
  
  private static void SetTableRowPropertiesChange(DXW.TableRowProperties openXmlElement, DMW.TableRowPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableRowPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableRowPropertiesChangeConverter.CreateOpenXmlElement<DXW.TableRowPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region ConflictInsertion conversion.
  private static DMW.TrackChangeType2? GetConflictInsertion(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.ConflictInsertion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictInsertion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.ConflictInsertion>(), value, diffs, objName);
  }
  
  private static void SetConflictInsertion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.ConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO10W.ConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region ConflictDeletion conversion.
  private static DMW.TrackChangeType2? GetConflictDeletion(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.ConflictDeletion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictDeletion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.ConflictDeletion>(), value, diffs, objName);
  }
  
  private static void SetConflictDeletion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.ConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO10W.ConflictDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableRowProperties model conversion.
  public static DMW.TableRowProperties? CreateModelElement(DXW.TableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableRowProperties();
      BaseTableRowPropertiesConverter.UpdateModelElement(model, openXmlElement);
      model.Inserted = GetInserted(openXmlElement);
      model.Deleted = GetDeleted(openXmlElement);
      model.TableRowPropertiesChange = GetTableRowPropertiesChange(openXmlElement);
      model.ConflictInsertion = GetConflictInsertion(openXmlElement);
      model.ConflictDeletion = GetConflictDeletion(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableRowProperties? openXmlElement, DMW.TableRowProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!BaseTableRowPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!CmpInserted(openXmlElement, model.Inserted, diffs, objName))
        ok = false;
      if (!CmpDeleted(openXmlElement, model.Deleted, diffs, objName))
        ok = false;
      if (!CmpTableRowPropertiesChange(openXmlElement, model.TableRowPropertiesChange, diffs, objName))
        ok = false;
      if (!CmpConflictInsertion(openXmlElement, model.ConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpConflictDeletion(openXmlElement, model.ConflictDeletion, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowProperties model)
    where OpenXmlElementType: DXW.TableRowProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableRowProperties openXmlElement, DMW.TableRowProperties model)
  {
    BaseTableRowPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetInserted(openXmlElement, model?.Inserted);
    SetDeleted(openXmlElement, model?.Deleted);
    SetTableRowPropertiesChange(openXmlElement, model?.TableRowPropertiesChange);
    SetConflictInsertion(openXmlElement, model?.ConflictInsertion);
    SetConflictDeletion(openXmlElement, model?.ConflictDeletion);
  }
  #endregion
}
