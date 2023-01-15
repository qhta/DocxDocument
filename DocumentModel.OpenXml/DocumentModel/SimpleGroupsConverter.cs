namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the SimpleGroups Class.
/// </summary>
public static class SimpleGroupsConverter
{
  public static BackstageGroup? GetBackstageGroup(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
    if (itemElement != null)
      return BackstageGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageGroup(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups? openXmlElement, BackstageGroup? value)
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

  public static TaskGroup? GetTaskGroup(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
    if (itemElement != null)
      return TaskGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskGroup(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups? openXmlElement, TaskGroup? value)
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

  public static SimpleGroups? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new SimpleGroups();
      value.BackstageGroup = GetBackstageGroup(openXmlElement);
      value.TaskGroup = GetTaskGroup(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(SimpleGroups? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBackstageGroup(openXmlElement, value?.BackstageGroup);
      SetTaskGroup(openXmlElement, value?.TaskGroup);
      return openXmlElement;
    }
    return default;
  }
}