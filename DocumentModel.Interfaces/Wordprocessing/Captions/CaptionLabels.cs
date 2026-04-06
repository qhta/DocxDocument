namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of CaptionLabel objects that represent the available caption labels.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabels?view=word-pia"/>
public partial interface ICaptionLabels : IModelCollection<ICaptionLabel>
{
}
