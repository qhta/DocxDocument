using DocumentModel.Drawings.ChartDrawings;
using ValueColors = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ValueColors Class.
/// </summary>
public static class ValueColorsConverter
{
  /// <summary>
  ///   MinColorSolidColorFillProperties.
  /// </summary>
  public static MinColorSolidColorFillProperties? GetMinColorSolidColorFillProperties(ValueColors? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties>();
    if (itemElement != null)
      return MinColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinColorSolidColorFillProperties(ValueColors? openXmlElement, MinColorSolidColorFillProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   MidColorSolidColorFillProperties.
  /// </summary>
  public static MidColorSolidColorFillProperties? GetMidColorSolidColorFillProperties(ValueColors? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties>();
    if (itemElement != null)
      return MidColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMidColorSolidColorFillProperties(ValueColors? openXmlElement, MidColorSolidColorFillProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MidColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   MaxColorSolidColorFillProperties.
  /// </summary>
  public static MaxColorSolidColorFillProperties? GetMaxColorSolidColorFillProperties(ValueColors? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties>();
    if (itemElement != null)
      return MaxColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMaxColorSolidColorFillProperties(ValueColors? openXmlElement, MaxColorSolidColorFillProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MaxColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ValueColors? CreateModelElement(ValueColors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColors();
      value.MinColorSolidColorFillProperties = GetMinColorSolidColorFillProperties(openXmlElement);
      value.MidColorSolidColorFillProperties = GetMidColorSolidColorFillProperties(openXmlElement);
      value.MaxColorSolidColorFillProperties = GetMaxColorSolidColorFillProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ValueColors? value)
    where OpenXmlElementType : ValueColors, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMinColorSolidColorFillProperties(openXmlElement, value?.MinColorSolidColorFillProperties);
      SetMidColorSolidColorFillProperties(openXmlElement, value?.MidColorSolidColorFillProperties);
      SetMaxColorSolidColorFillProperties(openXmlElement, value?.MaxColorSolidColorFillProperties);
      return openXmlElement;
    }
    return default;
  }
}