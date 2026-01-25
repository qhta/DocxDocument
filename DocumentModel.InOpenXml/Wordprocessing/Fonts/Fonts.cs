namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the root element of the font table in a WordprocessingML document.
/// This class provides access to and management of <see cref="FontDef"/> objects, enabling advanced organization, referencing, and configuration of fonts used throughout the document.
/// </summary>
[OpenXmlType(typeof(DXW.Fonts))]
public  sealed class Fonts : ModelElementCollection<FontDef, DXW.Fonts, DXW.Font>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Fonts()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">The document to attach to.</param>
  public Fonts(Wordprocessing.Document document)
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's FontTable.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndLoad(DXPack.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var fontTable = wordprocessingDocument.GetFontTable();
    SetOpenXmlElement(fontTable);
    LoadData(fontTable);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's FontTable.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndUpdate(DXPack.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    var fontTable = wordprocessingDocument.GetFontTable();
    SetOpenXmlElement(fontTable);
    UpdateData(fontTable);

  }

}