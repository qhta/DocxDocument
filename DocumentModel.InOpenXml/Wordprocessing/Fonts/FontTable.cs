namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the root element of the font table in a WordprocessingML document.
/// This class provides access to and management of <see cref="Font"/> objects, enabling advanced organization, referencing, and configuration of fonts used throughout the document.
/// </summary>
[OpenXmlType(typeof(DXW.Fonts))]
[XmlRoot("FontTable")]
public  sealed class FontTable : ModelElementCollection<Font, DXW.Fonts, DXW.Font>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public FontTable()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">The document to attach to.</param>
  public FontTable(Wordprocessing.Document document): base(document, document.WordprocessingDocument?.GetFontTable())
  {
  }

}