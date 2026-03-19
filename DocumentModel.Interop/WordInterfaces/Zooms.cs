namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Zoom objects that represents the magnification options for each view (outline, normal, print layout, and so on).
/// </summary>
public partial interface Zooms : InteropObject, InteropDictionary<WdViewType, Zoom>
{
}
