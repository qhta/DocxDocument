namespace DocumentModel.Vml;
/// <summary>
///   Defines the fill properties of a shape.
/// </summary>
[OpenXmlType(typeof(DXV.Fill))]
public partial class Fill : ModelElement<DXV.Fill>
{
 /// <summary>
 ///   Unique Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Id))]
 /// <summary>
 ///   Unique Identifier
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Fill Type
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Type))]
 /// <summary>
 ///   Fill Type
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public FillTypeKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private FillTypeKind? _Type;
 /// <summary>
 ///   Fill Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.On))]
 /// <summary>
 ///   Fill Toggle
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

 private bool? _On;
 /// <summary>
 ///   Primary Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Color))]
 /// <summary>
 ///   Primary Color
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

 private string? _Color;
 /// <summary>
 ///   Primary Color Opacity
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Opacity))]
 /// <summary>
 ///   Primary Color Opacity
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Opacity { get => _Opacity; set => UpdateField(ref _Opacity, value, nameof(Opacity)); }

 private string? _Opacity;
 /// <summary>
 ///   Secondary Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Color2))]
 /// <summary>
 ///   Secondary Color
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Color2 { get => _Color2; set => UpdateField(ref _Color2, value, nameof(Color2)); }

 private string? _Color2;
 /// <summary>
 ///   Fill Image Source
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Source))]
 /// <summary>
 ///   Fill Image Source
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Source { get => _Source; set => UpdateField(ref _Source, value, nameof(Source)); }

 private string? _Source;
 /// <summary>
 ///   IHyperlink Target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Href))]
 /// <summary>
 ///   IHyperlink Target
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

 private string? _Href;
 /// <summary>
 ///   Alternate Image Reference Location
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.AlternateImageReference))]
 /// <summary>
 ///   Alternate Image Reference Location
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? AlternateImageReference { get => _AlternateImageReference; set => UpdateField(ref _AlternateImageReference, value, nameof(AlternateImageReference)); }

 private string? _AlternateImageReference;
 /// <summary>
 ///   Fill Image Size
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Size))]
 /// <summary>
 ///   Fill Image Size
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Size { get => _Size; set => UpdateField(ref _Size, value, nameof(Size)); }

 private string? _Size;
 /// <summary>
 ///   Fill Image Origin
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Origin))]
 /// <summary>
 ///   Fill Image Origin
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Origin { get => _Origin; set => UpdateField(ref _Origin, value, nameof(Origin)); }

 private string? _Origin;
 /// <summary>
 ///   Fill Image Position
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Position))]
 /// <summary>
 ///   Fill Image Position
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

 private string? _Position;
 /// <summary>
 ///   Image Aspect Ratio
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Aspect))]
 /// <summary>
 ///   Image Aspect Ratio
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public ImageAspectKind? Aspect { get => _Aspect; set => UpdateField(ref _Aspect, value, nameof(Aspect)); }

 private ImageAspectKind? _Aspect;
 /// <summary>
 ///   Intermediate Colors
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Colors))]
 /// <summary>
 ///   Intermediate Colors
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Colors { get => _Colors; set => UpdateField(ref _Colors, value, nameof(Colors)); }

 private string? _Colors;
 /// <summary>
 ///   Gradient Angle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Angle))]
 /// <summary>
 ///   Gradient Angle
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public Decimal? Angle { get => _Angle; set => UpdateField(ref _Angle, value, nameof(Angle)); }

 private Decimal? _Angle;
 /// <summary>
 ///   Align Image With Shape
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.AlignShape))]
 /// <summary>
 ///   Align Image With Shape
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public bool? AlignShape { get => _AlignShape; set => UpdateField(ref _AlignShape, value, nameof(AlignShape)); }

 private bool? _AlignShape;
 /// <summary>
 ///   Gradient Center
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Focus))]
 /// <summary>
 ///   Gradient Center
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Focus { get => _Focus; set => UpdateField(ref _Focus, value, nameof(Focus)); }

 private string? _Focus;
 /// <summary>
 ///   Radial Gradient Size
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.FocusSize))]
 /// <summary>
 ///   Radial Gradient Size
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? FocusSize { get => _FocusSize; set => UpdateField(ref _FocusSize, value, nameof(FocusSize)); }

 private string? _FocusSize;
 /// <summary>
 ///   Radial Gradient Center
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.FocusPosition))]
 /// <summary>
 ///   Radial Gradient Center
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? FocusPosition { get => _FocusPosition; set => UpdateField(ref _FocusPosition, value, nameof(FocusPosition)); }

 private string? _FocusPosition;
 /// <summary>
 ///   Gradient Fill Method
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Method))]
 /// <summary>
 ///   Gradient Fill Method
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public FillMethodKind? Method { get => _Method; set => UpdateField(ref _Method, value, nameof(Method)); }

 private FillMethodKind? _Method;
 /// <summary>
 ///   Detect Mouse Click
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.DetectMouseClick))]
 /// <summary>
 ///   Detect Mouse Click
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public bool? DetectMouseClick { get => _DetectMouseClick; set => UpdateField(ref _DetectMouseClick, value, nameof(DetectMouseClick)); }

 private bool? _DetectMouseClick;
 /// <summary>
 ///   Title
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Title))]
 /// <summary>
 ///   Title
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

 private string? _Title;
 /// <summary>
 ///   Secondary Color Opacity
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Opacity2))]
 /// <summary>
 ///   Secondary Color Opacity
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? Opacity2 { get => _Opacity2; set => UpdateField(ref _Opacity2, value, nameof(Opacity2)); }

 private string? _Opacity2;
 /// <summary>
 ///   Recolor Fill as Picture
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Recolor))]
 /// <summary>
 ///   Recolor Fill as Picture
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public bool? Recolor { get => _Recolor; set => UpdateField(ref _Recolor, value, nameof(Recolor)); }

 private bool? _Recolor;
 /// <summary>
 ///   Rotate Fill with Shape
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.Rotate))]
 /// <summary>
 ///   Rotate Fill with Shape
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public bool? Rotate { get => _Rotate; set => UpdateField(ref _Rotate, value, nameof(Rotate)); }

 private bool? _Rotate;
 /// <summary>
 ///   Relationship to Part
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.RelationshipId))]
 /// <summary>
 ///   Relationship to Part
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public string? RelationshipId { get => _RelationshipId; set => UpdateField(ref _RelationshipId, value, nameof(RelationshipId)); }

 private string? _RelationshipId;
 /// <summary>
 ///   FillExtendedProperties.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Fill.FillExtendedProperties))]
 /// <summary>
 ///   FillExtendedProperties.
 /// </summary>
 [OpenXmlElement(typeof(DXV.Fill))]
 public FillExtendedProperties? FillExtendedProperties { get => _FillExtendedProperties; set => UpdateField(ref _FillExtendedProperties, value, nameof(FillExtendedProperties)); }

 private FillExtendedProperties? _FillExtendedProperties;
}