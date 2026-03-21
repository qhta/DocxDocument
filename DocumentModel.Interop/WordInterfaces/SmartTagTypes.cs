namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of SmartTagType objects.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtypes?view=word-pia"/>
public partial interface SmartTagTypes : InteropObject, InteropCollection<SmartTagType>
{
}
