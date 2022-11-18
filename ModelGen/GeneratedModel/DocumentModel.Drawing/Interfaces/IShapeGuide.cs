namespace DocumentModel.Drawing;

/// <summary>
/// Shape Guide.
/// </summary>
public interface IShapeGuide // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Shape Guide Formula
  /// </summary>
  public string? Formula { get ; set; }
  
}
