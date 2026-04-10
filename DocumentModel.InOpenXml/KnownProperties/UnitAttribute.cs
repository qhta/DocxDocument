namespace DocumentModel;
/// <summary>
///   Indicates the unit of measurement associated with a property or field, for documentation, validation, or tooling purposes.
///   Apply this attribute to properties or fields to specify the expected unit for their values (e.g., "kg", "m", "s").
///   The attribute is inherited and cannot be applied multiple times to the same member.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
[XmlRoot("UnitAttribute", Namespace = "DocumentModel")]
public class UnitAttribute : Attribute
{
 /// <summary>
 ///   Initializes a new instance of the <see cref = "UnitAttribute"/> class with the specified unit of measurement.
 /// </summary>
 /// <param name = "unit">The unit of measurement to associate with the target property or field. This value should be a non-empty string representing a recognized unit, such as "kg", "m", or "s".</param>
 public UnitAttribute(string unit)
 {
  Unit = unit;
 }

 /// <summary>
 ///   The unit of measurement associated with the target property or field.
 /// </summary>
 public string Unit { get; }
}