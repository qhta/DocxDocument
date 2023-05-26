namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.SimpleFieldRuby"/> class from/to OpenXml converter.
/// </summary>
public static class SimpleFieldRubyConverter
{

  #region Instruction conversion.
  private static String? GetInstruction(DXW.SimpleFieldRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Instruction);
  }

  private static bool CmpInstruction(DXW.SimpleFieldRuby openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Instruction, value, diffs, objName, "Instruction");
  }

  private static void SetInstruction(DXW.SimpleFieldRuby openXmlElement, String? value)
  {
    openXmlElement.Instruction = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region FieldLock conversion.
  private static Boolean? GetFieldLock(DXW.SimpleFieldRuby openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FieldLock);
  }

  private static bool CmpFieldLock(DXW.SimpleFieldRuby openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FieldLock, value, diffs, objName, "FieldLock");
  }

  private static void SetFieldLock(DXW.SimpleFieldRuby openXmlElement, Boolean? value)
  {
    openXmlElement.FieldLock = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region Dirty conversion.
  private static Boolean? GetDirty(DXW.SimpleFieldRuby openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Dirty);
  }

  private static bool CmpDirty(DXW.SimpleFieldRuby openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Dirty, value, diffs, objName, "Dirty");
  }

  private static void SetDirty(DXW.SimpleFieldRuby openXmlElement, Boolean? value)
  {
    openXmlElement.Dirty = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region FieldData conversion.
  private static String? GetFieldData(DXW.SimpleFieldRuby openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.FieldData>()?.Text;
  }

  private static bool CmpFieldData(DXW.SimpleFieldRuby openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return openXmlElement?.GetFirstChild<DXW.FieldData>()?.Text == value;
  }

  private static void SetFieldData(DXW.SimpleFieldRuby openXmlElement, String? value)
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

  #region SimpleFieldRuby model conversion.
  public static DMW.SimpleFieldRuby? CreateModelElement(DXW.SimpleFieldRuby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SimpleFieldRuby();
      model.Instruction = GetInstruction(openXmlElement);
      model.FieldLock = GetFieldLock(openXmlElement);
      model.Dirty = GetDirty(openXmlElement);
      model.FieldData = GetFieldData(openXmlElement);
      ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
        openXmlElement, model,
        RubyContentConverter.CreateRubyContentModelElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.SimpleFieldRuby? openXmlElement, DMW.SimpleFieldRuby? model, DiffList? diffs = null, string? objName = null, string? propName = null)
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
        RubyContentConverter.CompareRubyContentElement, diffs, objName, propName))
        ok = false; ;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.SimpleFieldRuby CreateOpenXmlElement(DMW.SimpleFieldRuby model)
  {
    var openXmlElement = new DXW.SimpleFieldRuby();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.SimpleFieldRuby openXmlElement, DMW.SimpleFieldRuby model)
  {
    SetInstruction(openXmlElement, model.Instruction);
    SetFieldLock(openXmlElement, model.FieldLock);
    SetDirty(openXmlElement, model.Dirty);
    SetFieldData(openXmlElement, model.FieldData);
    return ElementCollectionConverter<DM.IModelElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      RubyContentConverter.CompareRubyContentElement,
      RubyContentConverter.UpdateRubyContentOpenXmlElement,
      RubyContentConverter.CreateRubyContentOpenXmlElement);
  }
  #endregion
}
