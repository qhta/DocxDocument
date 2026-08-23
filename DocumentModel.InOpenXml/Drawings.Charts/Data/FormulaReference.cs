namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a formula reference to a data source.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FormulaReference))]
[DataContract]
[XmlRoot("FormulaReference", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FormulaReference: ModelElement<DXO13DC.FormulaReference>
{
  /// <summary>
  ///   Sequence of references defined by the formula.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DC.FormulaReference.SequenceOfReferences))]
  public string? SequenceOfReferences
  {
    get => _SequenceOfReferences ??= GetProperty<string?>(GetUpdatableElement()?.SequenceOfReferences);
    set => UpdateField(ref _SequenceOfReferences, value, nameof(SequenceOfReferences));
  }

  private string? _SequenceOfReferences;
}