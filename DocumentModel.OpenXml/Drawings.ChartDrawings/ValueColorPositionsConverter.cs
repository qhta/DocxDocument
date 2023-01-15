using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using MaxValueColorEndPosition = DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition;
using MinValueColorEndPosition = DocumentModel.Drawings.ChartDrawings.MinValueColorEndPosition;
using ValueColorMiddlePosition = DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ValueColorPositions Class.
/// </summary>
public static class ValueColorPositionsConverter
{
  /// <summary>
  ///   count, this property is only available in Office 2016 and later.
  /// </summary>
  public static Int32? GetCount(ValueColorPositions? openXmlElement)
  {
    return openXmlElement?.Count?.Value;
  }

  public static void SetCount(ValueColorPositions? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Count = value;
  }

  /// <summary>
  ///   MinValueColorEndPosition.
  /// </summary>
  public static MinValueColorEndPosition? GetMinValueColorEndPosition(ValueColorPositions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition>();
    if (itemElement != null)
      return MinValueColorEndPositionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinValueColorEndPosition(ValueColorPositions? openXmlElement, MinValueColorEndPosition? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinValueColorEndPositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ValueColorMiddlePosition.
  /// </summary>
  public static ValueColorMiddlePosition? GetValueColorMiddlePosition(ValueColorPositions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition>();
    if (itemElement != null)
      return ValueColorMiddlePositionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetValueColorMiddlePosition(ValueColorPositions? openXmlElement, ValueColorMiddlePosition? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueColorMiddlePositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   MaxValueColorEndPosition.
  /// </summary>
  public static MaxValueColorEndPosition? GetMaxValueColorEndPosition(ValueColorPositions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition>();
    if (itemElement != null)
      return MaxValueColorEndPositionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMaxValueColorEndPosition(ValueColorPositions? openXmlElement, MaxValueColorEndPosition? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MaxValueColorEndPositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ValueColorPositions? CreateModelElement(ValueColorPositions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColorPositions();
      value.Count = GetCount(openXmlElement);
      value.MinValueColorEndPosition = GetMinValueColorEndPosition(openXmlElement);
      value.ValueColorMiddlePosition = GetValueColorMiddlePosition(openXmlElement);
      value.MaxValueColorEndPosition = GetMaxValueColorEndPosition(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ValueColorPositions? value)
    where OpenXmlElementType : ValueColorPositions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCount(openXmlElement, value?.Count);
      SetMinValueColorEndPosition(openXmlElement, value?.MinValueColorEndPosition);
      SetValueColorMiddlePosition(openXmlElement, value?.ValueColorMiddlePosition);
      SetMaxValueColorEndPosition(openXmlElement, value?.MaxValueColorEndPosition);
      return openXmlElement;
    }
    return default;
  }
}