namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic light screen effect, which simulates a grid-like light screen with adjustable transparency and grid size.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticLightScreen))]
public partial class ArtisticLightScreen : ModelElement<DXO10D.ArtisticLightScreen>
{
 /// <summary>
 /// Transparency level of the light screen effect.
 /// </summary>
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

 private Int32? _Transparency;
 /// <summary>
 /// Size of the grid in the light screen effect, influencing the pattern's appearance.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticLightScreen.GridSize))]
 public Int32? GridSize { get => _GridSize; set => UpdateField(ref _GridSize, value, nameof(GridSize)); }

 private Int32? _GridSize;
}