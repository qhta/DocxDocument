namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MinorTickMarksTickMarks Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.MinorTickMarksTickMarks))]
[XmlRoot("MinorTickMarksTickMarks", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class MinorTickMarksTickMarks : ModelElement<DXO16DCD.MinorTickMarksTickMarks>
{
 /// <summary>
 /// Specifies the extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.MinorTickMarksTickMarks.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}