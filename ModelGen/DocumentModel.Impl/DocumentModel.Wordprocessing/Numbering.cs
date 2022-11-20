namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAbstractNum))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingIdMacAtCleanup))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingInstance))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingPictureBullet))]
public class Numbering: INumbering
{
}
