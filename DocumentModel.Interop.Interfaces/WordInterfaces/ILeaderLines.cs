namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents leader lines on a chart. Leader lines connect data labels to data points.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.leaderlines?view=word-pia"/>
public interface ILeaderLines : IInteropObject
{
  /// <summary>
  /// Returns a ChartBorder object that represents the border of the object. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.leaderlines.border?view=word-pia"/>
  public IChartBorder Border { get; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.leaderlines.format?view=word-pia"/>
  public IChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.leaderlines.select?view=word-pia"/>
  public void Select();

  #endregion methods
}
