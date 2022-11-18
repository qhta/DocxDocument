namespace DocumentModel;

/// <summary>
/// Represents the decimal value for attributes.
/// </summary>
public interface IDecimalValue // : DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[[System.Decimal, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
{
  /// <summary>
  /// Gets or sets the value of the simple value.
  /// </summary>
  public decimal? Value { get ; set; }
  
}
