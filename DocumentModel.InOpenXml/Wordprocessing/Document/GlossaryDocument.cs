namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the root element of a glossary document in a WordprocessingML document.
///   This class provides properties for the document background and the list of glossary document entries, enabling advanced management, organization, and reuse of building blocks, autotext, and other reusable document content.
/// </summary>
[OpenXmlType(typeof(DXW.GlossaryDocument))]
[DataContract]
[XmlRoot("GlossaryDocument", Namespace = "DocumentModel.Wordprocessing")]
public partial class GlossaryDocument : ModelElement<DXW.GlossaryDocument>
{
  /// <summary>
  ///   Document background, specifying the image or fill for every page of the glossary document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.GlossaryDocument.DocumentBackground))]
  public DocumentBackground? DocumentBackground { get => _DocumentBackground ??= GetProperty<DocumentBackground?>(GetUpdatableElement()?.DocumentBackground); set => UpdateField(ref _DocumentBackground, value, nameof(DocumentBackground)); }
  private DocumentBackground? _DocumentBackground;

  /// <summary>
  ///   List of glossary document entries, providing access to and management of reusable document parts.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.GlossaryDocument.DocParts))]
  public DocParts? DocParts { get => _DocParts ??= GetProperty<DocParts?>(GetUpdatableElement()?.DocParts); set => UpdateField(ref _DocParts, value, nameof(DocParts)); }
  private DocParts? _DocParts;
}