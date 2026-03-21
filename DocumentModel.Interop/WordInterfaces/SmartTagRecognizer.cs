namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents installed components that label text with types of information.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer?view=word-pia"/>
public interface SmartTagRecognizer : InteropObject
{
  /// <summary>
  /// The full name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.fullname?view=word-pia"/>
  public string FullName { get; }
  /// <summary>
  /// The enabled.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.enabled?view=word-pia"/>
  public bool Enabled { get; set; }
  /// <summary>
  /// The prog id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.progid?view=word-pia"/>
  public string ProgID { get; }
  /// <summary>
  /// The caption.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizer.caption?view=word-pia"/>
  public string Caption { get; }

}
