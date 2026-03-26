namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of actions for an individual smart tag or a type of smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagactions?view=word-pia"/>
public partial interface SmartTagActions : InteropObject, InteropCollection<SmartTagAction>
{
}
