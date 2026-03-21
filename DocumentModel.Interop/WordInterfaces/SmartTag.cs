namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a string in a document or range that contains recognized type information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag?view=word-pia"/>
public partial interface SmartTag : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The xml.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.xml?view=word-pia"/>
  public string XML { get; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The download url.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.downloadurl?view=word-pia"/>
  public string DownloadURL { get; }

  /// <summary>
  /// The properties.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.properties?view=word-pia"/>
  public CustomProperties Properties { get; }

  /// <summary>
  /// The smart tag actions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.smarttagactions?view=word-pia"/>
  public SmartTagActions SmartTagActions { get; }

  /// <summary>
  /// The xmlnode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.xmlnode?view=word-pia"/>
  public XMLNode XMLNode { get; }
}
