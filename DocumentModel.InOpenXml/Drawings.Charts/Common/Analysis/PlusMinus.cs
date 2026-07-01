namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Plus or Minus base class.
/// </summary>
[DataContract]
[XmlRoot("PlusMinus", Namespace = "DocumentModel.Drawings.Charts")]
public abstract partial class PlusMinus<T> : ModelElement<T> where T : DX.OpenXmlElement
{
 /// <summary>
 /// NumberReference to a cell range containing numeric values that define the positive or negative error range for the error bars.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.NumberReference))]
 public NumberReference? NumberReference { get => _NumberReference; set => UpdateField(ref _NumberReference, value, nameof(NumberReference)); }
 private NumberReference? _NumberReference;

 /// <summary>
 /// Numeric literal values provided directly for the positive or negative error range of the error bars.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.NumberLiteral))]
 public NumberLiteral? NumberLiteral { get => _NumberLiteral; set => UpdateField(ref _NumberLiteral, value, nameof(NumberLiteral)); }
 private NumberLiteral? _NumberLiteral;
}