namespace DocumentModel;
/// <summary>
///   Specifies the semantic meaning of the N4L field in <see cref="HyperlinkInfo"/>.
///   Indicates the context or attachment type for a hyperlink or graphic reference in a document.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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
  ///   Graphic is used to fill a shape.
  /// </summary>
  ShapeFill,         //  2 - Graphic used to fill a shape
  /// <summary>
  ///   Graphic is used for the outline of a shape.
  /// </summary>
  ShapeOutline,      //  3 - Graphic used for shape outline
  /// <summary>
  ///   IHyperlink is attached to a shape element.
  /// </summary>
  IShape,             //  4 - IHyperlink attached to a shape
  /// <summary>
  ///   IHyperlink is attached to a WordprocessingML field.
  /// </summary>
  Field,             //  5 - IHyperlink attached to a WordprocessingML  field
  /// <summary>
  ///   IHyperlink is attached to a SpreadsheetML range.
  /// </summary>
  IRange,             //  6 - IHyperlink attached to a SpreadsheetML  range
}

