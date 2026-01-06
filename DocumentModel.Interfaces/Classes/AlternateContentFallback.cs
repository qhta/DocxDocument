using DocumentFormat.OpenXml;

namespace DocumentModel;

/// <summary>
///   Represents a collection of fallback content items used when no alternate content choice requirements can be satisfied.
/// </summary>
/// <remarks>
///   This interface and defines the
///   fallback content within an <see cref="AlternateContent"/> structure. The fallback serves as the default content
///   representation that is rendered when an Office application cannot satisfy the requirements of any choice in the
///   <see cref="AlternateContent.Choices"/> collection. This typically occurs when a document created with a newer
///   Office version containing advanced features is opened in an older version that doesn't support those features.
///   The fallback content provides a meaningful, albeit potentially simplified, representation of the original content
///   to ensure the document remains readable and functional across different Office versions. The collection contains
///   content items that can be rendered by any Office application, regardless of version or feature support, making
///   them universally compatible. Common fallback strategies include using simpler content types (2D images instead
///   of 3D models), basic formatting instead of advanced styles, static representations instead of dynamic content,
///   or placeholder elements that preserve document structure even if specific functionality is unavailable. The
///   fallback mechanism is essential to Office's forward compatibility architecture: it allows documents to leverage
///   the latest features when available while degrading gracefully in older applications. Importantly, when fallback
///   content is displayed, the original choice content is preserved in the document file, so when the document is
///   subsequently opened in an application that supports the advanced features, the full-fidelity content can be
///   restored and properly rendered. This ensures no data loss occurs during the roundtrip between different Office
///   versions, even when some applications must use fallback representations.
/// </remarks>
public interface AlternateContentFallback : ElementCollection<ICollectionItem>
{
}