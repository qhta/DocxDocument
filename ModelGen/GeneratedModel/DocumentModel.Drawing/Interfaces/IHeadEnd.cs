namespace DocumentModel.Drawing;

/// <summary>
/// default head line end style is none.
/// </summary>
public interface IHeadEnd // : DocumentFormat.OpenXml.Drawing.LineEndPropertiesType
{
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  public LineEnd? Type { get ; set; }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  public LineEndWidth? Width { get ; set; }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  public LineEndLength? Length { get ; set; }
  
}
