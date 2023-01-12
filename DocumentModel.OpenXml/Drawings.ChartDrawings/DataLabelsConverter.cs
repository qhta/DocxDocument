namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public static class DataLabelsConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.DataLabelPos? GetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DocumentModel.Drawings.ChartDrawings.DataLabelPos>(openXmlElement?.Pos?.Value);
  }
  
  public static void SetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabelPos? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DocumentModel.Drawings.ChartDrawings.DataLabelPos>(value);
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.NumberFormat? GetNumberFormat(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.NumberFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberFormat(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.NumberFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.NumberFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.TxPrTextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? GetDataLabelVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelVisibilitiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabelVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelVisibilitiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public static String? GetSeparatorXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring");
  }
  
  public static void SetSeparatorXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabel>? GetItems(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>? GetDataLabelHiddens(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelHiddenConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetDataLabelHiddens(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelHiddenConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabels? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.DataLabels();
      value.Pos = GetPos(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.DataLabelVisibilities = GetDataLabelVisibilities(openXmlElement);
      value.SeparatorXsdstring = GetSeparatorXsdstring(openXmlElement);
      value.Items = GetItems(openXmlElement);
      value.DataLabelHiddens = GetDataLabelHiddens(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.DataLabels? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPos(openXmlElement, value?.Pos);
      SetNumberFormat(openXmlElement, value?.NumberFormat);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetDataLabelVisibilities(openXmlElement, value?.DataLabelVisibilities);
      SetSeparatorXsdstring(openXmlElement, value?.SeparatorXsdstring);
      return openXmlElement;
    }
    return default;
  }
}
