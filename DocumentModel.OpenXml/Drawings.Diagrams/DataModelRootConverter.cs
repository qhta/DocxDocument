namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
public static class DataModelRootConverter
{
  /// <summary>
  /// Point List.
  /// </summary>
  private static DMDrawsDgms.PointList? GetPointList(DXDrawDgms.DataModelRoot openXmlElement)
  {
    return DMXDrawsDgms.PointListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PointList>());
  }
  
  private static bool CmpPointList(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.PointList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PointListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PointList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPointList(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.PointList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.PointList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.PointListConverter.CreateOpenXmlElement<DXDrawDgms.PointList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  private static DMDrawsDgms.ConnectionList? GetConnectionList(DXDrawDgms.DataModelRoot openXmlElement)
  {
    return DMXDrawsDgms.ConnectionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ConnectionList>());
  }
  
  private static bool CmpConnectionList(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.ConnectionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ConnectionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ConnectionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConnectionList(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.ConnectionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ConnectionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ConnectionListConverter.CreateOpenXmlElement<DXDrawDgms.ConnectionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  private static DMDrawsDgms.Background? GetBackground(DXDrawDgms.DataModelRoot openXmlElement)
  {
    return DMXDrawsDgms.BackgroundConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Background>());
  }
  
  private static bool CmpBackground(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.Background? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.BackgroundConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Background>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackground(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.Background? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Background>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.BackgroundConverter.CreateOpenXmlElement<DXDrawDgms.Background>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  private static DMDrawsDgms.Whole? GetWhole(DXDrawDgms.DataModelRoot openXmlElement)
  {
    return DMXDrawsDgms.WholeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Whole>());
  }
  
  private static bool CmpWhole(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.Whole? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.WholeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Whole>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWhole(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.Whole? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Whole>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.WholeConverter.CreateOpenXmlElement<DXDrawDgms.Whole>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  private static DMDrawsDgms.DataModelExtensionList? GetDataModelExtensionList(DXDrawDgms.DataModelRoot openXmlElement)
  {
    return DMXDrawsDgms.DataModelExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.DataModelExtensionList>());
  }
  
  private static bool CmpDataModelExtensionList(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.DataModelExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.DataModelExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.DataModelExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataModelExtensionList(DXDrawDgms.DataModelRoot openXmlElement, DMDrawsDgms.DataModelExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.DataModelExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.DataModelExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.DataModelExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.DataModelRoot? CreateModelElement(DXDrawDgms.DataModelRoot? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.DataModelRoot();
      value.PointList = GetPointList(openXmlElement);
      value.ConnectionList = GetConnectionList(openXmlElement);
      value.Background = GetBackground(openXmlElement);
      value.Whole = GetWhole(openXmlElement);
      value.DataModelExtensionList = GetDataModelExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.DataModelRoot? openXmlElement, DMDrawsDgms.DataModelRoot? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointList(openXmlElement, value.PointList, diffs, objName))
        ok = false;
      if (!CmpConnectionList(openXmlElement, value.ConnectionList, diffs, objName))
        ok = false;
      if (!CmpBackground(openXmlElement, value.Background, diffs, objName))
        ok = false;
      if (!CmpWhole(openXmlElement, value.Whole, diffs, objName))
        ok = false;
      if (!CmpDataModelExtensionList(openXmlElement, value.DataModelExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DataModelRoot? value)
    where OpenXmlElementType: DXDrawDgms.DataModelRoot, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointList(openXmlElement, value?.PointList);
      SetConnectionList(openXmlElement, value?.ConnectionList);
      SetBackground(openXmlElement, value?.Background);
      SetWhole(openXmlElement, value?.Whole);
      SetDataModelExtensionList(openXmlElement, value?.DataModelExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
