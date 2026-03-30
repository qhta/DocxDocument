namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Reviewer objects that represents the reviewers of one or more documents. The Reviewers
/// collection contains the names of all reviewers who have reviewed documents opened or edited on a machine.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reviewers?view=word-pia"/>
public interface Reviewers : IModelCollection<Reviewer>
{
}
