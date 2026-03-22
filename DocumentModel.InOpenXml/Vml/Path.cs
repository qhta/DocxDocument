namespace DocumentModel.Vml;
/// <summary>
///   Defines the Path Class.
/// </summary>
[OpenXmlType(typeof(DXV.Path))]
public partial class Path : ModelElement<DXV.Path>
{
 /// <summary>
 ///   Unique Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private string? _Id;
 /// <summary>
 ///   Path Definition
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.Value))]
 public string? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }
 private string? _Value;
 /// <summary>
 ///   Limo Stretch Point
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.Limo))]
 public string? Limo { get => _Limo; set => UpdateField(ref _Limo, value, nameof(Limo)); }
 private string? _Limo;
 /// <summary>
 ///   Text Box Bounding Box
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.TextboxRectangle))]
 public string? TextboxRectangle { get => _TextboxRectangle; set => UpdateField(ref _TextboxRectangle, value, nameof(TextboxRectangle)); }
 private string? _TextboxRectangle;
 /// <summary>
 ///   Shape Fill Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.AllowFill))]
 public bool? AllowFill { get => _AllowFill; set => UpdateField(ref _AllowFill, value, nameof(AllowFill)); }
 private bool? _AllowFill;
 /// <summary>
 ///   Stroke Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.AllowStroke))]
 public bool? AllowStroke { get => _AllowStroke; set => UpdateField(ref _AllowStroke, value, nameof(AllowStroke)); }
 private bool? _AllowStroke;
 /// <summary>
 ///   Shadow Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.AllowShading))]
 public bool? AllowShading { get => _AllowShading; set => UpdateField(ref _AllowShading, value, nameof(AllowShading)); }
 private bool? _AllowShading;
 /// <summary>
 ///   Arrowhead Display Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.ShowArrowhead))]
 public bool? ShowArrowhead { get => _ShowArrowhead; set => UpdateField(ref _ShowArrowhead, value, nameof(ShowArrowhead)); }
 private bool? _ShowArrowhead;
 /// <summary>
 ///   Gradient Shape Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.AllowGradientShape))]
 public bool? AllowGradientShape { get => _AllowGradientShape; set => UpdateField(ref _AllowGradientShape, value, nameof(AllowGradientShape)); }
 private bool? _AllowGradientShape;
 /// <summary>
 ///   Text Path Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.AllowTextPath))]
 public bool? AllowTextPath { get => _AllowTextPath; set => UpdateField(ref _AllowTextPath, value, nameof(AllowTextPath)); }
 private bool? _AllowTextPath;
 /// <summary>
 ///   Inset Stroke From Path Flag
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.AllowInsetPen))]
 public bool? AllowInsetPen { get => _AllowInsetPen; set => UpdateField(ref _AllowInsetPen, value, nameof(AllowInsetPen)); }
 private bool? _AllowInsetPen;
 /// <summary>
 ///   Connection Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.ConnectionPointType))]
 public ConnectType? ConnectionPointType { get => _ConnectionPointType; set => UpdateField(ref _ConnectionPointType, value, nameof(ConnectionPointType)); }
 private ConnectType? _ConnectionPointType;
 /// <summary>
 ///   Connection Points
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.ConnectionPoints))]
 public string? ConnectionPoints { get => _ConnectionPoints; set => UpdateField(ref _ConnectionPoints, value, nameof(ConnectionPoints)); }
 private string? _ConnectionPoints;
 /// <summary>
 ///   Connection Point Connect Angles
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.ConnectAngles))]
 public string? ConnectAngles { get => _ConnectAngles; set => UpdateField(ref _ConnectAngles, value, nameof(ConnectAngles)); }
 private string? _ConnectAngles;
 /// <summary>
 ///   Extrusion Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Path.AllowExtrusion))]
 public bool? AllowExtrusion { get => _AllowExtrusion; set => UpdateField(ref _AllowExtrusion, value, nameof(AllowExtrusion)); }
 private bool? _AllowExtrusion;
}