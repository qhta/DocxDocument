namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a fraction, consisting of a numerator and denominator separated by a fraction bar. The fraction bar can be horizontal or diagonal, depending on the fraction properties.
/// </summary>
public interface OMathFrac : InteropObject
{
  /// <summary>
  /// The num.
  /// </summary>
  public OMath Num { get; }
  /// <summary>
  /// The den.
  /// </summary>
  public OMath Den { get; }
  /// <summary>
  /// The type.
  /// </summary>
  public WdOMathFracType Type { get; set; }

}
