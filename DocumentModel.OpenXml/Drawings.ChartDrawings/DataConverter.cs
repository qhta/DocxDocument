namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Data Class.
/// </summary>
public static class DataConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NumericDimension? GetNumericDimension(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.NumericDimensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumericDimension(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement, DocumentModel.Drawings.ChartDrawings.NumericDimension? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.NumericDimensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.StringDimension? GetStringDimension(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.StringDimensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStringDimension(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement, DocumentModel.Drawings.ChartDrawings.StringDimension? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.StringDimensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Data? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Data();
      value.Id = GetId(openXmlElement);
      value.NumericDimension = GetNumericDimension(openXmlElement);
      value.StringDimension = GetStringDimension(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Data? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
