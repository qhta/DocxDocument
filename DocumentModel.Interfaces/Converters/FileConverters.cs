namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of FileConverter objects that represent all the file converters available for opening and saving files.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverters?view=word-pia"/>
public interface IFileConverters : IModelCollection<IFileConverter>
{
  /// <summary>
  /// Controls whether text enclosed in chevron characters (« ») is converted to merge fields.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverters.convertmacwordchevrons?view=word-pia"/>
  public ChevronConvertRule ConvertMacWordChevrons { get; set; }
}
