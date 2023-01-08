namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Value Axis.
/// </summary>
public static class ValueAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public static UInt32? GetAxisId(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisId(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Scaling? GetScaling(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetScaling(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.Scaling? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public static Boolean? GetDelete(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDelete(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public static DocumentModel.Drawings.Charts.AxisPositionKind? GetAxisPosition(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
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
  
  public static void SetAxisPosition(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.AxisPositionKind? value)
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
  public static DocumentModel.Drawings.Charts.MajorGridlines? GetMajorGridlines(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMajorGridlines(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.MajorGridlines? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public static DocumentModel.Drawings.Charts.MinorGridlines? GetMinorGridlines(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMinorGridlines(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.MinorGridlines? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Title.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Title? GetTitle(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.Title? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public static DocumentModel.Drawings.Charts.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TickMarkKind? GetMajorTickMark(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
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
  
  public static void SetMajorTickMark(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.TickMarkKind? value)
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
  public static DocumentModel.Drawings.Charts.TickMarkKind? GetMinorTickMark(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
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
  
  public static void SetMinorTickMark(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.TickMarkKind? value)
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
  public static DocumentModel.Drawings.Charts.TickLabelPositionKind? GetTickLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
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
  
  public static void SetTickLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.TickLabelPositionKind? value)
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
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public static UInt32? GetCrossingAxis(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCrossingAxis(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.CrossesKind? GetCrosses(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
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
  
  public static void SetCrosses(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.CrossesKind? value)
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
  
  public static Double? GetCrossesAt(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCrossesAt(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.CrossBetweenKind? GetCrossBetween(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossBetween>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DocumentModel.Drawings.Charts.CrossBetweenKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetCrossBetween(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.CrossBetweenKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossBetween>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CrossBetween, DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DocumentModel.Drawings.Charts.CrossBetweenKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Double? GetMajorUnit(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMajorUnit(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Double? GetMinorUnit(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMinorUnit(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DisplayUnits? GetDisplayUnits(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDisplayUnits(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.DisplayUnits? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ValAxExtensionList? GetValAxExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetValAxExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? openXmlElement, DocumentModel.Drawings.Charts.ValAxExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
