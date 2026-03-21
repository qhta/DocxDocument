namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of ListTemplate objects that represent the seven predefined list formats on each tab in the Bullets and Numbering dialog box.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplates?view=word-pia"/>
public partial interface ListTemplates : InteropObject, InteropCollection<ListTemplate>
{
}
