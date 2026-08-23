namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MinorTickMarksTickMarks Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.MinorTickMarksTickMarks))]
[DataContract]
[XmlRoot("MinorTickMarksTickMarks", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class MinorTickMarksTickMarks: ModelElement<DXO16DCD.MinorTickMarksTickMarks>
{
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MinorTickMarksTickMarks.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}