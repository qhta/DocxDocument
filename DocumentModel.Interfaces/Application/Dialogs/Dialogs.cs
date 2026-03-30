using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Dialog objects in Microsoft Word. Each Dialog object represents a built-in Word dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialogs?view=word-pia"/>
public interface Dialogs : IModelObject, IModelDictionary<WordDialog, Dialog>
{

}
