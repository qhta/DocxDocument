namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Pane objects that represent the window panes for a single window.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.panes?view=word-pia"/>
public partial interface Panes : InteropObject, InteropCollection<Pane>
{
}
