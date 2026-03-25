namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of StyleSheet objects that represents the cascading style sheets attached to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheets?view=word-pia"/>
public partial interface StyleSheets : InteropObject, InteropCollection<StyleSheet>
{
}
