namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageGroups Class.
/// </summary>
public static class BackstageGroupsConverter
{
  public static DocumentModel.TaskFormGroup? GetTaskFormGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskFormGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTaskFormGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement, DocumentModel.TaskFormGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.TaskFormGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.BackstageGroup? GetBackstageGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement, DocumentModel.BackstageGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.BackstageGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.TaskGroup? GetTaskGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTaskGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement, DocumentModel.TaskGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.TaskGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.BackstageGroups? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageGroups();
      value.TaskFormGroup = GetTaskFormGroup(openXmlElement);
      value.BackstageGroup = GetBackstageGroup(openXmlElement);
      value.TaskGroup = GetTaskGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.BackstageGroups? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups, new()
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
