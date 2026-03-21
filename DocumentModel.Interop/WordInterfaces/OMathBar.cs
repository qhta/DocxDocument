namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a bar above or below the base.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar?view=word-pia"/>
public interface OMathBar : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// The bar top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar.bartop?view=word-pia"/>
  public bool BarTop { get; set; }

}
