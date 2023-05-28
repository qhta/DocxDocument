namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
public static class DataModelRootConverter
{
  /// <summary>
  /// Point List.
  /// </summary>
  private static DMDD.PointList? GetPointList(DXDD.DataModelRoot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.PointList>();
    if (element != null)
      return DMXDD.PointListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPointList(DXDD.DataModelRoot openXmlElement, DMDD.PointList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.PointListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.PointList>(), value, diffs, objName, propName);
  }
  
  private static void SetPointList(DXDD.DataModelRoot openXmlElement, DMDD.PointList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.PointList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.PointListConverter.CreateOpenXmlElement<DXDD.PointList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  private static DMDD.ConnectionList? GetConnectionList(DXDD.DataModelRoot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ConnectionList>();
    if (element != null)
      return DMXDD.ConnectionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionList(DXDD.DataModelRoot openXmlElement, DMDD.ConnectionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ConnectionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ConnectionList>(), value, diffs, objName, propName);
  }
  
  private static void SetConnectionList(DXDD.DataModelRoot openXmlElement, DMDD.ConnectionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ConnectionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ConnectionListConverter.CreateOpenXmlElement<DXDD.ConnectionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  private static DMDD.Background? GetBackground(DXDD.DataModelRoot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Background>();
    if (element != null)
      return DMXDD.BackgroundConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackground(DXDD.DataModelRoot openXmlElement, DMDD.Background? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.BackgroundConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Background>(), value, diffs, objName, propName);
  }
  
  private static void SetBackground(DXDD.DataModelRoot openXmlElement, DMDD.Background? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Background>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.BackgroundConverter.CreateOpenXmlElement<DXDD.Background>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  private static DMDD.Whole? GetWhole(DXDD.DataModelRoot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Whole>();
    if (element != null)
      return DMXDD.WholeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWhole(DXDD.DataModelRoot openXmlElement, DMDD.Whole? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.WholeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Whole>(), value, diffs, objName, propName);
  }
  
  private static void SetWhole(DXDD.DataModelRoot openXmlElement, DMDD.Whole? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Whole>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.WholeConverter.CreateOpenXmlElement<DXDD.Whole>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  private static DMDD.DataModelExtensionList? GetDataModelExtensionList(DXDD.DataModelRoot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.DataModelExtensionList>();
    if (element != null)
      return DMXDD.DataModelExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataModelExtensionList(DXDD.DataModelRoot openXmlElement, DMDD.DataModelExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.DataModelExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.DataModelExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetDataModelExtensionList(DXDD.DataModelRoot openXmlElement, DMDD.DataModelExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.DataModelExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.DataModelExtensionListConverter.CreateOpenXmlElement<DXDD.DataModelExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.DataModelRoot? CreateModelElement(DXDD.DataModelRoot? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.DataModelRoot();
      value.PointList = GetPointList(openXmlElement);
      value.ConnectionList = GetConnectionList(openXmlElement);
      value.Background = GetBackground(openXmlElement);
      value.Whole = GetWhole(openXmlElement);
      value.DataModelExtensionList = GetDataModelExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.DataModelRoot? openXmlElement, DMDD.DataModelRoot? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointList(openXmlElement, value.PointList, diffs, objName, propName))
        ok = false;
      if (!CmpConnectionList(openXmlElement, value.ConnectionList, diffs, objName, propName))
        ok = false;
      if (!CmpBackground(openXmlElement, value.Background, diffs, objName, propName))
        ok = false;
      if (!CmpWhole(openXmlElement, value.Whole, diffs, objName, propName))
        ok = false;
      if (!CmpDataModelExtensionList(openXmlElement, value.DataModelExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.DataModelRoot value)
    where OpenXmlElementType: DXDD.DataModelRoot, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.DataModelRoot openXmlElement, DMDD.DataModelRoot value)
  {
    SetPointList(openXmlElement, value?.PointList);
    SetConnectionList(openXmlElement, value?.ConnectionList);
    SetBackground(openXmlElement, value?.Background);
    SetWhole(openXmlElement, value?.Whole);
    SetDataModelExtensionList(openXmlElement, value?.DataModelExtensionList);
  }
}
