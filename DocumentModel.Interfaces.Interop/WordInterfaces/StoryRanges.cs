namespace DocumentModel.Interop;

/// <summary>
/// A collection of Range objects that represent stories in a document.
/// </summary>
public partial interface StoryRanges : InteropObject, InteropDictionary<WdStoryType, Range>
{
}
