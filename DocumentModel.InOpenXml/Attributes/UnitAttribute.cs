namespace DocumentModel;

/// <summary>
/// Specifies the unit of measurement associated with a property or field.
/// </summary>
/// <remarks>Apply this attribute to properties or fields to indicate the expected unit for their values. This can
/// be used for documentation, validation, or tooling purposes. The attribute is inherited and cannot be applied
/// multiple times to the same member.</remarks>
/// <param name="unit">The unit of measurement to associate with the target property or field. This value should be a non-empty string
/// representing a recognized unit, such as "kg", "m", or "s".</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class UnitAttribute(string unit): Attribute
{
  public string Unit { get; } = unit;
}