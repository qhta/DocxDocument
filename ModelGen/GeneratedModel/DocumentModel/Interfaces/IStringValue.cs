namespace DocumentModel;

/// <summary>
/// Represents the string value for attributes.
/// </summary>
public interface IStringValue // : DocumentFormat.OpenXml.OpenXmlComparableSimpleReference`1[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
{
  /// <summary>
  /// Gets or sets the string value.
  /// </summary>
  public string? Value { get ; set; }
  
}
