namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the Y values for a chart series, including references and literals.
/// </summary>
[OpenXmlType(typeof(DXDC.YValues))]
public partial class YValues : ModelElement<DXDC.YValues>
{
  /// <summary>
  ///   Reference to the numeric values used for Y values.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.YValues.NumberReference))]
  public NumberReference? NumberReference { get => _NumberReference; set => UpdateField(ref _NumberReference, value, nameof(NumberReference)); }

  private NumberReference? _NumberReference;

  /// <summary>
  ///   Literal numeric values for Y values.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.YValues.NumberLiteral))]
  public NumberLiteral? NumberLiteral { get => _NumberLiteral; set => UpdateField(ref _NumberLiteral, value, nameof(NumberLiteral)); }

  private NumberLiteral? _NumberLiteral;
}