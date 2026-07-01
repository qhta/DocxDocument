namespace DocumentModel.Drawings;

/// <summary>
/// Collection of color transformations that can be applied to drawing elements.
/// </summary>
public class ColorTransformations : ElementCollection<ColorTransformation>
{
  /// <summary>
  /// Default constructor for the <see cref="ColorTransformations"/> class
  /// </summary>
  public ColorTransformations() : base() { }

  /// <summary>
  /// Constructor for the <see cref="ColorTransformations"/> class that takes a parent <see cref="ModelElement"/>.
  /// </summary>
  /// <param name="parent">The parent <see cref="ModelElement"/> for this collection.</param>
  public ColorTransformations(ModelElement parent) : base(parent) { }
}
