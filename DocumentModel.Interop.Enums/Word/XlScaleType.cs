namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the scale type of the value axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlscaletype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlScaleType
{
  /// <summary>
  /// Logarithmic
  /// </summary>
  ogarithmic = -4133,
  /// <summary>
  /// Linear
  /// </summary>
  inear = -4132
}
