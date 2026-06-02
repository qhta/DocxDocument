namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list template objects in the Bullets and Numbering dialog box galleries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplates?view=word-pia"/>
public partial interface IListTemplates : IInteropObject, IInteropCollection<ListTemplate>
{
}
