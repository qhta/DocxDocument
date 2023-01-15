namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the BackstageGroups Class.
/// </summary>
public static class BackstageGroupsConverter
{
  public static TaskFormGroup? GetTaskFormGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>();
    if (itemElement != null)
      return TaskFormGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskFormGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement, TaskFormGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskFormGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageGroup? GetBackstageGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
    if (itemElement != null)
      return BackstageGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement, BackstageGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TaskGroup? GetTaskGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
    if (itemElement != null)
      return TaskGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement, TaskGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageGroups? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new BackstageGroups();
      value.TaskFormGroup = GetTaskFormGroup(openXmlElement);
      value.BackstageGroup = GetBackstageGroup(openXmlElement);
      value.TaskGroup = GetTaskGroup(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(BackstageGroups? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTaskFormGroup(openXmlElement, value?.TaskFormGroup);
      SetBackstageGroup(openXmlElement, value?.BackstageGroup);
      SetTaskGroup(openXmlElement, value?.TaskGroup);
      return openXmlElement;
    }
    return default;
  }
}