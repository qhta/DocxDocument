using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DocumentModel.Drawings.Charts;
using CategoryFilterException = DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException;
using DataLabel = DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel;
using Marker = DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker;
using ShapeProperties = DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the CategoryFilterException Class.
/// </summary>
public static class CategoryFilterExceptionConverter
{
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public static String? GetSequenceOfReferences(CategoryFilterException? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SequenceOfReferences>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetSequenceOfReferences(CategoryFilterException? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SequenceOfReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SequenceOfReferences { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public static ShapeProperties3? GetShapeProperties(CategoryFilterException? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ShapeProperties>();
    if (itemElement != null)
      return ShapeProperties3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(CategoryFilterException? openXmlElement, ShapeProperties3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeProperties3Converter.CreateOpenXmlElement<ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Explosion.
  /// </summary>
  public static UInt32? GetExplosion(CategoryFilterException? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Explosion>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetExplosion(CategoryFilterException? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Explosion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Explosion { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   InvertIfNegativeBoolean.
  /// </summary>
  public static Boolean? GetInvertIfNegativeBoolean(CategoryFilterException? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InvertIfNegativeBoolean>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInvertIfNegativeBoolean(CategoryFilterException? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<InvertIfNegativeBoolean>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new InvertIfNegativeBoolean();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Bubble3D.
  /// </summary>
  public static Boolean? GetBubble3D(CategoryFilterException? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Bubble3D>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBubble3D(CategoryFilterException? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Bubble3D>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Bubble3D();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Marker.
  /// </summary>
  public static Marker3? GetMarker(CategoryFilterException? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Marker>();
    if (itemElement != null)
      return Marker3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMarker(CategoryFilterException? openXmlElement, Marker3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Marker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Marker3Converter.CreateOpenXmlElement<Marker>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataLabel.
  /// </summary>
  public static DataLabel3? GetDataLabel(CategoryFilterException? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DataLabel>();
    if (itemElement != null)
      return DataLabel3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabel(CategoryFilterException? openXmlElement, DataLabel3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabel3Converter.CreateOpenXmlElement<DataLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.CategoryFilterException? CreateModelElement(CategoryFilterException? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryFilterException();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Explosion = GetExplosion(openXmlElement);
      value.InvertIfNegativeBoolean = GetInvertIfNegativeBoolean(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.DataLabel = GetDataLabel(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CategoryFilterException? value)
    where OpenXmlElementType : CategoryFilterException, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetExplosion(openXmlElement, value?.Explosion);
      SetInvertIfNegativeBoolean(openXmlElement, value?.InvertIfNegativeBoolean);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetMarker(openXmlElement, value?.Marker);
      SetDataLabel(openXmlElement, value?.DataLabel);
      return openXmlElement;
    }
    return default;
  }
}