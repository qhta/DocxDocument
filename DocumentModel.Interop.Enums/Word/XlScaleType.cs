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
  Logarithmic = -4133,
  /// <summary>
  /// Linear
  /// </summary>
  Linear = -4132
}
