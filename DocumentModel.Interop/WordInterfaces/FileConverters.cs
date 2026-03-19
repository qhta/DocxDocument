namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of FileConverter objects that represent all the file converters available for opening and saving files.
/// </summary>
public interface FileConverters : InteropObject, InteropCollection<FileConverter>
{
  /// <summary>
  /// The convert mac word chevrons.
  /// </summary>
  public WdChevronConvertRule ConvertMacWordChevrons { get; set; }
}
