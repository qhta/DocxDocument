namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a glossary document entry (DocPart) in a WordprocessingML document.
/// This class extends <see cref = "DMPack.OpenXmlPart"/> and provides properties for entry properties and content, enabling advanced management, organization, and reuse of document parts such as building blocks, autotext, and other glossary entries.
/// </summary>
[OpenXmlType(typeof(DXW.DocPart))]
public partial class DocPart : ModelElement<DXW.DocPart>
{
 /// <summary>
 /// Properties of the glossary document entry, specifying metadata and configuration for the entry.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPart.DocPartProperties))]
 public DocPartProperties? DocPartProperties { get => _DocPartProperties; set => UpdateField(ref _DocPartProperties, value, nameof(DocPartProperties)); }
 private DocPartProperties? _DocPartProperties;
 /// <summary>
 /// Contents of the glossary document entry, containing the actual content or body of the entry.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPart.DocPartBody))]
 public DocPartBody? DocPartBody { get => _DocPartBody; set => UpdateField(ref _DocPartBody, value, nameof(DocPartBody)); }
 private DocPartBody? _DocPartBody;
}