namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Template objects that represent all the templates that are currently available.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.templates?view=word-pia"/>
public partial interface Templates : InteropObject, InteropCollection<Template>
{
}
