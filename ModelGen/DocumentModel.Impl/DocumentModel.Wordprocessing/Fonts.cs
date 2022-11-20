namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFont))]
public class Fonts: IFonts
{
}
