namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents the corners of a 3-D chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.corners?view=word-pia"/>
public interface ICorners : IInteropObject
{
  /// <summary>
  /// Gets the name of the `Corners` object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.corners.name?view=word-pia"/>
  public string Name { get; }	

  #region methods	
/// <summary>
  /// Selects the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.corners.select?view=word-pia"/>
  public object Select();	
  #endregion methods
}
