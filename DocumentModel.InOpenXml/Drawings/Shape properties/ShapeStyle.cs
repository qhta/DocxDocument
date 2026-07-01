namespace DocumentModel.Drawings;
/// <summary>
///   Represents a style for a shape, including references to line, fill, effect, and font formatting.
/// </summary>
[OpenXmlType(typeof(DXD.ShapeStyle))]
[DataContract]
[XmlRoot("ShapeStyle", Namespace = "DocumentModel.Drawings")]
public abstract partial class ShapeStyle<T> : ModelElement<T> where T : DX.OpenXmlElement
{
 /// <summary>
 ///   Reference to the line formatting for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeStyle.LineReference))]
 public LineReference? LineReference { get => _LineReference; set => UpdateField(ref _LineReference, value, nameof(LineReference)); }
 private LineReference? _LineReference;

 /// <summary>
 ///   Reference to the fill formatting for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeStyle.FillReference))]
 public FillReference? FillReference { get => _FillReference; set => UpdateField(ref _FillReference, value, nameof(FillReference)); }
 private FillReference? _FillReference;

 /// <summary>
 ///   Reference to the effect formatting for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeStyle.EffectReference))]
 public EffectReference? EffectReference { get => _EffectReference; set => UpdateField(ref _EffectReference, value, nameof(EffectReference)); }
 private EffectReference? _EffectReference;

 /// <summary>
 ///   Reference to the font formatting for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeStyle.FontReference))]
 public FontReference? FontReference { get => _FontReference; set => UpdateField(ref _FontReference, value, nameof(FontReference)); }
 private FontReference? _FontReference;
}

/// <summary>
/// Specifies DXD.ShapeStyle mapping type.
/// </summary>
[OpenXmlType(typeof(DXD.ShapeStyle))]
[DataContract]
[XmlRoot("ShapeStyle", Namespace = "DocumentModel.Drawings")]
public class ShapeStyle : ShapeStyle<DXD.ShapeStyle>
{
}