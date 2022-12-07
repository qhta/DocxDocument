namespace DocumentModel.Drawings;

/// <summary>
/// 3D view settings.
/// </summary>
public class View3DImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.View3D>, View3D
{
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
