namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the size values for bubbles in a bubble chart, including references and literals.
/// </summary>
[OpenXmlType(typeof(DXDC.BubbleSize))]
public partial class BubbleSize: ModelElement<DXDC.BubbleSize>
{
  /// <summary>
  ///   Reference to the numeric values used for bubble sizes.
  /// </summary>
  public NumberReference? NumberReference
  {
    get => _NumberReference;
    set => UpdateField(ref _NumberReference, value, nameof(NumberReference));
  }
  private NumberReference? _NumberReference;
  /// <summary>
  ///   Literal numeric values for bubble sizes.
  /// </summary>
  public NumberLiteral? NumberLiteral
  {
    get => _NumberLiteral;
    set => UpdateField(ref _NumberLiteral, value, nameof(NumberLiteral));
  }
  private NumberLiteral? _NumberLiteral;
}