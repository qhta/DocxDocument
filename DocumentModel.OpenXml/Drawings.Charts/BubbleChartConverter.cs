namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bubble Charts.
/// </summary>
public static class BubbleChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleChartSeries>? GetBubbleChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartSeries>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.BubbleChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetBubbleChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartSeries>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.BubbleChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetBubble3D(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBubble3D(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Bubble3D();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static UInt32? GetBubbleScale(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetBubbleScale(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleScale>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.Charts.BubbleScale{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowNegativeBubbles(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowNegativeBubbles>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowNegativeBubbles(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowNegativeBubbles>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowNegativeBubbles();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SizeRepresentsKind? GetSizeRepresents(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DocumentModel.Drawings.Charts.SizeRepresentsKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSizeRepresents(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, DocumentModel.Drawings.Charts.SizeRepresentsKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents, DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DocumentModel.Drawings.Charts.SizeRepresentsKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<UInt32>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AxisId>())
      {
        var newItem = UInt32ValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((UInt32)newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = UInt32ValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AxisId>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChartExtensionList? GetBubbleChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BubbleChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBubbleChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, DocumentModel.Drawings.Charts.BubbleChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.BubbleChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BubbleChartSerieses = GetBubbleChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.BubbleScale = GetBubbleScale(openXmlElement);
      value.ShowNegativeBubbles = GetShowNegativeBubbles(openXmlElement);
      value.SizeRepresents = GetSizeRepresents(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.BubbleChartExtensionList = GetBubbleChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BubbleChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVaryColors(openXmlElement, value?.VaryColors);
      return openXmlElement;
    }
    return default;
  }
}
