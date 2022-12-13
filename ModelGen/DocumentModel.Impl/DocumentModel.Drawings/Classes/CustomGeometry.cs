namespace DocumentModel.Drawings;

/// <summary>
/// Custom geometry.
/// </summary>
public class CustomGeometryImpl: ModelElementImpl, CustomGeometry
{
  public DocumentFormat.OpenXml.Drawing.CustomGeometry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CustomGeometry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomGeometryImpl(): base() {}
  
  public CustomGeometryImpl(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  public DocumentModel.Drawings.ShapeGuideList? ShapeGuideList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  public DocumentModel.Drawings.AdjustHandleList? AdjustHandleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  public DocumentModel.Drawings.ConnectionSiteList? ConnectionSiteList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  public DocumentModel.Drawings.Rectangle? Rectangle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  public DocumentModel.Drawings.PathList? PathList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
