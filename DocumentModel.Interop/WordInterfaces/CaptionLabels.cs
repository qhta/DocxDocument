namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of CaptionLabel objects that represent the available caption labels.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabels?view=word-pia"/>
public partial interface CaptionLabels : InteropObject, InteropCollection<CaptionLabel>
{
}
