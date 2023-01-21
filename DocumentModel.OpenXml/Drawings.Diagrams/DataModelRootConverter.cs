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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.PointList>();
    if (itemElement != null)
      return DMXDrawsDgms.PointListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ConnectionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ConnectionListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Background>();
    if (itemElement != null)
      return DMXDrawsDgms.BackgroundConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Whole>();
    if (itemElement != null)
      return DMXDrawsDgms.WholeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.DataModelExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.DataModelExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
