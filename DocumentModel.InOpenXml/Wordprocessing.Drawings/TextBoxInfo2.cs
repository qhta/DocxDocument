namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents advanced information for a text box in a Wordprocessing document.
/// This class provides properties for identifying the text box, accessing its content, and managing associated OfficeArt extensions, enabling advanced text box configuration and extensibility.
/// </summary>
[OpenXmlType(typeof(DXO10WDS.TextBoxInfo2))]
public partial class TextBoxInfo2 : ModelElement<DXO10WDS.TextBoxInfo2>, DMD.IOfficeArtExtendableElement
{
 /// <summary>
 /// The unique identifier for the text box, used to distinguish it from other text boxes in the document.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.TextBoxInfo2.Id))]
 public UInt16? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private UInt16? _Id;
 /// <summary>
 /// The content of the text box, including text and formatting information.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.TextBoxInfo2.TextBoxContent))]
 public TextBoxContent? TextBoxContent { get => _TextBoxContent; set => UpdateField(ref _TextBoxContent, value, nameof(TextBoxContent)); }
 private TextBoxContent? _TextBoxContent;
 /// <summary>
 /// List of OfficeArt extensions associated with the text box, allowing for additional properties and behaviors to be defined.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.TextBoxInfo2.OfficeArtExtensionList))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
 private OfficeArtExtensionList? _OfficeArtExtensionList;
}