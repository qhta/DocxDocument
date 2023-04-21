namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageGroups Class.
/// </summary>
public static class BackstageGroupsConverter
{
  private static DM.TaskFormGroup? GetTaskFormGroup(DXO10CUI.BackstageGroups openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.TaskFormGroup>();
    if (element != null)
      return DMX.TaskFormGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskFormGroup(DXO10CUI.BackstageGroups openXmlElement, DM.TaskFormGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskFormGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.TaskFormGroup>(), value, diffs, objName);
  }
  
  private static void SetTaskFormGroup(DXO10CUI.BackstageGroups openXmlElement, DM.TaskFormGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.TaskFormGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskFormGroupConverter.CreateOpenXmlElement<DXO10CUI.TaskFormGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageGroup? GetBackstageGroup(DXO10CUI.BackstageGroups openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageGroup>();
    if (element != null)
      return DMX.BackstageGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageGroup(DXO10CUI.BackstageGroups openXmlElement, DM.BackstageGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageGroup>(), value, diffs, objName);
  }
  
  private static void SetBackstageGroup(DXO10CUI.BackstageGroups openXmlElement, DM.BackstageGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageGroupConverter.CreateOpenXmlElement<DXO10CUI.BackstageGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.TaskGroup? GetTaskGroup(DXO10CUI.BackstageGroups openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.TaskGroup>();
    if (element != null)
      return DMX.TaskGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskGroup(DXO10CUI.BackstageGroups openXmlElement, DM.TaskGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.TaskGroup>(), value, diffs, objName);
  }
  
  private static void SetTaskGroup(DXO10CUI.BackstageGroups openXmlElement, DM.TaskGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.TaskGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskGroupConverter.CreateOpenXmlElement<DXO10CUI.TaskGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.BackstageGroups? CreateModelElement(DXO10CUI.BackstageGroups? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10CUI.BackstageGroups? openXmlElement, DM.BackstageGroups? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTaskFormGroup(openXmlElement, value.TaskFormGroup, diffs, objName))
        ok = false;
      if (!CmpBackstageGroup(openXmlElement, value.BackstageGroup, diffs, objName))
        ok = false;
      if (!CmpTaskGroup(openXmlElement, value.TaskGroup, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageGroups value)
    where OpenXmlElementType: DXO10CUI.BackstageGroups, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.BackstageGroups openXmlElement, DM.BackstageGroups value)
  {
    SetTaskFormGroup(openXmlElement, value?.TaskFormGroup);
    SetBackstageGroup(openXmlElement, value?.BackstageGroup);
    SetTaskGroup(openXmlElement, value?.TaskGroup);
  }
}
