namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public static class DLblExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelFieldTable? GetDataLabelFieldTable(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelFieldTableConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabelFieldTable(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement, DocumentModel.Drawings.Charts.DataLabelFieldTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelFieldTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetExceptionForSave(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetExceptionForSave(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ShapeProperties3? GetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ShapeProperties3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement, DocumentModel.Drawings.Charts.ShapeProperties3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ShapeProperties3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Layout3? GetLayout(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Layout3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement, DocumentModel.Drawings.Charts.Layout3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.Layout3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblExtension();
      value.Uri = GetUri(openXmlElement);
      value.DataLabelFieldTable = GetDataLabelFieldTable(openXmlElement);
      value.ExceptionForSave = GetExceptionForSave(openXmlElement);
      value.ShowDataLabelsRange = GetShowDataLabelsRange(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DLblExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DLblExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetDataLabelFieldTable(openXmlElement, value?.DataLabelFieldTable);
      SetExceptionForSave(openXmlElement, value?.ExceptionForSave);
      SetShowDataLabelsRange(openXmlElement, value?.ShowDataLabelsRange);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetLayout(openXmlElement, value?.Layout);
      return openXmlElement;
    }
    return default;
  }
}
