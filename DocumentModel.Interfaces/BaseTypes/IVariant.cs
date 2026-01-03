namespace DocumentModel;

/// <summary>
///   Variant holds a value of any type.
/// </summary>
public interface IVariant : IConvertible, IEquatable<IVariant>
{
  /// <summary>
  /// Represents variant Type of stored value.
  /// </summary>
  public VariantType VariantType { get; set; }

  /// <summary>
  /// Represents a stored value.
  /// </summary>
  public object? Value { get; set; }
}