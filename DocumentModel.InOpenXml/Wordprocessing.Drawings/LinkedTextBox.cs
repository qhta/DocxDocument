namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a linked text box within a Wordprocessing document.
/// This class provides properties for identifying and sequencing linked text boxes, enabling the chaining of text across multiple text boxes for advanced text flow and layout scenarios.
/// </summary>
[OpenXmlType(typeof(DXO10WDS.LinkedTextBox))]
public partial class LinkedTextBox : ModelElement<DXO10WDS.LinkedTextBox>, DMD.IOfficeArtExtendableElement
{
 /// <summary>
 /// The unique identifier for the linked text box, used to distinguish it from other text boxes in the document.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.LinkedTextBox.Id))]
 public UInt16? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private UInt16? _Id;
 /// <summary>
 /// The sequence number of the linked text box, indicating its order in a chain of linked text boxes for text flow.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.LinkedTextBox.Sequence))]
 public UInt16? Sequence { get => _Sequence; set => UpdateField(ref _Sequence, value, nameof(Sequence)); }

 private UInt16? _Sequence;
 [OpenXmlProperty(nameof(DXO10WDS.LinkedTextBox.OfficeArtExtensionList))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}