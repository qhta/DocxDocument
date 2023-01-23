namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the SimpleGroups Class.
/// </summary>
public static class SimpleGroupsConverter
{
  private static DM.BackstageGroup? GetBackstageGroup(DXO2010CustUI.SimpleGroups openXmlElement)
  {
    return DMX.BackstageGroupConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroup>());
  }
  
  private static bool CmpBackstageGroup(DXO2010CustUI.SimpleGroups openXmlElement, DM.BackstageGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageGroupConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroup>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageGroup(DXO2010CustUI.SimpleGroups openXmlElement, DM.BackstageGroup? value)
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
  
  private static DM.TaskGroup? GetTaskGroup(DXO2010CustUI.SimpleGroups openXmlElement)
  {
    return DMX.TaskGroupConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.TaskGroup>());
  }
  
  private static bool CmpTaskGroup(DXO2010CustUI.SimpleGroups openXmlElement, DM.TaskGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskGroupConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.TaskGroup>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTaskGroup(DXO2010CustUI.SimpleGroups openXmlElement, DM.TaskGroup? value)
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
  
  public static DM.SimpleGroups? CreateModelElement(DXO2010CustUI.SimpleGroups? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.SimpleGroups();
      value.BackstageGroup = GetBackstageGroup(openXmlElement);
      value.TaskGroup = GetTaskGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.SimpleGroups? openXmlElement, DM.SimpleGroups? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBackstageGroup(openXmlElement, value.BackstageGroup, diffs, objName))
        ok = false;
      if (!CmpTaskGroup(openXmlElement, value.TaskGroup, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.SimpleGroups? value)
    where OpenXmlElementType: DXO2010CustUI.SimpleGroups, new()
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
