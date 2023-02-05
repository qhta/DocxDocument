namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskFormGroup Class.
/// </summary>
public static class TaskFormGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.QualifiedId?.Value == value) return true;
    diffs?.Add(objName, "QualifiedId", openXmlElement?.QualifiedId?.Value, value);
    return false;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.TaskFormGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO2010CustUI.TaskFormGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// helperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetHelperText(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.HelperText?.Value;
  }
  
  private static bool CmpHelperText(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HelperText?.Value == value) return true;
    diffs?.Add(objName, "HelperText", openXmlElement?.HelperText?.Value, value);
    return false;
  }
  
  private static void SetHelperText(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.HelperText = new StringValue { Value = value };
    else
      openXmlElement.HelperText = null;
  }
  
  /// <summary>
  /// getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetHelperText(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.GetHelperText?.Value;
  }
  
  private static bool CmpGetHelperText(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetHelperText?.Value == value) return true;
    diffs?.Add(objName, "GetHelperText", openXmlElement?.GetHelperText?.Value, value);
    return false;
  }
  
  private static void SetGetHelperText(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetHelperText = new StringValue { Value = value };
    else
      openXmlElement.GetHelperText = null;
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXO2010CustUI.TaskFormGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXO2010CustUI.TaskFormGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXO2010CustUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowLabel?.Value == value) return true;
    diffs?.Add(objName, "GetShowLabel", openXmlElement?.GetShowLabel?.Value, value);
    return false;
  }
  
  private static void SetGetShowLabel(DXO2010CustUI.TaskFormGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// allowedTaskSizes, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.TaskSizesKind? GetAllowedTaskSizes(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DM.TaskSizesKind>(openXmlElement?.AllowedTaskSizes?.Value);
  }
  
  private static bool CmpAllowedTaskSizes(DXO2010CustUI.TaskFormGroup openXmlElement, DM.TaskSizesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DM.TaskSizesKind>(openXmlElement?.AllowedTaskSizes?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAllowedTaskSizes(DXO2010CustUI.TaskFormGroup openXmlElement, DM.TaskSizesKind? value)
  {
    openXmlElement.AllowedTaskSizes = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DM.TaskSizesKind>(value);
  }
  
  private static Collection<DM.TaskFormGroupCategory> GetTaskFormGroupCategories(DXO2010CustUI.TaskFormGroup openXmlElement)
  {
    var collection = new Collection<DM.TaskFormGroupCategory>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.TaskFormGroupCategory>())
    {
      var newItem = DMX.TaskFormGroupCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpTaskFormGroupCategories(DXO2010CustUI.TaskFormGroup openXmlElement, Collection<DM.TaskFormGroupCategory>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2010CustUI.TaskFormGroupCategory>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMX.TaskFormGroupCategoryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTaskFormGroupCategories(DXO2010CustUI.TaskFormGroup openXmlElement, Collection<DM.TaskFormGroupCategory>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.TaskFormGroupCategory>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TaskFormGroupCategoryConverter.CreateOpenXmlElement<DXO2010CustUI.TaskFormGroupCategory>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.TaskFormGroup? CreateModelElement(DXO2010CustUI.TaskFormGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskFormGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.HelperText = GetHelperText(openXmlElement);
      value.GetHelperText = GetGetHelperText(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.AllowedTaskSizes = GetAllowedTaskSizes(openXmlElement);
      value.TaskFormGroupCategories = GetTaskFormGroupCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.TaskFormGroup? openXmlElement, DM.TaskFormGroup? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpHelperText(openXmlElement, value.HelperText, diffs, objName))
        ok = false;
      if (!CmpGetHelperText(openXmlElement, value.GetHelperText, diffs, objName))
        ok = false;
      if (!CmpShowLabel(openXmlElement, value.ShowLabel, diffs, objName))
        ok = false;
      if (!CmpGetShowLabel(openXmlElement, value.GetShowLabel, diffs, objName))
        ok = false;
      if (!CmpAllowedTaskSizes(openXmlElement, value.AllowedTaskSizes, diffs, objName))
        ok = false;
      if (!CmpTaskFormGroupCategories(openXmlElement, value.TaskFormGroupCategories, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskFormGroup? value)
    where OpenXmlElementType: DXO2010CustUI.TaskFormGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetHelperText(openXmlElement, value?.HelperText);
      SetGetHelperText(openXmlElement, value?.GetHelperText);
      SetShowLabel(openXmlElement, value?.ShowLabel);
      SetGetShowLabel(openXmlElement, value?.GetShowLabel);
      SetAllowedTaskSizes(openXmlElement, value?.AllowedTaskSizes);
      SetTaskFormGroupCategories(openXmlElement, value?.TaskFormGroupCategories);
      return openXmlElement;
    }
    return default;
  }
}
