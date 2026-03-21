namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Range objects that represent stories in a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.storyranges?view=word-pia"/>
public partial interface StoryRanges : InteropObject, InteropDictionary<WdStoryType, Range>
{
}
