namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskFormGroup Class.
/// </summary>
public static class TaskFormGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO10CUI.TaskFormGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO10CUI.TaskFormGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// helperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetHelperText(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.HelperText);
  }
  
  private static bool CmpHelperText(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.HelperText, value, diffs, objName, "HelperText");
  }
  
  private static void SetHelperText(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.HelperText = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetHelperText(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetHelperText);
  }
  
  private static bool CmpGetHelperText(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetHelperText, value, diffs, objName, "GetHelperText");
  }
  
  private static void SetGetHelperText(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.GetHelperText = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXO10CUI.TaskFormGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXO10CUI.TaskFormGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowLabel);
  }
  
  private static bool CmpGetShowLabel(DXO10CUI.TaskFormGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowLabel, value, diffs, objName, "GetShowLabel");
  }
  
  private static void SetGetShowLabel(DXO10CUI.TaskFormGroup openXmlElement, String? value)
  {
    openXmlElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// allowedTaskSizes, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.TaskSizesKind? GetAllowedTaskSizes(DXO10CUI.TaskFormGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DM.TaskSizesKind>(openXmlElement?.AllowedTaskSizes?.Value);
  }
  
  private static bool CmpAllowedTaskSizes(DXO10CUI.TaskFormGroup openXmlElement, DM.TaskSizesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DM.TaskSizesKind>(openXmlElement?.AllowedTaskSizes?.Value, value, diffs, objName);
  }
  
  private static void SetAllowedTaskSizes(DXO10CUI.TaskFormGroup openXmlElement, DM.TaskSizesKind? value)
  {
    openXmlElement.AllowedTaskSizes = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DM.TaskSizesKind>(value);
  }
  
  private static Collection<DM.TaskFormGroupCategory>? GetTaskFormGroupCategories(DXO10CUI.TaskFormGroup openXmlElement)
  {
    var collection = new Collection<DM.TaskFormGroupCategory>();
    foreach (var item in openXmlElement.Elements<DXO10CUI.TaskFormGroupCategory>())
    {
      var newItem = DMX.TaskFormGroupCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTaskFormGroupCategories(DXO10CUI.TaskFormGroup openXmlElement, Collection<DM.TaskFormGroupCategory>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO10CUI.TaskFormGroupCategory>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTaskFormGroupCategories(DXO10CUI.TaskFormGroup openXmlElement, Collection<DM.TaskFormGroupCategory>? value)
  {
    openXmlElement.RemoveAllChildren<DXO10CUI.TaskFormGroupCategory>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TaskFormGroupCategoryConverter.CreateOpenXmlElement<DXO10CUI.TaskFormGroupCategory>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.TaskFormGroup? CreateModelElement(DXO10CUI.TaskFormGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskFormGroup();
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
  
  public static bool CompareModelElement(DXO10CUI.TaskFormGroup? openXmlElement, DM.TaskFormGroup? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskFormGroup value)
    where OpenXmlElementType: DXO10CUI.TaskFormGroup, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.TaskFormGroup openXmlElement, DM.TaskFormGroup value)
  {
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
  }
}
