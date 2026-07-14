namespace DocumentModel.Drawings;

/// <summary>
/// Represents a color transformation without a specific type parameter. This abstract class serves as a base for specific color transformation implementations that do not require a type parameter, providing a common interface and shared functionality for manipulating color properties in drawing elements.
/// </summary>
public abstract class ColorTransformation<T> : ColorTransformation where T : DX.OpenXmlLeafElement
{

}