namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public static class OfPieChartConverter
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  private static DocumentModel.Drawings.Charts.OfPieKind? GetOfPieType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DocumentModel.Drawings.Charts.OfPieKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetOfPieType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, DocumentModel.Drawings.Charts.OfPieKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OfPieType, DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DocumentModel.Drawings.Charts.OfPieKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.VaryColors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries> GetPieChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.PieChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPieChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.PieChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt16? GetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.GapWidth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.SplitKind? GetSplitType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DocumentModel.Drawings.Charts.SplitKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetSplitType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, DocumentModel.Drawings.Charts.SplitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SplitType, DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DocumentModel.Drawings.Charts.SplitKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Double? GetSplitPosition(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSplitPosition(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.SplitPosition{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.CustomSplit? GetCustomSplit(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomSplit>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CustomSplitConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomSplit(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, DocumentModel.Drawings.Charts.CustomSplit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomSplit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.CustomSplitConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CustomSplit>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt16? GetSecondPieSize(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SecondPieSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSecondPieSize(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SecondPieSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.SecondPieSize{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SeriesLines> GetSeriesLineses(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SeriesLines>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.SeriesLinesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetSeriesLineses(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SeriesLines>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.SeriesLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.OfPieChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.OfPieChart();
      value.OfPieType = GetOfPieType(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSerieses = GetPieChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.GapWidth = GetGapWidth(openXmlElement);
      value.SplitType = GetSplitType(openXmlElement);
      value.SplitPosition = GetSplitPosition(openXmlElement);
      value.CustomSplit = GetCustomSplit(openXmlElement);
      value.SecondPieSize = GetSecondPieSize(openXmlElement);
      value.SeriesLineses = GetSeriesLineses(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.OfPieChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.OfPieChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOfPieType(openXmlElement, value?.OfPieType);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetPieChartSerieses(openXmlElement, value?.PieChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetGapWidth(openXmlElement, value?.GapWidth);
      SetSplitType(openXmlElement, value?.SplitType);
      SetSplitPosition(openXmlElement, value?.SplitPosition);
      SetCustomSplit(openXmlElement, value?.CustomSplit);
      SetSecondPieSize(openXmlElement, value?.SecondPieSize);
      SetSeriesLineses(openXmlElement, value?.SeriesLineses);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
