namespace DocumentModel.Packaging;

/// <summary>
/// Called from constructors of derived parts to initialize the IFixedContentTypePart interface. All derived parts must be parts that have fixed content type.
/// </summary>
public class IFixedContentTypePartImpl: ModelElement<DocumentFormat.OpenXml.Packaging.IFixedContentTypePart>, IFixedContentTypePart
{
}
