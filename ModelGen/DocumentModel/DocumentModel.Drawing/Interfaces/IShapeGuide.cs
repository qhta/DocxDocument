namespace DocumentModel.Drawing;

/// <summary>
/// Shape Guide.
/// </summary>
public interface IShapeGuide // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Shape Guide Formula
  /// </summary>
  public System.String? Formula { get ; set; }
  
}
