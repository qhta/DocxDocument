namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when opening a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdopenformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOpenFormat))]
public enum OpenFormat
{
  /// <summary>
  /// The existing format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatAuto))]
  Auto = 0,
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatDocument))]
  Document = 1,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatDocument97))]
  Document97 = 1,
  /// <summary>
  /// As a Microsoft Word template.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatTemplate))]
  Template = 2,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatTemplate97))]
  Template97 = 2,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatRTF))]
  RTF = 3,
  /// <summary>
  /// Unencoded text format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatText))]
  Text = 4,
  /// <summary>
  /// Unicode text format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatUnicodeText))]
  UnicodeText = 5,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatEncodedText))]
  EncodedText = 5,
  /// <summary>
  /// A Microsoft Word format that is backward compatible with earlier versions of Microsoft Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatAllWord))]
  AllWord = 6,
  /// <summary>
  /// HTML format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatWebPages))]
  WebPages = 7,
  /// <summary>
  /// XML format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXML))]
  XML = 8,
  /// <summary>
  /// XML document format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXMLDocument))]
  XMLDocument = 9,
  /// <summary>
  /// XML document format with macros enabled.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXMLDocumentMacroEnabled))]
  XMLDocumentMacroEnabled = 10,
  /// <summary>
  /// XML template format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXMLTemplate))]
  XMLTemplate = 11,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXMLTemplateMacroEnabled))]
  XMLTemplateMacroEnabled = 12,
  /// <summary>
  /// Word template format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatAllWordTemplates))]
  AllWordTemplates = 13,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXMLDocumentSerialized))]
  XMLDocumentSerialized = 14,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXMLDocumentMacroEnabledSerialized))]
  XMLDocumentMacroEnabledSerialized = 15,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXMLTemplateSerialized))]
  XMLTemplateSerialized = 16,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatXMLTemplateMacroEnabledSerialized))]
  XMLTemplateMacroEnabledSerialized = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatOpenDocumentText))]
  OpenDocumentText = 18
}
