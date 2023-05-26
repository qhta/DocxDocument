namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.SimpleField"/> class from/to OpenXml converter.
/// </summary>
public static class SimpleFieldConverter
{
  #region Instruction conversion.
  private static String? GetInstruction(DXW.SimpleField openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Instruction);
  }
  
  private static bool CmpInstruction(DXW.SimpleField openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Instruction, value, diffs, objName, "Instruction");
  }
  
  private static void SetInstruction(DXW.SimpleField openXmlElement, String? value)
  {
    openXmlElement.Instruction = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region FieldLock conversion.
  private static Boolean? GetFieldLock(DXW.SimpleField openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FieldLock);
  }
  
  private static bool CmpFieldLock(DXW.SimpleField openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FieldLock, value, diffs, objName, "FieldLock");
  }
  
  private static void SetFieldLock(DXW.SimpleField openXmlElement, Boolean? value)
  {
    openXmlElement.FieldLock = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region Dirty conversion.
  private static Boolean? GetDirty(DXW.SimpleField openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Dirty);
  }
  
  private static bool CmpDirty(DXW.SimpleField openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Dirty, value, diffs, objName, "Dirty");
  }
  
  private static void SetDirty(DXW.SimpleField openXmlElement, Boolean? value)
  {
    openXmlElement.Dirty = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region FieldData conversion.
  private static String? GetFieldData(DXW.SimpleField openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.FieldData>()?.Text;
  }
  
  private static bool CmpFieldData(DXW.SimpleField openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXW.FieldData>()?.Text == value;
  }
  
  private static void SetFieldData(DXW.SimpleField openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FieldData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FieldData { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region SimpleField model conversion.
  public static DMW.SimpleField? CreateModelElement(DXW.SimpleField? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SimpleField();
      model.Instruction = GetInstruction(openXmlElement);
      model.FieldLock = GetFieldLock(openXmlElement);
      model.Dirty = GetDirty(openXmlElement);
      model.FieldData = GetFieldData(openXmlElement);
      ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
        openXmlElement.Where(item=>item is not DXW.ParagraphProperties), model,
        ParagraphContentConverter.CreateParagraphContent);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SimpleField? openXmlElement, DMW.SimpleField? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpInstruction(openXmlElement, model.Instruction, diffs, objName, propName))
        ok = false;
      if (!CmpFieldLock(openXmlElement, model.FieldLock, diffs, objName, propName))
        ok = false;
      if (!CmpDirty(openXmlElement, model.Dirty, diffs, objName, propName))
        ok = false;
      if (!CmpFieldData(openXmlElement, model.FieldData, diffs, objName, propName))
        ok = false;
      if (!ElementCollectionConverter<DM.IModelElement>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        ParagraphContentConverter.CompareParagraphContent, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.SimpleField CreateOpenXmlElement(DMW.SimpleField model)
  {
    var openXmlElement = new DXW.SimpleField();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.SimpleField openXmlElement, DMW.SimpleField model)
  {
    SetInstruction(openXmlElement, model.Instruction);
    SetFieldLock(openXmlElement, model.FieldLock);
    SetDirty(openXmlElement, model.Dirty);
    SetFieldData(openXmlElement, model.FieldData);
    return ElementCollectionConverter<DM.IModelElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      ParagraphContentConverter.CompareParagraphContent,
      ParagraphContentConverter.UpdateOpenXmlParagraphContent,
      ParagraphContentConverter.CreateOpenXmlParagraphContent);
  }
  #endregion
}
