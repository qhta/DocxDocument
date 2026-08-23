namespace DocumentModel.Drawings;


/// <summary>
/// An abstract transformation class for color adjustments in drawing elements, specifically for transformations that involve a degrees parameter. This class serves as a base for specific degrees-based color transformations.
/// </summary>
/// <typeparam name="T">Type of the underlying OpenXML element representing the degrees transformation.</typeparam>
public abstract partial class DegreesTransformation<T> : ColorTransformation, IDegreesTransformation
  where T : DX.OpenXmlLeafElement
{
  /// <summary>
  /// Gets or sets the degrees parameter for the color transformation.
  /// </summary>
  public Degrees Value
  {
    get => _Val ??= GetProperty<Degrees>((GetUpdatableObject(null) as T), "Val");
    set => UpdateField(ref _Val, value, nameof(Value));
  }
  private Degrees? _Val;
}