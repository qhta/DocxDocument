namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a string in a document or range that contains recognized type information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag?view=word-pia"/>
public partial interface ISmartTag : IInteropObject
{
  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a String that represents the related XML for a smart tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.xml?view=word-pia"/>
  public string XML { get; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns a String that represents the URL address for a smart tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.downloadurl?view=word-pia"/>
  public string DownloadURL { get; }

  /// <summary>
  /// Returns a CustomProperties object that represents the properties of a smart tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.properties?view=word-pia"/>
  public CustomProperties Properties { get; }

  /// <summary>
  /// Returns a SmartTagActions collection that represents the collection of actions available on a smart tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.smarttagactions?view=word-pia"/>
  public SmartTagActions SmartTagActions { get; }

  /// <summary>
  /// Returns a XMLNode object that represents the XML element for a smart tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttag.xmlnode?view=word-pia"/>
  public XMLNode XMLNode { get; }
}
