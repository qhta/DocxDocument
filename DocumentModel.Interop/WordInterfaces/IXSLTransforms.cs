namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of XSLTransform objects that represent all of the Extensible Stylesheet Language Transformations
/// (XSLTs) for a specific XML namespace.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xsltransforms?view=word-pia"/>
public interface IXSLTransforms : IInteropObject, IInteropCollection<IXSLTransform>
{
}
