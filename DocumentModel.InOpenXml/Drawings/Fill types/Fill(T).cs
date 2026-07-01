using System.Runtime.Serialization;
using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;
/// <summary>
///   Abstract base class for fill formatting in DrawingML, representing the fill style (solid, gradient, pattern, etc.) for shapes, lines, and graphical elements.
///   Provides a foundation for specific fill implementations in Office Open XML documents.
/// </summary>
[DataContract]
[XmlRoot("Fill", Namespace = "DocumentModel.Drawings")]
public abstract class Fill : ModelElement, IDrawingProperty
{
}

/// <summary>
///   Generic abstract base class for fill formatting in DrawingML, parameterized by the specific OpenXml fill element type.
///   Enables type-safe modeling and manipulation of fill properties for shapes and graphical elements in Office Open XML documents.
/// </summary>
[DataContract]
[XmlRoot("Fill", Namespace = "DocumentModel.Drawings")]
public abstract class Fill<T> : Fill where T : DX.OpenXmlElement
{
}