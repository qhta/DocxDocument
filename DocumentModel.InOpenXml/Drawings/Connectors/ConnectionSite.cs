namespace DocumentModel.Drawings;
/// <summary>
/// Represents a shape connection site, defining the angle and position where a connector attaches to a shape.
/// </summary>
[OpenXmlType(typeof(DXD.ConnectionSite))]
public partial class ConnectionSite : ModelElement<DXD.ConnectionSite>
{
 /// <summary>
 /// Angle of the connection site.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionSite.Angle))]
 public string? Angle { get => _Angle; set => UpdateField(ref _Angle, value, nameof(Angle)); }

 private string? _Angle;
 /// <summary>
 /// Position of the connection site as a two-dimensional adjustment point.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionSite.Position))]
 public AdjustPoint2DType? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

 private AdjustPoint2DType? _Position;
}