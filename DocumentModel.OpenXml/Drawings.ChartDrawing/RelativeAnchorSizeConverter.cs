using DocumentModel.Drawings.ChartDrawing;
using RelativeAnchorSize = DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Relative Anchor Shape Size.
/// </summary>
public static class RelativeAnchorSizeConverter
{
  /// <summary>
  ///   Starting Anchor Point.
  /// </summary>
  public static FromAnchor? GetFromAnchor(RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>();
    if (itemElement != null)
      return FromAnchorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFromAnchor(RelativeAnchorSize? openXmlElement, FromAnchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FromAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ending Anchor Point.
  /// </summary>
  public static ToAnchor? GetToAnchor(RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor>();
    if (itemElement != null)
      return ToAnchorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetToAnchor(RelativeAnchorSize? openXmlElement, ToAnchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ToAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shape? GetShape(RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>();
    if (itemElement != null)
      return ShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape(RelativeAnchorSize? openXmlElement, Shape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GroupShape? GetGroupShape(RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>();
    if (itemElement != null)
      return GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroupShape(RelativeAnchorSize? openXmlElement, GroupShape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GraphicFrame? GetGraphicFrame(RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>();
    if (itemElement != null)
      return GraphicFrameConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGraphicFrame(RelativeAnchorSize? openXmlElement, GraphicFrame? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicFrameConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ConnectionShape? GetConnectionShape(RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>();
    if (itemElement != null)
      return ConnectionShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConnectionShape(RelativeAnchorSize? openXmlElement, ConnectionShape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Picture? GetPicture(RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>();
    if (itemElement != null)
      return PictureConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPicture(RelativeAnchorSize? openXmlElement, Picture? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? CreateModelElement(RelativeAnchorSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize();
      value.FromAnchor = GetFromAnchor(openXmlElement);
      value.ToAnchor = GetToAnchor(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.GroupShape = GetGroupShape(openXmlElement);
      value.GraphicFrame = GetGraphicFrame(openXmlElement);
      value.ConnectionShape = GetConnectionShape(openXmlElement);
      value.Picture = GetPicture(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? value)
    where OpenXmlElementType : RelativeAnchorSize, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFromAnchor(openXmlElement, value?.FromAnchor);
      SetToAnchor(openXmlElement, value?.ToAnchor);
      SetShape(openXmlElement, value?.Shape);
      SetGroupShape(openXmlElement, value?.GroupShape);
      SetGraphicFrame(openXmlElement, value?.GraphicFrame);
      SetConnectionShape(openXmlElement, value?.ConnectionShape);
      SetPicture(openXmlElement, value?.Picture);
      return openXmlElement;
    }
    return default;
  }
}