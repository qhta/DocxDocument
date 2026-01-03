namespace DocumentModel;

/// <summary>
///   Array Variant implementation.
/// </summary>
public interface IArrayVariant : IVariant, ICollection<object?>, IEquatable<IArrayVariant>
{
  /// <summary>
  /// Gets the variant type of the value represented by this instance.
  /// </summary>
  public new VariantType VariantType { get; }

  /// <summary>
  ///   Array Base Type
  /// </summary>
  public VariantType BaseType { get; set; }

  /// <summary>
  ///   Returns an item type that was set by BaseType
  /// </summary>
  public Type ItemType { get; }

  /// <summary>
  /// Gets or sets the lower bound value used for calculations or validations.
  /// </summary>
  public int LowerBounds { get; set; }

  /// <summary>
  ///   <para>Array Upper Bounds Attribute</para>
  /// </summary>
  public int UpperBounds { get; set; }

  /// <summary>
  ///   Returns current items count.
  /// </summary>
  public int Size { get; }
}