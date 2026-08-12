namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MajorTickMarksTickMarks Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.MajorTickMarksTickMarks))]
[DataContract]
[XmlRoot("MajorTickMarksTickMarks", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class MajorTickMarksTickMarks : ModelElement<DXO16DCD.MajorTickMarksTickMarks>
{
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MajorTickMarksTickMarks.ExtensionList))]
  public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private IExtensionList? _ExtensionList;
}