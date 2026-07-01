namespace DocumentModel.Drawings;

/// <summary>
/// Represents a color transformation for drawing elements. This abstract class serves as a base for specific color transformation implementations, providing a common interface and shared functionality for manipulating color properties in drawing elements.
/// </summary>
/// <typeparam name="T">Type of the underlying OpenXML element representing the color transformation.</typeparam>
public abstract class ColorTransformation<T> : ModelElement<T>, IColorTransformation where T : DX.OpenXmlElement
{
  ///// <summary>
  ///// Abstract method to transform a given color based on the specific color transformation logic implemented in derived classes.
  ///// </summary>
  ///// <param name="color">The color to be transformed.</param>
  ///// <returns>The transformed color.</returns>
  //public abstract IColor Transform(IColor color);
}