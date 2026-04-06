namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of actions for an individual smart tag or a type of smart tag.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagactions?view=word-pia"/>
public partial interface ISmartTagActions : IModelCollection<ISmartTagAction>
{
}
