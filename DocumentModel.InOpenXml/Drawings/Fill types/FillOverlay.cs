namespace DocumentModel.Drawings;
/// <summary>
///   Fill Overlay Effect.
/// </summary>
[OpenXmlType(typeof(DXD.FillOverlay))]
public partial class FillOverlay : ModelElement<DXD.FillOverlay>
{
 /// <summary>
 ///   Blend
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillOverlay.Blend))]
 public BlendMode? Blend { get => _Blend; set => UpdateField(ref _Blend, value, nameof(Blend)); }
 private BlendMode? _Blend;
 /// <summary>
 ///   NoFill.
 /// </summary>
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }
 private Fill? _Fill;
}