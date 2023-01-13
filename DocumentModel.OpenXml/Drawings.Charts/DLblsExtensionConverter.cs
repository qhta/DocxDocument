namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public static class DLblsExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.ChartText3? GetChartText(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartText3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartText(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement, DocumentModel.Drawings.Charts.ChartText3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartText3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelFieldTable? GetDataLabelFieldTable(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelFieldTableConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabelFieldTable(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement, DocumentModel.Drawings.Charts.DataLabelFieldTable? value)
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
  
  public static Boolean? GetShowDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Drawings.Charts.ShapeProperties3? GetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ShapeProperties3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement, DocumentModel.Drawings.Charts.ShapeProperties3? value)
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
  
  public static DocumentModel.Drawings.Charts.Layout3? GetLayout(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Layout3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement, DocumentModel.Drawings.Charts.Layout3? value)
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
  
  public static Boolean? GetShowLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.LeaderLines3? GetLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LeaderLines3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement, DocumentModel.Drawings.Charts.LeaderLines3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.LeaderLines3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblsExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblsExtension();
      value.Uri = GetUri(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.DataLabelFieldTable = GetDataLabelFieldTable(openXmlElement);
      value.ShowDataLabelsRange = GetShowDataLabelsRange(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.ShowLeaderLines = GetShowLeaderLines(openXmlElement);
      value.LeaderLines = GetLeaderLines(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DLblsExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetChartText(openXmlElement, value?.ChartText);
      SetDataLabelFieldTable(openXmlElement, value?.DataLabelFieldTable);
      SetShowDataLabelsRange(openXmlElement, value?.ShowDataLabelsRange);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetLayout(openXmlElement, value?.Layout);
      SetShowLeaderLines(openXmlElement, value?.ShowLeaderLines);
      SetLeaderLines(openXmlElement, value?.LeaderLines);
      return openXmlElement;
    }
    return default;
  }
}
