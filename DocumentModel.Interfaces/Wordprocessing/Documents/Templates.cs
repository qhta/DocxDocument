namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Template objects that represent all the templates that are currently available.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.templates?view=word-pia"/>
public partial interface ITemplates : IModelCollection<ITemplate>
{
}
