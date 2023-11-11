namespace DocumentModel.VariantTypes;

/// <summary>
/// Vector variant. Value is a collection of objects of any type.
/// </summary>
public interface VTVector: Variant
{
  /// <summary>
  /// Vector Base Type
  /// </summary>
  public VectorBaseType? BaseType { get ; set; }
  
}
