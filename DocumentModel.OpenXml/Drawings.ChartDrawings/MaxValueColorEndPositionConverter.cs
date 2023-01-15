using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the MaxValueColorEndPosition Class.
/// </summary>
public static class MaxValueColorEndPositionConverter
{
  public static Boolean? GetExtremeValueColorPosition(MaxValueColorEndPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ExtremeValueColorPosition>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetExtremeValueColorPosition(MaxValueColorEndPosition? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ExtremeValueColorPosition>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ExtremeValueColorPosition();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Double? GetNumberColorPosition(MaxValueColorEndPosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberColorPosition(MaxValueColorEndPosition? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumberColorPosition { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Double? GetPercentageColorPosition(MaxValueColorEndPosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PercentageColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPercentageColorPosition(MaxValueColorEndPosition? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PercentageColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PercentageColorPosition { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? CreateModelElement(MaxValueColorEndPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? value)
    where OpenXmlElementType : MaxValueColorEndPosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtremeValueColorPosition(openXmlElement, value?.ExtremeValueColorPosition);
      SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
      SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
      return openXmlElement;
    }
    return default;
  }
}