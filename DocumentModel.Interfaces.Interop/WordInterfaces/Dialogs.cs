namespace DocumentModel.Interop;

/// <summary>
/// A collection of Dialog objects in Microsoft Word. Each Dialog object represents a built-in Word dialog box.
/// </summary>
public interface Dialogs : InteropObject, InteropDictionary<WdWordDialog, Dialog>
{

}
