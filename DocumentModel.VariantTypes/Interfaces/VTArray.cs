namespace DocumentModel.VariantTypes;

/// <summary>
/// Array variant. Holds same type values. Value is of Array type.
/// </summary>
public interface VTArray: Variant
{
  /// <summary>
  /// Array Base Type
  /// </summary>
  public ArrayBaseType? BaseType { get ; set; }

  /// <summary>
  /// <para>Array Lower Bounds Attribute</para>
  /// </summary>
  public int? LowerBounds { get; set; }

  /// <summary>
  /// <para>Array Upper Bounds Attribute</para>
  /// </summary>
  public int? UpperBounds { get; set; }
}
