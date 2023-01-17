namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Date Axis.
/// </summary>
public static class DateAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  private static UInt32? GetAxisId(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAxisId(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.AxisId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  private static DocumentModel.Drawings.Charts.Scaling? GetScaling(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ScalingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScaling(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.Scaling? value)
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
  
  /// <summary>
  /// Delete.
  /// </summary>
  private static Boolean? GetDelete(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
    return itemElement != null;
  }
  
  private static void SetDelete(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  private static DocumentModel.Drawings.Charts.AxisPositionKind? GetAxisPosition(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisPosition>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DocumentModel.Drawings.Charts.AxisPositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAxisPosition(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.AxisPositionKind? value)
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
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  private static DocumentModel.Drawings.Charts.MajorGridlines? GetMajorGridlines(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MajorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMajorGridlines(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.MajorGridlines? value)
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
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  private static DocumentModel.Drawings.Charts.MinorGridlines? GetMinorGridlines(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MinorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMinorGridlines(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.MinorGridlines? value)
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
  
  /// <summary>
  /// Title.
  /// </summary>
  private static DocumentModel.Drawings.Charts.Title? GetTitle(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTitle(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.Title? value)
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
  
  /// <summary>
  /// Number Format.
  /// </summary>
  private static DocumentModel.Drawings.Charts.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat? value)
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
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  private static DocumentModel.Drawings.Charts.TickMarkKind? GetMajorTickMark(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DocumentModel.Drawings.Charts.TickMarkKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMajorTickMark(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.TickMarkKind? value)
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
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  private static DocumentModel.Drawings.Charts.TickMarkKind? GetMinorTickMark(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DocumentModel.Drawings.Charts.TickMarkKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMinorTickMark(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.TickMarkKind? value)
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
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  private static DocumentModel.Drawings.Charts.TickLabelPositionKind? GetTickLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DocumentModel.Drawings.Charts.TickLabelPositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTickLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.TickLabelPositionKind? value)
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
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  private static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
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
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  private static UInt32? GetCrossingAxis(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetCrossingAxis(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.CrossesKind? GetCrosses(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Crosses>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DocumentModel.Drawings.Charts.CrossesKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetCrosses(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.CrossesKind? value)
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
  
  private static Double? GetCrossesAt(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossesAt>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetCrossesAt(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossesAt>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.CrossesAt{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAutoLabeled(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled>();
    return itemElement != null;
  }
  
  private static void SetAutoLabeled(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, Boolean? value)
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
  
  private static UInt16? GetLabelOffset(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LabelOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLabelOffset(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LabelOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.LabelOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.TimeUnitKind? GetBaseTimeUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BaseTimeUnit>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DocumentModel.Drawings.Charts.TimeUnitKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBaseTimeUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.TimeUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BaseTimeUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BaseTimeUnit, DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DocumentModel.Drawings.Charts.TimeUnitKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Double? GetMajorUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMajorUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.MajorUnit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.TimeUnitKind? GetMajorTimeUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTimeUnit>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DocumentModel.Drawings.Charts.TimeUnitKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMajorTimeUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.TimeUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTimeUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MajorTimeUnit, DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DocumentModel.Drawings.Charts.TimeUnitKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Double? GetMinorUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMinorUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.MinorUnit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.TimeUnitKind? GetMinorTimeUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTimeUnit>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DocumentModel.Drawings.Charts.TimeUnitKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMinorTimeUnit(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.TimeUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTimeUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MinorTimeUnit, DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DocumentModel.Drawings.Charts.TimeUnitKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.DateAxExtensionList? GetDateAxExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DateAxExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDateAxExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement, DocumentModel.Drawings.Charts.DateAxExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.DateAxExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DateAxis? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DateAxis();
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
      value.LabelOffset = GetLabelOffset(openXmlElement);
      value.BaseTimeUnit = GetBaseTimeUnit(openXmlElement);
      value.MajorUnit = GetMajorUnit(openXmlElement);
      value.MajorTimeUnit = GetMajorTimeUnit(openXmlElement);
      value.MinorUnit = GetMinorUnit(openXmlElement);
      value.MinorTimeUnit = GetMinorTimeUnit(openXmlElement);
      value.DateAxExtensionList = GetDateAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DateAxis? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DateAxis, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAxisId(openXmlElement, value?.AxisId);
      SetScaling(openXmlElement, value?.Scaling);
      SetDelete(openXmlElement, value?.Delete);
      SetAxisPosition(openXmlElement, value?.AxisPosition);
      SetMajorGridlines(openXmlElement, value?.MajorGridlines);
      SetMinorGridlines(openXmlElement, value?.MinorGridlines);
      SetTitle(openXmlElement, value?.Title);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetMajorTickMark(openXmlElement, value?.MajorTickMark);
      SetMinorTickMark(openXmlElement, value?.MinorTickMark);
      SetTickLabelPosition(openXmlElement, value?.TickLabelPosition);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetCrossingAxis(openXmlElement, value?.CrossingAxis);
      SetCrosses(openXmlElement, value?.Crosses);
      SetCrossesAt(openXmlElement, value?.CrossesAt);
      SetAutoLabeled(openXmlElement, value?.AutoLabeled);
      SetLabelOffset(openXmlElement, value?.LabelOffset);
      SetBaseTimeUnit(openXmlElement, value?.BaseTimeUnit);
      SetMajorUnit(openXmlElement, value?.MajorUnit);
      SetMajorTimeUnit(openXmlElement, value?.MajorTimeUnit);
      SetMinorUnit(openXmlElement, value?.MinorUnit);
      SetMinorTimeUnit(openXmlElement, value?.MinorTimeUnit);
      SetDateAxExtensionList(openXmlElement, value?.DateAxExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
