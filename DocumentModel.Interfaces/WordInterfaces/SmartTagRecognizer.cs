namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents installed components that label text with types of information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer?view=word-pia"/>
public interface SmartTagRecognizer : InteropObject
{
  /// <summary>
  /// Specifies the full name of a SmartTagRecognizer object, including the path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.fullname?view=word-pia"/>
  public string FullName { get; }
  /// <summary>
  /// True if a smart tag recognizer is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.enabled?view=word-pia"/>
  public bool Enabled { get; set; }
  /// <summary>
  /// Gets the programmatic identifier (ProgID) for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.progid?view=word-pia"/>
  public string ProgID { get; }
  /// <summary>
  /// Returns the label that identifies the specified smart tag recognizer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.caption?view=word-pia"/>
  public string Caption { get; }

}
