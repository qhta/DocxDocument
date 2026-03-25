namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of SmartTagRecognizer objects that represent recognition engines that label data with types of
/// information as you work in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizers?view=word-pia"/>
public partial interface SmartTagRecognizers : InteropObject, InteropCollection<SmartTagRecognizer>
{
}
