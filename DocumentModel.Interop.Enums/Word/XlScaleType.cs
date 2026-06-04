namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the scale type of the value axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlscaletype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlScaleType")]
public enum ScaleType
{
  /// <summary>
  /// Logarithmic
  /// </summary>
  [WordInteropEnumValue("xlScaleLogarithmic")]
  Logarithmic = -4133,
  /// <summary>
  /// Linear
  /// </summary>
  [WordInteropEnumValue("xlScaleLinear")]
  Linear = -4132
}
