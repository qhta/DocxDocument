namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies linear gradient.
/// </summary>
public partial class LinearShadeProperties
{
  
  /// <summary>
  ///   ang, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:ang")]
  public Int32? Angle { get; set; }
  
  
  /// <summary>
  ///   scaled, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:scaled")]
  public DocumentModel.Wordprocessing.OnOffValues? Scaled { get; set; }
  
}
