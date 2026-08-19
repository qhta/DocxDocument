namespace DocumentModel;

/// <summary>
/// An attribute that specifies the measure unit associated with a property or field.
/// This attribute can be used to annotate properties or types that represent measurements, allowing for consistent handling of units across the application.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
public class MeasureUnitAttribute(MeasureUnit measureUnit): Attribute
{
  /// <summary>
  /// Declares the measure unit associated with the property or type.
  /// </summary>
  public MeasureUnit MeasureUnit { get; } = measureUnit;
}