namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskGroup Class.
/// </summary>
public static class TaskGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DXO2010CustUI.TaskGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// helperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetHelperText(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.HelperText?.Value;
  }
  
  private static void SetHelperText(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.HelperText = new StringValue { Value = value };
    else
      openXmlElement.HelperText = null;
  }
  
  /// <summary>
  /// getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetHelperText(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.GetHelperText?.Value;
  }
  
  private static void SetGetHelperText(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetHelperText = new StringValue { Value = value };
    else
      openXmlElement.GetHelperText = null;
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static void SetShowLabel(DXO2010CustUI.TaskGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static void SetGetShowLabel(DXO2010CustUI.TaskGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// allowedTaskSizes, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.TaskSizesKind? GetAllowedTaskSizes(DXO2010CustUI.TaskGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DM.TaskSizesKind>(openXmlElement?.AllowedTaskSizes?.Value);
  }
  
  private static void SetAllowedTaskSizes(DXO2010CustUI.TaskGroup openXmlElement, DM.TaskSizesKind? value)
  {
    openXmlElement.AllowedTaskSizes = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DM.TaskSizesKind>(value);
  }
  
  private static Collection<DM.TaskGroupCategory> GetTaskGroupCategories(DXO2010CustUI.TaskGroup openXmlElement)
  {
    var collection = new Collection<DM.TaskGroupCategory>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.TaskGroupCategory>())
    {
      var newItem = DMX.TaskGroupCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetTaskGroupCategories(DXO2010CustUI.TaskGroup openXmlElement, Collection<DM.TaskGroupCategory>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.TaskGroupCategory>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TaskGroupCategoryConverter.CreateOpenXmlElement<DXO2010CustUI.TaskGroupCategory>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.TaskGroup? CreateModelElement(DXO2010CustUI.TaskGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.HelperText = GetHelperText(openXmlElement);
      value.GetHelperText = GetGetHelperText(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.AllowedTaskSizes = GetAllowedTaskSizes(openXmlElement);
      value.TaskGroupCategories = GetTaskGroupCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskGroup? value)
    where OpenXmlElementType: DXO2010CustUI.TaskGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
      SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetHelperText(openXmlElement, value?.HelperText);
      SetGetHelperText(openXmlElement, value?.GetHelperText);
      SetShowLabel(openXmlElement, value?.ShowLabel);
      SetGetShowLabel(openXmlElement, value?.GetShowLabel);
      SetAllowedTaskSizes(openXmlElement, value?.AllowedTaskSizes);
      SetTaskGroupCategories(openXmlElement, value?.TaskGroupCategories);
      return openXmlElement;
    }
    return default;
  }
}
