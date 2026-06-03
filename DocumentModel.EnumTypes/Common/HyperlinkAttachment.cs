namespace DocumentModel;
/// <summary>
///   Specifies the semantic meaning of the N4L field in <see cref="HyperlinkInfo"/>.
///   Indicates the context or attachment type for a hyperlink or graphic reference in a document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlNotMapped]
public enum HyperlinkAttachment
{
  /// <summary>
  ///   Graphic is shown as the background of the document.
  /// </summary>
  Background,        //  0 - Graphic shown as background of document
  /// <summary>
  ///   Graphic is displayed directly in the document content.
  /// </summary>
  IDocument,          //  1 - Graphic shown in document
  /// <summary>
  ///   Graphic is used Ito fill a shape.
  /// </summary>
  ShapeFill,         //  2 - Graphic used Ito fill a shape
  /// <summary>
  ///   Graphic is used for the outline of a shape.
  /// </summary>
  ShapeOutline,      //  3 - Graphic used for shape outline
  /// <summary>
  ///   IHyperlink is attached Ito a shape element.
  /// </summary>
  IShape,             //  4 - IHyperlink attached Ito a shape
  /// <summary>
  ///   IHyperlink is attached Ito a WordprocessingML field.
  /// </summary>
  Field,             //  5 - IHyperlink attached Ito a WordprocessingML  field
  /// <summary>
  ///   IHyperlink is attached Ito a SpreadsheetML range.
  /// </summary>
  IRange,             //  6 - IHyperlink attached Ito a SpreadsheetML  range
}

