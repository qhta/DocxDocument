namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MajorTickMarksTickMarks Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.MajorTickMarksTickMarks))]
[XmlRoot("MajorTickMarksTickMarks", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class MajorTickMarksTickMarks : ModelElement<DXO16DCD.MajorTickMarksTickMarks>
{
 /// <summary>
 /// Specifies the extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.MajorTickMarksTickMarks.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}