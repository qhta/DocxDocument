namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when saving a document.
/// </summary>
public enum WdSaveFormat
{
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  wdFormatDocument = unchecked((int)0),
  /// <summary>
  /// Microsoft
  /// </summary>
  wdFormatDocument97 = unchecked((int)0),
  /// <summary>
  /// Microsoft Word template format.
  /// </summary>
  wdFormatTemplate = unchecked((int)1),
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  wdFormatTemplate97 = unchecked((int)1),
  /// <summary>
  /// Microsoft Windows text format.
  /// </summary>
  wdFormatText = unchecked((int)2),
  /// <summary>
  /// Microsoft Windows text format with line breaks preserved.
  /// </summary>
  wdFormatTextLineBreaks = unchecked((int)3),
  /// <summary>
  /// Microsoft DOS text format.
  /// </summary>
  wdFormatDOSText = unchecked((int)4),
  /// <summary>
  /// Microsoft DOS text with line breaks preserved.
  /// </summary>
  wdFormatDOSTextLineBreaks = unchecked((int)5),
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  wdFormatRTF = unchecked((int)6),
  /// <summary>
  /// Unicode text format.
  /// </summary>
  wdFormatUnicodeText = unchecked((int)7),
  /// <summary>
  /// Encoded text format. [System.Runtime.InteropServices.Guid("6AEEBC10-0420-3FB1-8A04-5F2053C4DAE9")] public enum
  /// WdSaveFormat ﾉ Expand table
  /// </summary>
  wdFormatEncodedText = unchecked((int)7),
  /// <summary>
  /// Standard HTML format.
  /// </summary>
  wdFormatHTML = unchecked((int)8),
  /// <summary>
  /// Web archive format.
  /// </summary>
  wdFormatWebArchive = unchecked((int)9),
  /// <summary>
  /// Filtered HTML format.
  /// </summary>
  wdFormatFilteredHTML = unchecked((int)10),
  /// <summary>
  /// Extensible Markup Language (XML) format.
  /// </summary>
  wdFormatXML = unchecked((int)11),
  /// <summary>
  /// XML document format. wdFormatXMLDocumentMacroEnabled13 XML template format with macros enabled.
  /// </summary>
  wdFormatXMLDocument = unchecked((int)12),
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  wdFormatXMLDocumentMacroEnabled = unchecked((int)13),
  /// <summary>
  /// XML template format. wdFormatXMLTemplateMacroEnabled15 XML template format with macros enabled.
  /// </summary>
  wdFormatXMLTemplate = unchecked((int)14),
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  wdFormatXMLTemplateMacroEnabled = unchecked((int)15),
  /// <summary>
  /// Word default document file format. For Microsoft Office Word 2007, this is the DOCX format.
  /// </summary>
  wdFormatDocumentDefault = unchecked((int)16),
  /// <summary>
  /// PDF format.
  /// </summary>
  wdFormatPDF = unchecked((int)17),
  /// <summary>
  /// XPS format.
  /// </summary>
  wdFormatXPS = unchecked((int)18),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdFormatFlatXML = unchecked((int)19),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdFormatFlatXMLMacroEnabled = unchecked((int)20),
  /// <summary>
  /// Reserved for internal use. wdFormatFlatXMLTemplateMacroEnabled22 Reserved for internal use.
  /// </summary>
  wdFormatFlatXMLTemplate = unchecked((int)21),
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  wdFormatFlatXMLTemplateMacroEnabled = unchecked((int)22),
  /// <summary>
  /// wdFormatStrictOpenXMLDocument24 Strict Open XML document format.
  /// </summary>
  wdFormatOpenDocumentText = unchecked((int)23),
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  wdFormatStrictOpenXMLDocument = unchecked((int)24)
}
