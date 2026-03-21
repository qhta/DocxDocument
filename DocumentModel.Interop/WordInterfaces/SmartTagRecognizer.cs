namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents installed components that label text with types of information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer?view=word-pia"/>
public interface SmartTagRecognizer : InteropObject
{
  /// <summary>
  /// Returns the full name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.fullname?view=word-pia"/>
  public string FullName { get; }
  /// <summary>
  /// Returns or sets whether enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.enabled?view=word-pia"/>
  public bool Enabled { get; set; }
  /// <summary>
  /// Returns the prog i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.progid?view=word-pia"/>
  public string ProgID { get; }
  /// <summary>
  /// Returns the caption.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.caption?view=word-pia"/>
  public string Caption { get; }

}
