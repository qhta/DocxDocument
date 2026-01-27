namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic film grain effect, which simulates the appearance of film grain with adjustable transparency and grain size.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticFilmGrain))]
public partial class ArtisticFilmGrain : ModelElement<DXO10D.ArtisticFilmGrain>
{
 /// <summary>
 /// Transparency level of the film grain effect.
 /// </summary>
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

 private Int32? _Transparency;
 /// <summary>
 /// Size of the grain in the film grain effect, influencing the texture's coarseness.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticFilmGrain.GrainSize))]
 public Int32? GrainSize { get => _GrainSize; set => UpdateField(ref _GrainSize, value, nameof(GrainSize)); }

 private Int32? _GrainSize;
}