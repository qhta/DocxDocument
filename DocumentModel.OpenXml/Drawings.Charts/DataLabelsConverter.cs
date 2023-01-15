using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using DataLabel = DocumentModel.Drawings.Charts.DataLabel;
using DataLabels = DocumentFormat.OpenXml.Drawing.Charts.DataLabels;
using DLblsExtensionList = DocumentModel.Drawings.Charts.DLblsExtensionList;
using LeaderLines = DocumentModel.Drawings.Charts.LeaderLines;
using NumberingFormat = DocumentModel.Drawings.Charts.NumberingFormat;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Data Labels.
/// </summary>
public static class DataLabelsConverter
{
  public static Collection<DataLabel>? GetItems(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DataLabel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>())
      {
        var newItem = DataLabelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(DataLabels? openXmlElement, Collection<DataLabel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DataLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Boolean? GetDelete(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Delete>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDelete(DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Delete>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Delete();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NumberingFormat? GetNumberingFormat(DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(DataLabels? openXmlElement, NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ChartShapeProperties? GetChartShapeProperties(DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(DataLabels? openXmlElement, ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextProperties? GetTextProperties(DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(DataLabels? openXmlElement, TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DataLabelPositionKind? GetDataLabelPosition(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataLabelPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DataLabelPositionValues, DataLabelPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDataLabelPosition(DataLabels? openXmlElement, DataLabelPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataLabelPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DataLabelPosition, DataLabelPositionValues, DataLabelPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowLegendKey(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowLegendKey>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowLegendKey(DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowLegendKey>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowLegendKey();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowValue(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowValue>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowValue(DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowValue>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowValue();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowCategoryName(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowCategoryName>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowCategoryName(DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowCategoryName>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowCategoryName();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowSeriesName(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowSeriesName>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowSeriesName(DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowSeriesName>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowSeriesName();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowPercent(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowPercent>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowPercent(DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowPercent>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowPercent();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowBubbleSize(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowBubbleSize>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowBubbleSize(DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowBubbleSize>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowBubbleSize();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetSeparator(DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Separator>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetSeparator(DataLabels? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Separator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Separator { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowLeaderLines(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowLeaderLines>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowLeaderLines(DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowLeaderLines>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowLeaderLines();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LeaderLines? GetLeaderLines(DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LeaderLines>();
    if (itemElement != null)
      return LeaderLinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeaderLines(DataLabels? openXmlElement, LeaderLines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeaderLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LeaderLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DLblsExtensionList? GetDLblsExtensionList(DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList>();
    if (itemElement != null)
      return DLblsExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDLblsExtensionList(DataLabels? openXmlElement, DLblsExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DLblsExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DataLabels? CreateModelElement(DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabels();
      value.Items = GetItems(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.DataLabelPosition = GetDataLabelPosition(openXmlElement);
      value.ShowLegendKey = GetShowLegendKey(openXmlElement);
      value.ShowValue = GetShowValue(openXmlElement);
      value.ShowCategoryName = GetShowCategoryName(openXmlElement);
      value.ShowSeriesName = GetShowSeriesName(openXmlElement);
      value.ShowPercent = GetShowPercent(openXmlElement);
      value.ShowBubbleSize = GetShowBubbleSize(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.ShowLeaderLines = GetShowLeaderLines(openXmlElement);
      value.LeaderLines = GetLeaderLines(openXmlElement);
      value.DLblsExtensionList = GetDLblsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataLabels? value)
    where OpenXmlElementType : DataLabels, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      SetDelete(openXmlElement, value?.Delete);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetDataLabelPosition(openXmlElement, value?.DataLabelPosition);
      SetShowLegendKey(openXmlElement, value?.ShowLegendKey);
      SetShowValue(openXmlElement, value?.ShowValue);
      SetShowCategoryName(openXmlElement, value?.ShowCategoryName);
      SetShowSeriesName(openXmlElement, value?.ShowSeriesName);
      SetShowPercent(openXmlElement, value?.ShowPercent);
      SetShowBubbleSize(openXmlElement, value?.ShowBubbleSize);
      SetSeparator(openXmlElement, value?.Separator);
      SetShowLeaderLines(openXmlElement, value?.ShowLeaderLines);
      SetLeaderLines(openXmlElement, value?.LeaderLines);
      SetDLblsExtensionList(openXmlElement, value?.DLblsExtensionList);
      return openXmlElement;
    }
    return default;
  }
}