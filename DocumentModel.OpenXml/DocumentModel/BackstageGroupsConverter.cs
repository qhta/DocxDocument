namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageGroups Class.
/// </summary>
public static class BackstageGroupsConverter
{
  private static DM.TaskFormGroup? GetTaskFormGroup(DXO2010CustUI.BackstageGroups openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.TaskFormGroup>();
    if (itemElement != null)
      return DMX.TaskFormGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskFormGroup(DXO2010CustUI.BackstageGroups openXmlElement, DM.TaskFormGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.TaskFormGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskFormGroupConverter.CreateOpenXmlElement<DXO2010CustUI.TaskFormGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageGroup? GetBackstageGroup(DXO2010CustUI.BackstageGroups openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroup>();
    if (itemElement != null)
      return DMX.BackstageGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageGroup(DXO2010CustUI.BackstageGroups openXmlElement, DM.BackstageGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageGroupConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.TaskGroup? GetTaskGroup(DXO2010CustUI.BackstageGroups openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.TaskGroup>();
    if (itemElement != null)
      return DMX.TaskGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskGroup(DXO2010CustUI.BackstageGroups openXmlElement, DM.TaskGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.TaskGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskGroupConverter.CreateOpenXmlElement<DXO2010CustUI.TaskGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.BackstageGroups? CreateModelElement(DXO2010CustUI.BackstageGroups? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.BackstageGroups();
      value.TaskFormGroup = GetTaskFormGroup(openXmlElement);
      value.BackstageGroup = GetBackstageGroup(openXmlElement);
      value.TaskGroup = GetTaskGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageGroups? value)
    where OpenXmlElementType: DXO2010CustUI.BackstageGroups, new()
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
