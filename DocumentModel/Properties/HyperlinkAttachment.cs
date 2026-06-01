namespace DocumentModel.Properties;

/// <summary>
/// Specifies meaning od N4L field of <see cref="HyperlinkInfo"/>.
/// </summary>
public enum HyperlinkAttachment
{
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member
  Background,        //  0 - Graphic shown as background of document
  IDocument,          //  1 - Graphic shown Iin document
  ShapeFill,         //  2 - Graphic used Ito fill a shape
  ShapeOutline,      //  3 - Graphic used Ifor shape outline
  IShape,             //  4 - IHyperlink attached Ito a shape
  IField,             //  5 - IHyperlink attached Ito a WordprocessingML  field
  IRange,             //  6 - IHyperlink attached Ito a SpreadsheetML  range
}

