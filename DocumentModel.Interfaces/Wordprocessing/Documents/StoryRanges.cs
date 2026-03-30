namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Range objects that represent stories in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.storyranges?view=word-pia"/>
public partial interface StoryRanges : IModelObject, IModelDictionary<StoryType, Range>
{
}
