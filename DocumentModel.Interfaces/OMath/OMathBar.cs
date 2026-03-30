namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an equation with a bar above or below the base.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar?view=word-pia"/>
public interface IOMathBar : IModelObject
{
  /// <summary>
  /// Returns the base expression of the bar equation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar.e?view=word-pia"/>
  public IOMath E { get; }
  /// <summary>
  /// Returns or sets whether the bar appears above the expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbar.bartop?view=word-pia"/>
  public bool BarTop { get; set; }

}
