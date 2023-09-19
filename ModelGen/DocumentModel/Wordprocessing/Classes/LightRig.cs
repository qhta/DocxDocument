namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the lighting properties associated with the scene.
/// </summary>
public partial class LightRig
{
  
  /// <summary>
  ///   rig, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:rig")]
  public DocumentModel.Wordprocessing.LightRigTypeValues? LightRigType { get; set; }
  
  
  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:dir")]
  public DocumentModel.Wordprocessing.LightRigDirectionValues? LightDirectionType { get; set; }
  
  
  /// <summary>
  ///   SphereCoordinates.
  /// </summary>
  public DocumentModel.Wordprocessing.SphereCoordinates? SphereCoordinates { get; set; }
  
}
