namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BevelType Class.
/// </summary>
public partial class BevelType
{
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:w")]
  public Int64? Width { get; set; }
  
  
  /// <summary>
  ///   h, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:h")]
  public Int64? Height { get; set; }
  
  
  /// <summary>
  ///   prst, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:prst")]
  public DocumentModel.Wordprocessing.BevelPresetTypeValues? PresetProfileType { get; set; }
  
}
