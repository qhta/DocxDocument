namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Represents a linked text box within a WordprocessingML document, enabling the chaining of text across multiple text boxes for advanced text flow and layout scenarios.
///   Provides properties for identifying and sequencing linked text boxes, as well as extension data for OfficeArt compatibility.
/// </summary>
[OpenXmlType(typeof(DXO10WDS.LinkedTextBox))]
public partial class LinkedTextBox : ModelElement<DXO10WDS.LinkedTextBox>, DMD.IOfficeArtExtendableElement
{
  /// <summary>
  ///   Unique identifier for the linked text box, distinguishing it from other text boxes in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10WDS.LinkedTextBox.Id))]
  public UInt16? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private UInt16? _Id;
  /// <summary>
  ///   Sequence number of the linked text box, indicating its order in a chain of linked text boxes for text flow.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10WDS.LinkedTextBox.Sequence))]
  public UInt16? Sequence { get => _Sequence; set => UpdateField(ref _Sequence, value, nameof(Sequence)); }
  private UInt16? _Sequence;
  /// <summary>
  ///   List of OfficeArt extension elements for the linked text box, allowing for future extensibility and application-specific data.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10WDS.LinkedTextBox.OfficeArtExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
  private OfficeArtExtensionList? _OfficeArtExtensionList;
}
