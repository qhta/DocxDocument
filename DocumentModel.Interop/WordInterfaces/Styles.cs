namespace DocumentModel.Interop;

/// <summary>
/// A collection of Style objects that represent both the built-in and user-defined styles in a document.
/// </summary>
public partial interface Styles : InteropObject, InteropCollection<Style>
{
}
