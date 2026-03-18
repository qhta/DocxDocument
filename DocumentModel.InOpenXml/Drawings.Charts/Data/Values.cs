namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the values for a chart series.
///   This class defines the data source for the values, which can be either a reference to a range or a set of literal values.
/// </summary>
[OpenXmlType(typeof(DXDC.Values))]
public partial class Values: ModelElement<DXDC.Values>
{
  /// <summary>
  ///   Reference to a numeric data source.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Values.NumberReference))]
  public NumberReference? NumberReference
  {
    get => _NumberReference;
    set => UpdateField(ref _NumberReference, value, nameof(NumberReference));
  }

  private NumberReference? _NumberReference;

  /// <summary>
  ///   Literal numeric values provided directly.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Values.NumberLiteral))]
  public NumberLiteral? NumberLiteral
  {
    get => _NumberLiteral;
    set => UpdateField(ref _NumberLiteral, value, nameof(NumberLiteral));
  }

  private NumberLiteral? _NumberLiteral;
}