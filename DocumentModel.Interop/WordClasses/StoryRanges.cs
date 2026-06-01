namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Range objects that represent stories in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.storyranges?view=word-pia"/>
public partial class StoryRanges : InteropDictionary<StoryType, Range>
{
}
