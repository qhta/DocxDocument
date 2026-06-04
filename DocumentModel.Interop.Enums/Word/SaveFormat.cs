namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when saving a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsaveformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSaveFormat))]
public enum SaveFormat
{
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument))]
  Document = 0,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument97))]
  Document97 = 0,
  /// <summary>
  /// Microsoft Word template format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatTemplate))]
  Template = 1,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatTemplate97))]
  Template97 = 1,
  /// <summary>
  /// Microsoft Windows text format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatText))]
  Text = 2,
  /// <summary>
  /// Microsoft Windows text format with line breaks preserved.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatTextLineBreaks))]
  TextLineBreaks = 3,
  /// <summary>
  /// Microsoft DOS text format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDOSText))]
  DOSText = 4,
  /// <summary>
  /// Microsoft DOS text with line breaks preserved.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDOSTextLineBreaks))]
  DOSTextLineBreaks = 5,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatRTF))]
  RTF = 6,
  /// <summary>
  /// Unicode text format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatUnicodeText))]
  UnicodeText = 7,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatEncodedText))]
  EncodedText = 7,
  /// <summary>
  /// Standard HTML format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatHTML))]
  HTML = 8,
  /// <summary>
  /// Web archive format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatWebArchive))]
  WebArchive = 9,
  /// <summary>
  /// Filtered HTML format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatFilteredHTML))]
  FilteredHTML = 10,
  /// <summary>
  /// Extensible Markup Language (XML) format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXML))]
  XML = 11,
  /// <summary>
  /// XML document format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXMLDocument))]
  XMLDocument = 12,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXMLDocumentMacroEnabled))]
  XMLDocumentMacroEnabled = 13,
  /// <summary>
  /// XML template format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXMLTemplate))]
  XMLTemplate = 14,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXMLTemplateMacroEnabled))]
  XMLTemplateMacroEnabled = 15,
  /// <summary>
  /// Word default document file format. For Microsoft Office Word 2007, this is the DOCX format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocumentDefault))]
  DocumentDefault = 16,
  /// <summary>
  /// PDF format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF))]
  PDF = 17,
  /// <summary>
  /// XPS format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXPS))]
  XPS = 18,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatFlatXML))]
  FlatXML = 19,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatFlatXMLMacroEnabled))]
  FlatXMLMacroEnabled = 20,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatFlatXMLTemplate))]
  FlatXMLTemplate = 21,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatFlatXMLTemplateMacroEnabled))]
  FlatXMLTemplateMacroEnabled = 22,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatOpenDocumentText))]
  OpenDocumentText = 23,
  /// <summary>
  /// Strict Open XML document format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatStrictOpenXMLDocument))]
  StrictOpenXMLDocument = 24
}
