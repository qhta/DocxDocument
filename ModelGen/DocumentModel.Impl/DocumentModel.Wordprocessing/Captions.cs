namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAutoCaptions))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICaption))]
public class Captions: ICaptions
{
}
