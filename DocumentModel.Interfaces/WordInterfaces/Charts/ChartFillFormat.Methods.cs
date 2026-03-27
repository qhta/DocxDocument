namespace DocumentModel.Wordprocessing;

using DocumentModel.Drawings;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat?view=word-pia"/>
public partial interface ChartFillFormat: InteropObject
{
  /// <summary>
  /// Executes the one color gradient operation.
  /// </summary>
  /// <param name="Style">Specifies the style.</param>
  /// <param name="Variant">Specifies the variant.</param>
  /// <param name="Degree">Specifies the degree.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.onecolorgradient?view=word-pia"/>
  public void OneColorGradient(GradientStyle Style, int Variant, float Degree);
}
