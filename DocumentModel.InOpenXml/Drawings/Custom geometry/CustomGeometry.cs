namespace DocumentModel.Drawings;
/// <summary>
///   Represents custom geometry for a shape, including adjustment values, guides, handles, connection sites, text rectangle, and paths.
/// </summary>
[OpenXmlType(typeof(DXD.CustomGeometry))]
public partial class CustomGeometry : ModelElement<DXD.CustomGeometry>
{
 /// <summary>
 ///   List of adjustment values for the custom geometry.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomGeometry.AdjustValueList))]
 public AdjustValueList? AdjustValueList { get => _AdjustValueList; set => UpdateField(ref _AdjustValueList, value, nameof(AdjustValueList)); }
 private AdjustValueList? _AdjustValueList;
 /// <summary>
 ///   List of shape guides used to define geometry.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomGeometry.ShapeGuideList))]
 public ShapeGuideList? ShapeGuideList { get => _ShapeGuideList; set => UpdateField(ref _ShapeGuideList, value, nameof(ShapeGuideList)); }
 private ShapeGuideList? _ShapeGuideList;
 /// <summary>
 ///   List of shape adjust handles for interactive adjustments.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomGeometry.AdjustHandleList))]
 public AdjustHandleList? AdjustHandleList { get => _AdjustHandleList; set => UpdateField(ref _AdjustHandleList, value, nameof(AdjustHandleList)); }
 private AdjustHandleList? _AdjustHandleList;
 /// <summary>
 ///   List of connection sites for attaching connectors.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomGeometry.ConnectionSiteList))]
 public ConnectionSiteList? ConnectionSiteList { get => _ConnectionSiteList; set => UpdateField(ref _ConnectionSiteList, value, nameof(ConnectionSiteList)); }
 private ConnectionSiteList? _ConnectionSiteList;
 /// <summary>
 ///   Rectangle that defines the text area within the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomGeometry.Rectangle))]
 public Rectangle? Rectangle { get => _Rectangle; set => UpdateField(ref _Rectangle, value, nameof(Rectangle)); }
 private Rectangle? _Rectangle;
 /// <summary>
 ///   List of paths that describe the outline of the custom geometry.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomGeometry.PathList))]
 public PathList? PathList { get => _PathList; set => UpdateField(ref _PathList, value, nameof(PathList)); }
 private PathList? _PathList;
}