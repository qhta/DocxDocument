namespace DocumentModel;
/// <summary>
///   Represents an alternate content container that provides multiple rendering options with a fallback mechanism.
/// </summary>
/// <remarks>
///   This class defines an alternate content structure that enables
///   documents to specify multiple ways of representing the same content, with each option tailored for different
///   application versions, features, or rendering capabilities. The alternate content mechanism is fundamental to
///   Office's forward compatibility strategy, allowing documents created with newer Office versions to remain
///   functional when opened in older versions that may not support all features. The structure consists of a
///   collection of choices (<see cref = "Choices"/>), where each choice is associated with specific requirements
///   (such as namespace support or feature availability), and a fallback option (<see cref = "Fallback"/>) that
///   provides a simplified or alternative representation when none of the choices can be satisfied. When an
///   application processes alternate content, it evaluates each choice in order, selecting the first one whose
///   requirements are met. If no choice is suitable, the fallback content is used. This mechanism enables
///   graceful degradation, where documents with advanced features (such as 3D models, advanced charts, or
///   new content types) can still be opened and edited in older Office versions that display the fallback
///   representation instead. Common scenarios include providing both new and legacy representations of content,
///   offering high-fidelity and simplified versions, or supporting different rendering engines with appropriate
///   content variants.
/// </remarks>
[DataContract]
[XmlRoot("AlternateContent", Namespace = "DocumentModel")]
public partial class AlternateContent : ModelElement
{
 /// <summary>
 ///   Gets or sets the collection of alternate content choices, each representing a different rendering option.
 /// </summary>
 /// <remarks>
 ///   The choices collection contains multiple content options, each with associated requirements that specify
 ///   when that choice should be selected. Choices are evaluated in the order they appear in the collection,
 ///   with the first choice meeting its requirements being selected for rendering. Each choice typically contains
 ///   content optimized for specific application versions or features, such as new content types, advanced
 ///   formatting, or enhanced functionality. If no choice in the collection has its requirements met, the
 ///   application falls back to the <see cref = "Fallback"/> content. Common choice requirements include namespace
 ///   support (indicating the application can process specific XML namespaces), feature availability (such as
 ///   support for specific content types or rendering capabilities), or version checks. The choice mechanism
 ///   enables documents to leverage new features when available while maintaining compatibility with older
 ///   applications through the fallback mechanism.
 /// </remarks>
 public AlternateContentChoiceCollection? Choices { get => _Choices; set => UpdateField(ref _Choices, value, nameof(Choices)); }
 private AlternateContentChoiceCollection? _Choices;

 /// <summary>
 ///   Gets or sets the fallback content to use when none of the choices can be satisfied.
 /// </summary>
 /// <remarks>
 ///   The fallback content provides an alternative representation that is used when the application cannot
 ///   satisfy the requirements of any choice in the <see cref = "Choices"/> collection. This typically occurs
 ///   when opening a document in an older Office version that doesn't support the namespaces or features
 ///   required by the choices. Fallback content should provide a meaningful representation of the original
 ///   content, even if it's simplified or lacks some functionality. For example, a 3D model choice might have
 ///   a 2D image as fallback, an advanced chart might fall back to a simpler chart type or image, or a new
 ///   content control might fall back to static text. The fallback mechanism ensures that documents remain
 ///   readable and editable across different Office versions, even if some advanced features cannot be fully
 ///   rendered. When the fallback is used, the original choice content is preserved in the document, allowing
 ///   it to be properly rendered when the document is subsequently opened in an application that supports the
 ///   advanced features.
 /// </remarks>
 public AlternateContentFallback? Fallback { get => _Fallback; set => UpdateField(ref _Fallback, value, nameof(Fallback)); }
 private AlternateContentFallback? _Fallback;
}