namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains a collection of adjustment values for the specified AutoShape or WordArt object.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.adjustments?view=word-pia"/>
public interface Adjustments : InteropCollection<float>
{
}
