namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the fill text effect for a text run, providing options for no fill, solid color fill, or gradient fill.
/// This class enables advanced text fill formatting in WordprocessingML documents.
/// </summary>
[OpenXmlType(typeof(DXO10W.FillTextEffect))]
[XmlRoot("FillTextEffect", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class FillTextEffect : ModelElement<DXO10W.FillTextEffect>
{
 /// <summary>
 /// Indicates that no fill is applied to the text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.FillTextEffect.NoFillEmpty))]
 public bool? NoFillEmpty { get => _NoFillEmpty; set => UpdateField(ref _NoFillEmpty, value, nameof(NoFillEmpty)); }

 private bool? _NoFillEmpty;
 /// <summary>
 /// Solid color fill properties for the text, specifying a single color fill effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.FillTextEffect.SolidColorFillProperties))]
 public SolidColorFillProperties? SolidColorFillProperties { get => _SolidColorFillProperties; set => UpdateField(ref _SolidColorFillProperties, value, nameof(SolidColorFillProperties)); }

 private SolidColorFillProperties? _SolidColorFillProperties;
 /// <summary>
 /// Gradient fill properties for the text, specifying a gradient color fill effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.FillTextEffect.GradientFillProperties))]
 public GradientFillProperties? GradientFillProperties { get => _GradientFillProperties; set => UpdateField(ref _GradientFillProperties, value, nameof(GradientFillProperties)); }

 private GradientFillProperties? _GradientFillProperties;
}