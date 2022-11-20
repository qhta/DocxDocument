namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Word.IAllocatedCommandManifest))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IToolbarData))]
public class Toolbars: IToolbars
{
}
