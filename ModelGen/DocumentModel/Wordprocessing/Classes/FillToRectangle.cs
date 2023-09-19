namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FillToRectangle Class.
/// </summary>
public partial class FillToRectangle
{
  
  /// <summary>
  ///   l, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:l")]
  public Int32? Left { get; set; }
  
  
  /// <summary>
  ///   t, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:t")]
  public Int32? Top { get; set; }
  
  
  /// <summary>
  ///   r, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:r")]
  public Int32? Right { get; set; }
  
  
  /// <summary>
  ///   b, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:b")]
  public Int32? Bottom { get; set; }
  
}
