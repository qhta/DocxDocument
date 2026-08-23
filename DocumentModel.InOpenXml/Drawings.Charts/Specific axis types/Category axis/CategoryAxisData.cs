namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the data for a category axis, including multi-level string references, number references, literals, and string references.
/// </summary>
[OpenXmlType(typeof(DXDC.CategoryAxisData))]
[DataContract]
[XmlRoot("CategoryAxisData", Namespace = "DocumentModel.Drawings.Charts")]
public partial class CategoryAxisData: ModelElement<DXDC.CategoryAxisData>
{
  /// <summary>
  ///   Multi-level string reference for category axis data.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.MultiLevelStringReference))]
  public MultiLevelStringReference? MultiLevelStringReference
  {
    get => _MultiLevelStringReference ??=
      GetElement<MultiLevelStringReference, DXDC.MultiLevelStringReference>(GetUpdatableElement());
    set => UpdateField(ref _MultiLevelStringReference, value, nameof(MultiLevelStringReference));
  }

  private MultiLevelStringReference? _MultiLevelStringReference;

  /// <summary>
  ///   Reference to the numeric values used for category axis data.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.NumberReference))]
  public NumberReference? NumberReference
  {
    get => _NumberReference ??= GetElement<NumberReference, DXDC.NumberReference>(GetUpdatableElement());
    set => UpdateField(ref _NumberReference, value, nameof(NumberReference));
  }

  private NumberReference? _NumberReference;

  /// <summary>
  ///   Literal numeric values for category axis data.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.NumberLiteral))]
  public NumberLiteral? NumberLiteral
  {
    get => _NumberLiteral ??= GetElement<NumberLiteral, DXDC.NumberLiteral>(GetUpdatableElement());
    set => UpdateField(ref _NumberLiteral, value, nameof(NumberLiteral));
  }

  private NumberLiteral? _NumberLiteral;

  /// <summary>
  ///   Reference to the string values used for category axis data.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.StringReference))]
  public StringReference? StringReference
  {
    get => _StringReference ??= GetElement<StringReference, DXDC.StringReference>(GetUpdatableElement());
    set => UpdateField(ref _StringReference, value, nameof(StringReference));
  }

  private StringReference? _StringReference;

  /// <summary>
  ///   Literal string values for category axis data.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.StringLiteral))]
  public StringLiteral? StringLiteral
  {
    get => _StringLiteral ??= GetElement<StringLiteral, DXDC.StringLiteral>(GetUpdatableElement());
    set => UpdateField(ref _StringLiteral, value, nameof(StringLiteral));
  }

  private StringLiteral? _StringLiteral;
}