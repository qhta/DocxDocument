namespace DocumentModel.Interop.Word;

public partial interface ChartFillFormat
{
  /// <summary>
  /// Executes the one color gradient operation.
  /// </summary>
  /// <param name="Style">Specifies the style.</param>
  /// <param name="Variant">Specifies the variant.</param>
  /// <param name="Degree">Specifies the degree.</param>
  public void OneColorGradient(Core.MsoGradientStyle Style, int Variant, float Degree);
}
