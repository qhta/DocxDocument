namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesBase"/> class from/to OpenXml converter.
/// </summary>
public static class ParagraphMarkRunPropertiesBaseConverter
{
  #region Inserted Paragraph conversion.
  private static DMW.TrackChangeType? GetInserted(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Inserted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInserted(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Inserted>(), value, diffs, objName);
  }
  
  private static void SetInserted(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value)
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

  #region Deleted Paragraph conversion.
  private static DMW.TrackChangeType? GetDeleted(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Deleted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeleted(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Deleted>(), value, diffs, objName);
  }
  
  private static void SetDeleted(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value)
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

  #region Move Source Paragraph conversion.
  private static DMW.TrackChangeType? GetMoveFrom(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFrom>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFrom(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFrom>(), value, diffs, objName);
  }
  
  private static void SetMoveFrom(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFrom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.MoveFrom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Move Destination Paragraph conversion.
  private static DMW.TrackChangeType? GetMoveTo(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveTo>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveTo(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveTo>(), value, diffs, objName);
  }
  
  private static void SetMoveTo(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.MoveTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Conflict Insertion conversion.
  private static DMW.TrackChangeType2? GetConflictInsertion(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.ConflictInsertion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictInsertion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictInsertion>(), value, diffs, objName);
  }
  
  private static void SetConflictInsertion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType2? value)
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

  #region Conflict Deletion conversion.
  private static DMW.TrackChangeType2? GetConflictDeletion(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.ConflictDeletion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictDeletion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictDeletion>(), value, diffs, objName);
  }
  
  private static void SetConflictDeletion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType2? value)
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

  #region OfficeMath conversion.
  private static Boolean? GetOfficeMath(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.OfficeMath>());
  }
  
  private static bool CmpOfficeMath(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.OfficeMath>(), value, diffs, objName);
  }
  
  private static void SetOfficeMath(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.OfficeMath>(openXmlElement, value);
  }
  #endregion

  #region ParagraphMarkRunPropertiesBase model conversion.
  public static void UpdateModelElement(DMW.BaseParagraphMarkRunProperties value, DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      value.Inserted = GetInserted(openXmlElement);
      value.Deleted = GetDeleted(openXmlElement);
      value.MoveFrom = GetMoveFrom(openXmlElement);
      value.MoveTo = GetMoveTo(openXmlElement);
      value.ConflictInsertion = GetConflictInsertion(openXmlElement);
      value.ConflictDeletion = GetConflictDeletion(openXmlElement);
      ExtBaseRunPropertiesConverter.UpdateModelElement(value, openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
    }
  }
  
  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.BaseParagraphMarkRunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpInserted(openXmlElement, value.Inserted, diffs, objName))
        ok = false;
      if (!CmpDeleted(openXmlElement, value.Deleted, diffs, objName))
        ok = false;
      if (!CmpMoveFrom(openXmlElement, value.MoveFrom, diffs, objName))
        ok = false;
      if (!CmpMoveTo(openXmlElement, value.MoveTo, diffs, objName))
        ok = false;
      if (!CmpConflictInsertion(openXmlElement, value.ConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpConflictDeletion(openXmlElement, value.ConflictDeletion, diffs, objName))
        ok = false;
      if (!ExtBaseRunPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpOfficeMath(openXmlElement, value.OfficeMath, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
 
  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.BaseParagraphMarkRunProperties value)
  {
    SetInserted(openXmlElement, value.Inserted);
    SetDeleted(openXmlElement, value.Deleted);
    SetMoveFrom(openXmlElement, value.MoveFrom);
    SetMoveTo(openXmlElement, value.MoveTo);
    SetConflictInsertion(openXmlElement, value.ConflictInsertion);
    SetConflictDeletion(openXmlElement, value.ConflictDeletion);
    ExtBaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetOfficeMath(openXmlElement, value.OfficeMath);
  }
  #endregion
}
