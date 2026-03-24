namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when opening a document.
/// </summary>
public enum WdOpenFormat
{
  /// <summary>
  /// The existing format.
  /// </summary>
  Auto = unchecked((int)0),
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  Document = unchecked((int)1),
  /// <summary>
  /// Microsoft
  /// </summary>
  Document97 = unchecked((int)1),
  /// <summary>
  /// As a Microsoft Word template.
  /// </summary>
  Template = unchecked((int)2),
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  Template97 = unchecked((int)2),
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  RTF = unchecked((int)3),
  /// <summary>
  /// Unencoded text format.
  /// </summary>
  Text = unchecked((int)4),
  /// <summary>
  /// Unicode text format.
  /// </summary>
  UnicodeText = unchecked((int)5),
  /// <summary>
  /// Encoded text format.
  /// </summary>
  EncodedText = unchecked((int)5),
  /// <summary>
  /// A Microsoft Word format that is backward compatible with earlier versions of Microsoft Word.
  /// [System.Runtime.InteropServices.Guid("9C1B95DA-5F16-303B-8B1C-9C846D96DE8E")] public enum WdOpenFormat ﾉ
  /// Expand table
  /// </summary>
  AllWord = unchecked((int)6),
  /// <summary>
  /// HTML format.
  /// </summary>
  WebPages = unchecked((int)7),
  /// <summary>
  /// XML format.
  /// </summary>
  XML = unchecked((int)8),
  /// <summary>
  /// XML document format. wdOpenFormatXMLDocumentMacroEnabled10 XML document format with macros enabled.
  /// </summary>
  XMLDocument = unchecked((int)9),
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLDocumentMacroEnabled = unchecked((int)10),
  /// <summary>
  /// XML template format.
  /// </summary>
  XMLTemplate = unchecked((int)11),
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  XMLTemplateMacroEnabled = unchecked((int)12),
  /// <summary>
  /// Word template format.
  /// </summary>
  AllWordTemplates = unchecked((int)13),
  /// <summary>
  /// Reserved for internal use. wdOpenFormatXMLDocumentMacroEnabledSerialized15 Reserved for internal use.
  /// </summary>
  XMLDocumentSerialized = unchecked((int)14),
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLDocumentMacroEnabledSerialized = unchecked((int)15),
  /// <summary>
  /// Reserved for internal use. wdOpenFormatXMLTemplateMacroEnabledSerialized17 Reserved for internal use.
  /// </summary>
  XMLTemplateSerialized = unchecked((int)16),
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLTemplateMacroEnabledSerialized = unchecked((int)17),
  /// <summary>
  /// Applies to Product Versions Word primary interop assembly Latest
  /// </summary>
  OpenDocumentText = unchecked((int)18)
}
