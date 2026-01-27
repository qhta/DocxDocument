namespace DocumentModel.Drawings;
/// <summary>
///   Represents a style for a shape, including references to line, fill, effect, and font formatting.
/// </summary>
[OpenXmlType(typeof(DXD.ShapeStyle))]
public abstract partial class ShapeStyle<T>: ModelElement<T> where T : DX.OpenXmlElement
{
 /// <summary>
 ///   Reference to the line formatting for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeStyle.LineReference))]
 [OpenXmlElement(typeof(DXD.ShapeStyle))]
 public LineReference? LineReference { get => _LineReference; set => UpdateField(ref _LineReference, value, nameof(LineReference)); }

 private LineReference? _LineReference;
 /// <summary>
 ///   Reference to the fill formatting for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeStyle.FillReference))]
 [OpenXmlElement(typeof(DXD.ShapeStyle))]
 public FillReference? FillReference { get => _FillReference; set => UpdateField(ref _FillReference, value, nameof(FillReference)); }

 private FillReference? _FillReference;
 /// <summary>
 ///   Reference to the effect formatting for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeStyle.EffectReference))]
 [OpenXmlElement(typeof(DXD.ShapeStyle))]
 public EffectReference? EffectReference { get => _EffectReference; set => UpdateField(ref _EffectReference, value, nameof(EffectReference)); }

 private EffectReference? _EffectReference;
 /// <summary>
 ///   Reference to the font formatting for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeStyle.FontReference))]
 [OpenXmlElement(typeof(DXD.ShapeStyle))]
 public FontReference? FontReference { get => _FontReference; set => UpdateField(ref _FontReference, value, nameof(FontReference)); }

 private FontReference? _FontReference;
}

/// <summary>
/// Specifies DXD.ShapeStyle mapping type.
/// </summary>
public class ShapeStyle : ShapeStyle<DXD.ShapeStyle>
{
}