namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskFormGroup Class.
/// </summary>
public static class TaskFormGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QualifiedId = new StringValue { Value = value };
      else
        openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// helperText, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetHelperText(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.HelperText?.Value;
  }
  
  public static void SetHelperText(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HelperText = new StringValue { Value = value };
      else
        openXmlElement.HelperText = null;
  }
  
  /// <summary>
  /// getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetHelperText(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.GetHelperText?.Value;
  }
  
  public static void SetGetHelperText(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetHelperText = new StringValue { Value = value };
      else
        openXmlElement.GetHelperText = null;
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  public static void SetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  public static void SetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowLabel = new StringValue { Value = value };
      else
        openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// allowedTaskSizes, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.TaskSizesKind? GetAllowedTaskSizes(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DocumentModel.TaskSizesKind>(openXmlElement?.AllowedTaskSizes?.Value);
  }
  
  public static void SetAllowedTaskSizes(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, DocumentModel.TaskSizesKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AllowedTaskSizes = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues, DocumentModel.TaskSizesKind>(value);
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.TaskFormGroupCategory>? GetTaskFormGroupCategories(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.TaskFormGroupCategory>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory>())
      {
        var newItem = DocumentModel.OpenXml.TaskFormGroupCategoryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTaskFormGroupCategories(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.TaskFormGroupCategory>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.TaskFormGroupCategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.TaskFormGroup? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskFormGroup? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
