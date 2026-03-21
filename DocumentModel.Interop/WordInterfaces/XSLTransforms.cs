namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of XSLTransform objects that represent all of the Extensible Stylesheet Language Transformations (XSLTs) for a specific XML namespace.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xsltransforms?view=word-pia"/>
public partial interface XSLTransforms : InteropObject, InteropCollection<XSLTransform>
{
}
