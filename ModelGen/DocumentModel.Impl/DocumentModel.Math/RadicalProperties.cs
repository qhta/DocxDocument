namespace DocumentModel.Math;

/// <summary>
/// Radical Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IHideDegree))]
public class RadicalProperties: IRadicalProperties
{
  /// <summary>
  /// Hide Degree.
  /// </summary>
  public IHideDegree? HideDegree
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
