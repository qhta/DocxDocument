namespace DocumentModel.Math;

/// <summary>
/// Fraction type.
/// </summary>
public interface IFractionType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public FractionTypeValues? Val { get ; set; }
  
}
