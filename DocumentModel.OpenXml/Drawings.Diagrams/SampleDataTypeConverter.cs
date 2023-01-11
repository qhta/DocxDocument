namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public static class SampleDataTypeConverter
{
  /// <summary>
  /// Use Default
  /// </summary>
  public static Boolean? GetUseDefault(DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType? openXmlElement)
  {
    return openXmlElement?.UseDefault?.Value;
  }
  
  public static void SetUseDefault(DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseDefault = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseDefault = null;
  }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.DataModel? GetDataModel(DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.DataModelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataModel(DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType? openXmlElement, DocumentModel.Drawings.Diagrams.DataModel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.DataModelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.SampleDataType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
