namespace DocumentModel.Math;

/// <summary>
/// Superscript Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
public class SuperscriptProperties: ISuperscriptProperties
{
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
