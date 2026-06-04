namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddictionarytypehid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDictionaryTypeHID")]
public enum DictionaryTypeHID
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("emptyenum")]
  emptyenum = 0
}
