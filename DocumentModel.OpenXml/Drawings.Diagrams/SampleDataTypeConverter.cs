namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public static class SampleDataTypeConverter
{
  /// <summary>
  /// Use Default
  /// </summary>
  private static Boolean? GetUseDefault(DXDrawDgms.SampleDataType openXmlElement)
  {
    return openXmlElement?.UseDefault?.Value;
  }
  
  private static void SetUseDefault(DXDrawDgms.SampleDataType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseDefault = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseDefault = null;
  }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  private static DMDrawsDgms.DataModel? GetDataModel(DXDrawDgms.SampleDataType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.DataModel>();
    if (itemElement != null)
      return DMXDrawsDgms.DataModelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataModel(DXDrawDgms.SampleDataType openXmlElement, DMDrawsDgms.DataModel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.DataModel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.DataModelConverter.CreateOpenXmlElement<DXDrawDgms.DataModel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.SampleDataType? CreateModelElement(DXDrawDgms.SampleDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.SampleDataType();
      value.UseDefault = GetUseDefault(openXmlElement);
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.SampleDataType? value)
    where OpenXmlElementType: DXDrawDgms.SampleDataType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUseDefault(openXmlElement, value?.UseDefault);
      SetDataModel(openXmlElement, value?.DataModel);
      return openXmlElement;
    }
    return default;
  }
}
