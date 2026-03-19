namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a bar above or below the base.
/// </summary>
public interface OMathBar : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The bar top.
  /// </summary>
  public bool BarTop { get; set; }

}
