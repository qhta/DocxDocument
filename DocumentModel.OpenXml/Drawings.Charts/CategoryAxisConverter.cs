namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Category Axis Data.
/// </summary>
public static class CategoryAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public static UInt32? GetAxisId(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.AxisId");
  }
  
  public static void SetAxisId(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.AxisId");
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Scaling? GetScaling(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ScalingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScaling(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.Scaling? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ScalingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Scaling>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public static Boolean? GetDelete(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDelete(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Delete();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public static DocumentModel.Drawings.Charts.AxisPositionKind? GetAxisPosition(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisPosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DocumentModel.Drawings.Charts.AxisPositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetAxisPosition(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.AxisPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AxisPosition, DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DocumentModel.Drawings.Charts.AxisPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public static DocumentModel.Drawings.Charts.MajorGridlines? GetMajorGridlines(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MajorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMajorGridlines(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.MajorGridlines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.MajorGridlinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public static DocumentModel.Drawings.Charts.MinorGridlines? GetMinorGridlines(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MinorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMinorGridlines(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.MinorGridlines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.MinorGridlinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Title.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Title? GetTitle(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.Title? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.TitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Title>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public static DocumentModel.Drawings.Charts.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TickMarkKind? GetMajorTickMark(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DocumentModel.Drawings.Charts.TickMarkKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMajorTickMark(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.TickMarkKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark, DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DocumentModel.Drawings.Charts.TickMarkKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TickMarkKind? GetMinorTickMark(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DocumentModel.Drawings.Charts.TickMarkKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMinorTickMark(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.TickMarkKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark, DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DocumentModel.Drawings.Charts.TickMarkKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TickLabelPositionKind? GetTickLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DocumentModel.Drawings.Charts.TickLabelPositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTickLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.TickLabelPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DocumentModel.Drawings.Charts.TickLabelPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public static UInt32? GetCrossingAxis(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis");
  }
  
  public static void SetCrossingAxis(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis");
  }
  
  public static DocumentModel.Drawings.Charts.CrossesKind? GetCrosses(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Crosses>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DocumentModel.Drawings.Charts.CrossesKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetCrosses(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.CrossesKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Crosses>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Crosses, DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DocumentModel.Drawings.Charts.CrossesKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Double? GetCrossesAt(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.CrossesAt");
  }
  
  public static void SetCrossesAt(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.CrossesAt");
  }
  
  public static Boolean? GetAutoLabeled(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAutoLabeled(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.LabelAlignmentKind? GetLabelAlignment(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignment>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DocumentModel.Drawings.Charts.LabelAlignmentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLabelAlignment(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.LabelAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignment, DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DocumentModel.Drawings.Charts.LabelAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static UInt16? GetLabelOffset(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.LabelOffset");
  }
  
  public static void SetLabelOffset(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.LabelOffset");
  }
  
  public static Int32? GetTickLabelSkip(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.TickLabelSkip");
  }
  
  public static void SetTickLabelSkip(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.TickLabelSkip");
  }
  
  public static Int32? GetTickMarkSkip(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.TickMarkSkip");
  }
  
  public static void SetTickMarkSkip(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.TickMarkSkip");
  }
  
  public static Boolean? GetNoMultiLevelLabels(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NoMultiLevelLabels>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoMultiLevelLabels(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NoMultiLevelLabels>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.NoMultiLevelLabels();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.CatAxExtensionList? GetCatAxExtensionList(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CatAxExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCatAxExtensionList(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement, DocumentModel.Drawings.Charts.CatAxExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.CatAxExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryAxis? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryAxis();
      value.AxisId = GetAxisId(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.AxisPosition = GetAxisPosition(openXmlElement);
      value.MajorGridlines = GetMajorGridlines(openXmlElement);
      value.MinorGridlines = GetMinorGridlines(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.MajorTickMark = GetMajorTickMark(openXmlElement);
      value.MinorTickMark = GetMinorTickMark(openXmlElement);
      value.TickLabelPosition = GetTickLabelPosition(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.CrossingAxis = GetCrossingAxis(openXmlElement);
      value.Crosses = GetCrosses(openXmlElement);
      value.CrossesAt = GetCrossesAt(openXmlElement);
      value.AutoLabeled = GetAutoLabeled(openXmlElement);
      value.LabelAlignment = GetLabelAlignment(openXmlElement);
      value.LabelOffset = GetLabelOffset(openXmlElement);
      value.TickLabelSkip = GetTickLabelSkip(openXmlElement);
      value.TickMarkSkip = GetTickMarkSkip(openXmlElement);
      value.NoMultiLevelLabels = GetNoMultiLevelLabels(openXmlElement);
      value.CatAxExtensionList = GetCatAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CategoryAxis? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
