namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Axis Class.
/// </summary>
public static class AxisConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetHidden(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  public static void SetHidden(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Hidden = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.CategoryAxisScaling? GetCategoryAxisScaling(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.CategoryAxisScalingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCategoryAxisScaling(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.CategoryAxisScaling? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.CategoryAxisScalingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueAxisScaling? GetValueAxisScaling(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ValueAxisScalingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetValueAxisScaling(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.ValueAxisScaling? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ValueAxisScalingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.AxisTitle? GetAxisTitle(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.AxisTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAxisTitle(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.AxisTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.AxisTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.AxisUnits? GetAxisUnits(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.AxisUnitsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAxisUnits(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.AxisUnits? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.AxisUnitsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.MajorGridlinesGridlines? GetMajorGridlinesGridlines(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MajorGridlinesGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMajorGridlinesGridlines(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.MajorGridlinesGridlines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MajorGridlinesGridlinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.MinorGridlinesGridlines? GetMinorGridlinesGridlines(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MinorGridlinesGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMinorGridlinesGridlines(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.MinorGridlinesGridlines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MinorGridlinesGridlinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks? GetMajorTickMarksTickMarks(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MajorTickMarksTickMarksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMajorTickMarksTickMarks(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MajorTickMarksTickMarksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.MinorTickMarksTickMarks? GetMinorTickMarksTickMarks(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MinorTickMarksTickMarksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMinorTickMarksTickMarks(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.MinorTickMarksTickMarks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MinorTickMarksTickMarksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.TickLabels? GetTickLabels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TickLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTickLabels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.TickLabels? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.TickLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NumberFormat? GetNumberFormat(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.NumberFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberFormat(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.NumberFormat? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.Axis? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Axis();
      value.Id = GetId(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.CategoryAxisScaling = GetCategoryAxisScaling(openXmlElement);
      value.ValueAxisScaling = GetValueAxisScaling(openXmlElement);
      value.AxisTitle = GetAxisTitle(openXmlElement);
      value.AxisUnits = GetAxisUnits(openXmlElement);
      value.MajorGridlinesGridlines = GetMajorGridlinesGridlines(openXmlElement);
      value.MinorGridlinesGridlines = GetMinorGridlinesGridlines(openXmlElement);
      value.MajorTickMarksTickMarks = GetMajorTickMarksTickMarks(openXmlElement);
      value.MinorTickMarksTickMarks = GetMinorTickMarksTickMarks(openXmlElement);
      value.TickLabels = GetTickLabels(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Axis? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
