namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the SimpleGroups Class.
/// </summary>
public static class SimpleGroupsConverter
{
  private static DocumentModel.BackstageGroup? GetBackstageGroup(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageGroup(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups openXmlElement, DocumentModel.BackstageGroup? value)
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
  
  private static DocumentModel.TaskGroup? GetTaskGroup(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskGroup(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups openXmlElement, DocumentModel.TaskGroup? value)
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
  
  public static DocumentModel.SimpleGroups? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.SimpleGroups();
      value.BackstageGroup = GetBackstageGroup(openXmlElement);
      value.TaskGroup = GetTaskGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.SimpleGroups? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups, new()
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
