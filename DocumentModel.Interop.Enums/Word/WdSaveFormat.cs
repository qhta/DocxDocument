namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when saving a document.
/// </summary>
public enum WdSaveFormat
{
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  Document = unchecked((int)0),
  /// <summary>
  /// Microsoft
  /// </summary>
  Document97 = unchecked((int)0),
  /// <summary>
  /// Microsoft Word template format.
  /// </summary>
  Template = unchecked((int)1),
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  Template97 = unchecked((int)1),
  /// <summary>
  /// Microsoft Windows text format.
  /// </summary>
  Text = unchecked((int)2),
  /// <summary>
  /// Microsoft Windows text format with line breaks preserved.
  /// </summary>
  TextLineBreaks = unchecked((int)3),
  /// <summary>
  /// Microsoft DOS text format.
  /// </summary>
  DOSText = unchecked((int)4),
  /// <summary>
  /// Microsoft DOS text with line breaks preserved.
  /// </summary>
  DOSTextLineBreaks = unchecked((int)5),
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  RTF = unchecked((int)6),
  /// <summary>
  /// Unicode text format.
  /// </summary>
  UnicodeText = unchecked((int)7),
  /// <summary>
  /// Encoded text format. [System.Runtime.InteropServices.Guid("6AEEBC10-0420-3FB1-8A04-5F2053C4DAE9")] public enum
  /// WdSaveFormat ﾉ Expand table
  /// </summary>
  EncodedText = unchecked((int)7),
  /// <summary>
  /// Standard HTML format.
  /// </summary>
  HTML = unchecked((int)8),
  /// <summary>
  /// Web archive format.
  /// </summary>
  WebArchive = unchecked((int)9),
  /// <summary>
  /// Filtered HTML format.
  /// </summary>
  FilteredHTML = unchecked((int)10),
  /// <summary>
  /// Extensible Markup Language (XML) format.
  /// </summary>
  XML = unchecked((int)11),
  /// <summary>
  /// XML document format. wdFormatXMLDocumentMacroEnabled13 XML template format with macros enabled.
  /// </summary>
  XMLDocument = unchecked((int)12),
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XMLDocumentMacroEnabled = unchecked((int)13),
  /// <summary>
  /// XML template format. wdFormatXMLTemplateMacroEnabled15 XML template format with macros enabled.
  /// </summary>
  XMLTemplate = unchecked((int)14),
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XMLTemplateMacroEnabled = unchecked((int)15),
  /// <summary>
  /// Word default document file format. For Microsoft Office Word 2007, this is the DOCX format.
  /// </summary>
  DocumentDefault = unchecked((int)16),
  /// <summary>
  /// PDF format.
  /// </summary>
  PDF = unchecked((int)17),
  /// <summary>
  /// XPS format.
  /// </summary>
  XPS = unchecked((int)18),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  FlatXML = unchecked((int)19),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  FlatXMLMacroEnabled = unchecked((int)20),
  /// <summary>
  /// Reserved for internal use. wdFormatFlatXMLTemplateMacroEnabled22 Reserved for internal use.
  /// </summary>
  FlatXMLTemplate = unchecked((int)21),
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  FlatXMLTemplateMacroEnabled = unchecked((int)22),
  /// <summary>
  /// wdFormatStrictOpenXMLDocument24 Strict Open XML document format.
  /// </summary>
  OpenDocumentText = unchecked((int)23),
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  StrictOpenXMLDocument = unchecked((int)24)
}
