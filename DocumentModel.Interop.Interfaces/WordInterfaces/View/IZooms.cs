namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Zoom objects that represents the magnification options for each view (outline, normal, print
/// layout, and so on).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zooms?view=word-pia"/>
public interface IZooms : IInteropObject, IInteropDictionary<ViewType, IZoom>
{
}
