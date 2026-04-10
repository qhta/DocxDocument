namespace DocumentModel.Math;
/// <summary>
///   This element specifies the fraction object, consisting of a numerator and denominator separated by a fraction bar. 
///   The fraction bar can be horizontal or diagonal, depending on the fraction properties. 
///   The fraction object is also used to represent the stack function, which places one element above another, with no fraction bar. .
/// </summary>
[OpenXmlType(typeof(DXM.Fraction))]
[XmlRoot("Fraction", Namespace = "DocumentModel.Math")]
public partial class Fraction : ModelElement<DXM.Fraction>, ICommonMathContent
{
 /// <summary>
 ///   Fraction Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Fraction.FractionProperties))]
 public FractionProperties? FractionProperties { get => _FractionProperties; set => UpdateField(ref _FractionProperties, value, nameof(FractionProperties)); }

 private FractionProperties? _FractionProperties;
 /// <summary>
 ///   Numerator.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Fraction.Numerator))]
 public Numerator? Numerator { get => _Numerator; set => UpdateField(ref _Numerator, value, nameof(Numerator)); }

 private Numerator? _Numerator;
 /// <summary>
 ///   Denominator.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Fraction.Denominator))]
 public Denominator? Denominator { get => _Denominator; set => UpdateField(ref _Denominator, value, nameof(Denominator)); }

 private Denominator? _Denominator;
}