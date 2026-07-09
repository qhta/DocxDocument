namespace DocumentModel.Drawings;


/// <summary>
/// An abstract transformation class for color adjustments in drawing elements, specifically for transformations that involve a percentage parameter. This class serves as a base for specific percentage-based color transformations.
/// </summary>
/// <typeparam name="T">Type of the underlying OpenXML element representing the percentage transformation.</typeparam>
public abstract partial class PercentageTransformation<T> : ColorTransformation, IPercentageTransformation
  where T : DX.OpenXmlLeafElement
{
  /// <summary>
  /// Gets or sets the percentage parameter for the color transformation.
  /// </summary>
  public Percentage Value
  {
    get => _Val ??= GetProperty<Percentage>((GetUpdatableObject() as T), "Val");
    set => UpdateField(ref _Val, value, nameof(Value));
  }
  private Percentage? _Val;
}