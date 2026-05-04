namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.Fonts.
/// </summary>
public class FontTableTestClass: _AbstractModelTestClass<FontTable>
{

  /// <summary>
  /// Creates a sample Fonts object with various property types.
  /// </summary>
  /// <returns>A populated Fonts object.</returns>
  protected override FontTable CreateSampleData()
  {
    var fonts = new FontTable();
    fonts.Add(new Font
    {
      FontName = "Arial",
      Aliases = "Helvetica,Swiss",
      FontFamily = FontFamily.Swiss,
      Pitch = FontPitch.Variable,
      Charset = FontCharset.EastEurope,
      Panose = "020B0604020202020204",
      FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000"
    });
    fonts.Add(new Font
    {
      FontName = "Times New Roman",
      Aliases = "Times",
      FontFamily = FontFamily.Roman,
      Pitch = FontPitch.Variable,
      Charset = FontCharset.Ansi,
      Panose = "02020603050405020304",
      FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000"
    });
    fonts.Add(new Font
    {
      FontName = "Courier New",
      Aliases = "Courier",
      FontFamily = FontFamily.Modern,
      Pitch = FontPitch.Fixed,
      Panose = "02070309020205020404",
      FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000",
      NotTrueType = true,
    });
    return fonts;
  }

  /// <summary>
  /// Gets the FontTable from the provided Document.
  /// </summary>
  /// <param name="document">The document from which to retrieve the font table.</param>
  /// <returns>The font table from the document.</returns>
  protected override FontTable GetDataFromDocument(Document document)
  {
    return document.FontTable;
  }

  /// <summary>
  /// Sets the font table of the specified document to the provided font table element. 
  /// </summary>
  /// <param name="document">The document whose font table is to be set.</param>
  /// <param name="data">The font table to assign to the document.</param>
  /// <returns>The font table that was set on the document.</returns>
  protected override FontTable SetDataToDocument(Document document, FontTable data)
  {
    document.FontTable = data;
    return document.FontTable;
  }

  /// <summary>
  /// Updates the specified font table in the document by adding a new predefined font and returns the added font.
  /// </summary>
  /// <param name="document">The document in which the font table will be updated.</param>
  /// <param name="data">The font table to which the new font will be added.</param>
  /// <returns>The newly created and added Font instance.</returns>
  protected override FontTable UpdateDataInDocument(Document document, FontTable data)
  {
    Font newFont = new Font
    {
      FontName = "Verdana",
      Aliases = "Geneva",
      FontFamily = FontFamily.Swiss,
      Pitch = FontPitch.Variable,
      Charset = FontCharset.Ansi,
      Panose = "020B0604020202020204",
      FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000"
    };
    data.Add(newFont);
    return document.FontTable;
  }

  /// <summary>
  /// Gets the OpenXml representation of the font table from the specified document.
  /// </summary>
  /// <param name="document">The document from which to retrieve the OpenXml representation.</param>
  /// <returns>The OpenXml representation of the font table.</returns>
  protected override string GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument!.MainDocumentPart!.FontTablePart!.Fonts!.OuterXml;
  }
}