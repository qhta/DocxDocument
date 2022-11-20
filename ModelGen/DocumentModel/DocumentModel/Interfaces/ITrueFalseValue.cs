namespace DocumentModel;

/// <summary>
/// Represents the data type for attributes that have enum values that are  values that represent 't' or 'f', or 'true' or 'false'.
/// </summary>
public interface ITrueFalseValue // : DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[[System.Boolean, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
{
  /// <summary>
  /// Gets or sets the value of the simple value.
  /// </summary>
  public bool? Value { get ; set; }
  
}
