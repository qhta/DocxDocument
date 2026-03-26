namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Variable objects that represent the variables added to a document or template. Document
/// variables are used to preserve macro settings in between macro sessions.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variables?view=word-pia"/>
public partial interface Variables : InteropObject, InteropCollection<Variable>
{
}
