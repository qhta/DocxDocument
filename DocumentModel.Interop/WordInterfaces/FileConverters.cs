namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of FileConverter objects that represent all the file converters available for opening and saving files.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverters?view=word-pia"/>
public interface FileConverters : InteropObject, InteropCollection<FileConverter>
{
  /// <summary>
  /// The convert mac word chevrons.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverters.convertmacwordchevrons?view=word-pia"/>
  public WdChevronConvertRule ConvertMacWordChevrons { get; set; }
}
