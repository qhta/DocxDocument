namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a bar above or below the base.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar?view=word-pia"/>
public interface OMathBar : InteropObject
{
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// Returns or sets whether bar top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar.bartop?view=word-pia"/>
  public bool BarTop { get; set; }

}
