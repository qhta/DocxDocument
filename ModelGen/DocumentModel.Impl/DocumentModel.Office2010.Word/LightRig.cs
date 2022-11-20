namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LightRig Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISphereCoordinates))]
public class LightRig: ILightRig
{
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  public LightRigTypeValues? LightRigType
  {
    get;
    set;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.LightRigDirectionValues? LightDirectionType
  {
    get;
    set;
  }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  public ISphereCoordinates? SphereCoordinates
  {
    get;
    set;
  }
  
}
