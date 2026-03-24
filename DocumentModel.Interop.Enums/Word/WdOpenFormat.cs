namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when opening a document.
/// </summary>
public enum WdOpenFormat
{
  /// <summary>
  /// The existing format.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  Document = 1,
  /// <summary>
  /// Microsoft
  /// </summary>
  Document97 = 1,
  /// <summary>
  /// As a Microsoft Word template.
  /// </summary>
  Template = 2,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  Template97 = 2,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  RTF = 3,
  /// <summary>
  /// Unencoded text format.
  /// </summary>
  Text = 4,
  /// <summary>
  /// Unicode text format.
  /// </summary>
  UnicodeText = 5,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  EncodedText = 5,
  /// <summary>
  /// A Microsoft Word format that is backward compatible with earlier versions of Microsoft Word.
  /// [System.Runtime.InteropServices.Guid("9C1B95DA-5F16-303B-8B1C-9C846D96DE8E")] public enum WdOpenFormat ﾉ
  /// Expand table
  /// </summary>
  AllWord = 6,
  /// <summary>
  /// HTML format.
  /// </summary>
  WebPages = 7,
  /// <summary>
  /// XML format.
  /// </summary>
  XML = 8,
  /// <summary>
  /// XML document format. wdOpenFormatXMLDocumentMacroEnabled10 XML document format with macros enabled.
  /// </summary>
  XMLDocument = 9,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLDocumentMacroEnabled = 10,
  /// <summary>
  /// XML template format.
  /// </summary>
  XMLTemplate = 11,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  XMLTemplateMacroEnabled = 12,
  /// <summary>
  /// Word template format.
  /// </summary>
  AllWordTemplates = 13,
  /// <summary>
  /// Reserved for internal use. wdOpenFormatXMLDocumentMacroEnabledSerialized15 Reserved for internal use.
  /// </summary>
  XMLDocumentSerialized = 14,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLDocumentMacroEnabledSerialized = 15,
  /// <summary>
  /// Reserved for internal use. wdOpenFormatXMLTemplateMacroEnabledSerialized17 Reserved for internal use.
  /// </summary>
  XMLTemplateSerialized = 16,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLTemplateMacroEnabledSerialized = 17,
  /// <summary>
  /// Applies to Product Versions Word primary interop assembly Latest
  /// </summary>
  OpenDocumentText = 18
}
