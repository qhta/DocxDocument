namespace DocumentModel;

/// <summary>
/// Specifies the maximum value allowed for a property or field. This attribute can be applied to numeric properties or fields to enforce a maximum value constraint during validation or data processing.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class MaxValueAttribute : Attribute
{
  /// <summary>
  /// Default constructor for the MaxValueAttribute class, initializing a new instance with the specified maximum value.
  /// </summary>
  /// <param name="maxValue">The maximum value allowed for the property or field (up to UInt64.MaxValue).</param>
  public MaxValueAttribute(UInt64 maxValue)
  {
    MaxValue = maxValue;
  }

  /// <summary>
  /// Constructor for the MaxValueAttribute class that accepts a signed 64-bit integer (Int64) as the maximum value. The value is cast to UInt64 for internal storage.
  /// </summary>
  /// <param name="maxValue">The maximum value allowed for the property or field (up to Int64.MaxValue).</param>
  public MaxValueAttribute(Int64 maxValue)
  {
    MaxValue = (UInt64)maxValue;
  }

  public UInt64 MaxValue { get; internal set; }
}