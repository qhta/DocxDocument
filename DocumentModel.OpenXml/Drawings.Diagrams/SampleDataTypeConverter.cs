using DocumentFormat.OpenXml.Drawing.Diagrams;
using DataModel = DocumentModel.Drawings.Diagrams.DataModel;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Defines the SampleDataType Class.
/// </summary>
public static class SampleDataTypeConverter
{
  /// <summary>
  ///   Use Default
  /// </summary>
  public static Boolean? GetUseDefault(SampleDataType? openXmlElement)
  {
    return openXmlElement?.UseDefault?.Value;
  }

  public static void SetUseDefault(SampleDataType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseDefault = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseDefault = null;
  }

  /// <summary>
  ///   Data Model.
  /// </summary>
  public static DataModel? GetDataModel(SampleDataType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
    if (itemElement != null)
      return DataModelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataModel(SampleDataType? openXmlElement, DataModel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataModelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.SampleDataType? CreateModelElement(SampleDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.SampleDataType();
      value.UseDefault = GetUseDefault(openXmlElement);
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.SampleDataType? value)
    where OpenXmlElementType : SampleDataType, new()
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