namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when saving a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsaveformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSaveFormat")]
public enum SaveFormat
{
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  [WordInteropEnumValue("wdFormatDocument")]
  Document = 0,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  [WordInteropEnumValue("wdFormatDocument97")]
  Document97 = 0,
  /// <summary>
  /// Microsoft Word template format.
  /// </summary>
  [WordInteropEnumValue("wdFormatTemplate")]
  Template = 1,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  [WordInteropEnumValue("wdFormatTemplate97")]
  Template97 = 1,
  /// <summary>
  /// Microsoft Windows text format.
  /// </summary>
  [WordInteropEnumValue("wdFormatText")]
  Text = 2,
  /// <summary>
  /// Microsoft Windows text format with line breaks preserved.
  /// </summary>
  [WordInteropEnumValue("wdFormatTextLineBreaks")]
  TextLineBreaks = 3,
  /// <summary>
  /// Microsoft DOS text format.
  /// </summary>
  [WordInteropEnumValue("wdFormatDOSText")]
  DOSText = 4,
  /// <summary>
  /// Microsoft DOS text with line breaks preserved.
  /// </summary>
  [WordInteropEnumValue("wdFormatDOSTextLineBreaks")]
  DOSTextLineBreaks = 5,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  [WordInteropEnumValue("wdFormatRTF")]
  RTF = 6,
  /// <summary>
  /// Unicode text format.
  /// </summary>
  [WordInteropEnumValue("wdFormatUnicodeText")]
  UnicodeText = 7,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  [WordInteropEnumValue("wdFormatEncodedText")]
  EncodedText = 7,
  /// <summary>
  /// Standard HTML format.
  /// </summary>
  [WordInteropEnumValue("wdFormatHTML")]
  HTML = 8,
  /// <summary>
  /// Web archive format.
  /// </summary>
  [WordInteropEnumValue("wdFormatWebArchive")]
  WebArchive = 9,
  /// <summary>
  /// Filtered HTML format.
  /// </summary>
  [WordInteropEnumValue("wdFormatFilteredHTML")]
  FilteredHTML = 10,
  /// <summary>
  /// Extensible Markup Language (XML) format.
  /// </summary>
  [WordInteropEnumValue("wdFormatXML")]
  XML = 11,
  /// <summary>
  /// XML document format.
  /// </summary>
  [WordInteropEnumValue("wdFormatXMLDocument")]
  XMLDocument = 12,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [WordInteropEnumValue("wdFormatXMLDocumentMacroEnabled")]
  XMLDocumentMacroEnabled = 13,
  /// <summary>
  /// XML template format.
  /// </summary>
  [WordInteropEnumValue("wdFormatXMLTemplate")]
  XMLTemplate = 14,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [WordInteropEnumValue("wdFormatXMLTemplateMacroEnabled")]
  XMLTemplateMacroEnabled = 15,
  /// <summary>
  /// Word default document file format. For Microsoft Office Word 2007, this is the DOCX format.
  /// </summary>
  [WordInteropEnumValue("wdFormatDocumentDefault")]
  DocumentDefault = 16,
  /// <summary>
  /// PDF format.
  /// </summary>
  [WordInteropEnumValue("wdFormatPDF")]
  PDF = 17,
  /// <summary>
  /// XPS format.
  /// </summary>
  [WordInteropEnumValue("wdFormatXPS")]
  XPS = 18,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdFormatFlatXML")]
  FlatXML = 19,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdFormatFlatXMLMacroEnabled")]
  FlatXMLMacroEnabled = 20,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdFormatFlatXMLTemplate")]
  FlatXMLTemplate = 21,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdFormatFlatXMLTemplateMacroEnabled")]
  FlatXMLTemplateMacroEnabled = 22,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdFormatOpenDocumentText")]
  OpenDocumentText = 23,
  /// <summary>
  /// Strict Open XML document format.
  /// </summary>
  [WordInteropEnumValue("wdFormatStrictOpenXMLDocument")]
  StrictOpenXMLDocument = 24
}
