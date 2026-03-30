namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of CustomLabel objects available in the Label Options dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabels?view=word-pia"/>
public partial interface CustomLabels : IModelObject, IModelCollection<CustomLabel>
{
}
