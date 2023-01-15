using DocumentModel.Drawings;
using CustomGeometry = DocumentFormat.OpenXml.Drawing.CustomGeometry;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Custom geometry.
/// </summary>
public static class CustomGeometryConverter
{
  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  public static AdjustValueList? GetAdjustValueList(CustomGeometry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
    if (itemElement != null)
      return AdjustValueListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAdjustValueList(CustomGeometry? openXmlElement, AdjustValueList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustValueListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustValueList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List of Shape Guides.
  /// </summary>
  public static ShapeGuideList? GetShapeGuideList(CustomGeometry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeGuideList>();
    if (itemElement != null)
      return ShapeGuideListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeGuideList(CustomGeometry? openXmlElement, ShapeGuideList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeGuideList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeGuideListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeGuideList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List of Shape Adjust Handles.
  /// </summary>
  public static AdjustHandleList? GetAdjustHandleList(CustomGeometry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleList>();
    if (itemElement != null)
      return AdjustHandleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAdjustHandleList(CustomGeometry? openXmlElement, AdjustHandleList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustHandleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustHandleList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List of Shape Connection Sites.
  /// </summary>
  public static ConnectionSiteList? GetConnectionSiteList(CustomGeometry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionSiteList>();
    if (itemElement != null)
      return ConnectionSiteListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConnectionSiteList(CustomGeometry? openXmlElement, ConnectionSiteList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionSiteList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionSiteListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectionSiteList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape Text Rectangle.
  /// </summary>
  public static Rectangle? GetRectangle(CustomGeometry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rectangle>();
    if (itemElement != null)
      return RectangleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRectangle(CustomGeometry? openXmlElement, Rectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Rectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List of Shape Paths.
  /// </summary>
  public static PathList? GetPathList(CustomGeometry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathList>();
    if (itemElement != null)
      return PathListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPathList(CustomGeometry? openXmlElement, PathList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PathListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PathList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.CustomGeometry? CreateModelElement(CustomGeometry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CustomGeometry();
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      value.ShapeGuideList = GetShapeGuideList(openXmlElement);
      value.AdjustHandleList = GetAdjustHandleList(openXmlElement);
      value.ConnectionSiteList = GetConnectionSiteList(openXmlElement);
      value.Rectangle = GetRectangle(openXmlElement);
      value.PathList = GetPathList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CustomGeometry? value)
    where OpenXmlElementType : CustomGeometry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAdjustValueList(openXmlElement, value?.AdjustValueList);
      SetShapeGuideList(openXmlElement, value?.ShapeGuideList);
      SetAdjustHandleList(openXmlElement, value?.AdjustHandleList);
      SetConnectionSiteList(openXmlElement, value?.ConnectionSiteList);
      SetRectangle(openXmlElement, value?.Rectangle);
      SetPathList(openXmlElement, value?.PathList);
      return openXmlElement;
    }
    return default;
  }
}