namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTableCellProperties"/> class from/to OpenXml converter.
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
    var element = openXmlElement?.GetFirstChild<DXO2010W.ConflictInsertion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictInsertion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictInsertion>(), value, diffs, objName);
  }
  
  private static void SetConflictInsertion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.ConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region ConflictDeletion conversion.
  private static DMW.TrackChangeType2? GetConflictDeletion(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.ConflictDeletion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictDeletion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictDeletion>(), value, diffs, objName);
  }
  
  private static void SetConflictDeletion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.ConflictDeletion>(value);
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
      var value = new DMW.TableRowProperties();
      BaseTableRowPropertiesConverter.UpdateModelElement(value, openXmlElement);
      value.Inserted = GetInserted(openXmlElement);
      value.Deleted = GetDeleted(openXmlElement);
      value.TableRowPropertiesChange = GetTableRowPropertiesChange(openXmlElement);
      value.ConflictInsertion = GetConflictInsertion(openXmlElement);
      value.ConflictDeletion = GetConflictDeletion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableRowProperties? openXmlElement, DMW.TableRowProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!BaseTableRowPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpInserted(openXmlElement, value.Inserted, diffs, objName))
        ok = false;
      if (!CmpDeleted(openXmlElement, value.Deleted, diffs, objName))
        ok = false;
      if (!CmpTableRowPropertiesChange(openXmlElement, value.TableRowPropertiesChange, diffs, objName))
        ok = false;
      if (!CmpConflictInsertion(openXmlElement, value.ConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpConflictDeletion(openXmlElement, value.ConflictDeletion, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowProperties value)
    where OpenXmlElementType: DXW.TableRowProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableRowProperties openXmlElement, DMW.TableRowProperties value)
  {
    BaseTableRowPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetInserted(openXmlElement, value?.Inserted);
    SetDeleted(openXmlElement, value?.Deleted);
    SetTableRowPropertiesChange(openXmlElement, value?.TableRowPropertiesChange);
    SetConflictInsertion(openXmlElement, value?.ConflictInsertion);
    SetConflictDeletion(openXmlElement, value?.ConflictDeletion);
  }
  #endregion
}
