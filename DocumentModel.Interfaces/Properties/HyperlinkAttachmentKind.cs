namespace DocumentModel.Properties;
/// <summary>
/// Specifies meaning od N4L field of <see cref="IHyperlinkInfo"/>.
/// </summary>
public enum HyperlinkAttachmentKind
{
  Background,        //  0 - Graphic shown as background of document
  Document,          //  1 - Graphic shown in document
  ShapeFill,         //  2 - Graphic used to fill a shape
  ShapeOutline,      //  3 - Graphic used for shape outline
  Shape,             //  4 - Hyperlink attached to a shape
  Field,             //  5 - Hyperlink attached to a WordprocessingML  field
  Range,             //  6 - Hyperlink attached to a SpreadsheetML  range
}
