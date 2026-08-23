namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Zoom objects that represents the magnification options for each view (outline, normal, print
/// layout, and so on).
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zooms?view=word-pia"/>
public partial interface IZooms : IModelObject, IModelDictionary<ViewType, IZoom>
{
}
