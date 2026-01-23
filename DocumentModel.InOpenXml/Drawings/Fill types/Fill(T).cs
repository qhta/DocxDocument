using System.Runtime.Serialization;
using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;

/// <summary>
/// Abstract Fill class.
/// </summary>
public abstract class Fill: ModelElement, IDrawingProperty
{
}

public abstract class Fill<T> : Fill where T : DX.OpenXmlElement
{
}
