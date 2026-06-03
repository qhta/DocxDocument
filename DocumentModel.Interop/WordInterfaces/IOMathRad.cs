namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mathematical radical object, consisting of a radical, a base, and an optional degree.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrad?view=word-pia"/>
public interface IOMathRad : IInteropObject
{
  /// <summary>
  /// Returns the degree expression of the radical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrad.deg?view=word-pia"/>
  public IOMath Deg { get; }
  /// <summary>
  /// Returns the base expression under the radical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrad.e?view=word-pia"/>
  public IOMath E { get; }
  /// <summary>
  /// Returns or sets whether the radical degree is hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrad.hidedeg?view=word-pia"/>
  public bool HideDeg { get; set; }

}
