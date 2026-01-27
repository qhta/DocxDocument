namespace DocumentModel.Vml;

/// <summary>
///   Shape Grouping History.
/// </summary>
[OpenXmlType(typeof(DXVO.RegroupTable))]
public partial class RegroupTable: ModelElement<DXVO.RegroupTable>
{
  /// <summary>
  ///   Specifies how VML extension elements are handled during processing.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.RegroupTable.Extension))]
  public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

  private ExtensionHandlingBehaviorKind? _Extension;

  /// <summary>
  ///   Contains the collection of regrouping history entries for shape groups.
  /// </summary>
  public Entries? Entries { get => _Entries; set => UpdateField(ref _Entries, value, nameof(Entries)); }

  private Entries? _Entries;
}