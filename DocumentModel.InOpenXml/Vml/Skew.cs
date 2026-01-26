namespace DocumentModel.Vml;
/// <summary>
///   Skew Transform.
/// </summary>
[OpenXmlType(typeof(DXVO.Skew))]
public partial class Skew : ModelElement<DXVO.Skew>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Skew.Extension))]
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlElement(typeof(DXVO.Skew))]
 public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehaviorKind? _Extension;
 /// <summary>
 ///   Skew ID
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Skew.Id))]
 /// <summary>
 ///   Skew ID
 /// </summary>
 [OpenXmlElement(typeof(DXVO.Skew))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Skew Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Skew.On))]
 /// <summary>
 ///   Skew Toggle
 /// </summary>
 [OpenXmlElement(typeof(DXVO.Skew))]
 public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

 private bool? _On;
 /// <summary>
 ///   Skew Offset
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Skew.Offset))]
 /// <summary>
 ///   Skew Offset
 /// </summary>
 [OpenXmlElement(typeof(DXVO.Skew))]
 public string? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

 private string? _Offset;
 /// <summary>
 ///   Skew Origin
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Skew.Origin))]
 /// <summary>
 ///   Skew Origin
 /// </summary>
 [OpenXmlElement(typeof(DXVO.Skew))]
 public string? Origin { get => _Origin; set => UpdateField(ref _Origin, value, nameof(Origin)); }

 private string? _Origin;
 /// <summary>
 ///   Skew Perspective Matrix
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Skew.Matrix))]
 /// <summary>
 ///   Skew Perspective Matrix
 /// </summary>
 [OpenXmlElement(typeof(DXVO.Skew))]
 public string? Matrix { get => _Matrix; set => UpdateField(ref _Matrix, value, nameof(Matrix)); }

 private string? _Matrix;
}