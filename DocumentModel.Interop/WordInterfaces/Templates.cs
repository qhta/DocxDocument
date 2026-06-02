namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Template objects that represent all the templates that are currently available.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.templates?view=word-pia"/>
public partial interface ITemplates : IInteropObject, IInteropCollection<Template>
{
}
