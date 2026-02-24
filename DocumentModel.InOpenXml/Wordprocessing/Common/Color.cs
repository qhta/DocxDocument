namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a color definition for use in WordprocessingML documents.
/// This class extends <see cref="AbstractColor"/> and is used to specify color values for document elements such as borders, shading, and text, enabling advanced formatting and visual customization.
/// </summary>
[OpenXmlType(typeof(DXW.Color))]
public class Color : DocumentModel.AbstractColor<DXW.Color>
{

}