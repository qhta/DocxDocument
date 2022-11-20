namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IAlignScripts))]
public class SubSuperscriptProperties: ISubSuperscriptProperties
{
  /// <summary>
  /// Align Scripts.
  /// </summary>
  public IAlignScripts? AlignScripts
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
