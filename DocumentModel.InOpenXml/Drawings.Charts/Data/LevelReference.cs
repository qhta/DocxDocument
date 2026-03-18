namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a reference to a level in a data source.
/// </summary>
[OpenXmlType(typeof(DXO13DC.LevelReference))]
public partial class LevelReference: ModelElement<DXO13DC.LevelReference>
{
  /// <summary>
  ///   Sequence of references defining the level data.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DC.LevelReference.SequenceOfReferences))]
  public string? SequenceOfReferences { get => _SequenceOfReferences; set => UpdateField(ref _SequenceOfReferences, value, nameof(SequenceOfReferences)); }

  private string? _SequenceOfReferences;
}