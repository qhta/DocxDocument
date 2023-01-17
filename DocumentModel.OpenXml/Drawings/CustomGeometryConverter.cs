namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Custom geometry.
/// </summary>
public static class CustomGeometryConverter
{
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  private static DocumentModel.Drawings.AdjustValueList? GetAdjustValueList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustValueListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAdjustValueList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement, DocumentModel.Drawings.AdjustValueList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AdjustValueListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustValueList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  private static DocumentModel.Drawings.ShapeGuideList? GetShapeGuideList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeGuideList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapeGuideListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeGuideList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement, DocumentModel.Drawings.ShapeGuideList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeGuideList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ShapeGuideListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeGuideList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  private static DocumentModel.Drawings.AdjustHandleList? GetAdjustHandleList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustHandleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAdjustHandleList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement, DocumentModel.Drawings.AdjustHandleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AdjustHandleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustHandleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  private static DocumentModel.Drawings.ConnectionSiteList? GetConnectionSiteList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionSiteList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ConnectionSiteListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConnectionSiteList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement, DocumentModel.Drawings.ConnectionSiteList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionSiteList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ConnectionSiteListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectionSiteList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  private static DocumentModel.Drawings.Rectangle? GetRectangle(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRectangle(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement, DocumentModel.Drawings.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.RectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  private static DocumentModel.Drawings.PathList? GetPathList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PathListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPathList(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement, DocumentModel.Drawings.PathList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PathListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PathList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.CustomGeometry? CreateModelElement(DocumentFormat.OpenXml.Drawing.CustomGeometry? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.CustomGeometry, new()
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
