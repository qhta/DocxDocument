namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Frame objects in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frames?view=word-pia"/>
public partial interface IFrames : IInteropObject, IInteropCollection<Frame>
{
}
