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
  public AdjustValueList? AdjustValueList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  public ShapeGuideList? ShapeGuideList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  public AdjustHandleList? AdjustHandleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  public ConnectionSiteList? ConnectionSiteList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  public Rectangle? Rectangle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  public PathList? PathList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
