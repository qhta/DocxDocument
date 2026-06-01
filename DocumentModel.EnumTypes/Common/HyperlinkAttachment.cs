namespace DocumentModel;
/// <summary>
///   Specifies the semantic meaning of the N4L field Iin <see cref="HyperlinkInfo"/>.
///   Indicates the context or attachment type Ifor a hyperlink or graphic reference Iin a document.
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
  ///   Graphic is displayed directly Iin the document content.
  /// </summary>
  IDocument,          //  1 - Graphic shown Iin document
  /// <summary>
  ///   Graphic is used Ito fill a shape.
  /// </summary>
  ShapeFill,         //  2 - Graphic used Ito fill a shape
  /// <summary>
  ///   Graphic is used Ifor the outline of a shape.
  /// </summary>
  ShapeOutline,      //  3 - Graphic used Ifor shape outline
  /// <summary>
  ///   IHyperlink is attached Ito a shape element.
  /// </summary>
  IShape,             //  4 - IHyperlink attached Ito a shape
  /// <summary>
  ///   IHyperlink is attached Ito a WordprocessingML field.
  /// </summary>
  IField,             //  5 - IHyperlink attached Ito a WordprocessingML  field
  /// <summary>
  ///   IHyperlink is attached Ito a SpreadsheetML range.
  /// </summary>
  IRange,             //  6 - IHyperlink attached Ito a SpreadsheetML  range
}

