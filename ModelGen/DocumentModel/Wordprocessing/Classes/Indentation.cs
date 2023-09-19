namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of indentation properties applied to the current paragraph.
/// </summary>
public partial class Indentation
{
  
  /// <summary>
  ///   Left Indentation
  /// </summary>
  [SchemaAttr("w:left")]
  public String? Left { get; set; }
  
  
  /// <summary>
  ///   start, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:start")]
  public String? Start { get; set; }
  
  
  /// <summary>
  ///   Left Indentation in Character Units
  /// </summary>
  [SchemaAttr("w:leftChars")]
  public Int32? LeftChars { get; set; }
  
  
  /// <summary>
  ///   startChars, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:startChars")]
  public Int32? StartCharacters { get; set; }
  
  
  /// <summary>
  ///   Right Indentation
  /// </summary>
  [SchemaAttr("w:right")]
  public String? Right { get; set; }
  
  
  /// <summary>
  ///   end, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:end")]
  public String? End { get; set; }
  
  
  /// <summary>
  ///   Right Indentation in Character Units
  /// </summary>
  [SchemaAttr("w:rightChars")]
  public Int32? RightChars { get; set; }
  
  
  /// <summary>
  ///   endChars, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:endChars")]
  public Int32? EndCharacters { get; set; }
  
  
  /// <summary>
  ///   Indentation Removed from First Line
  /// </summary>
  [SchemaAttr("w:hanging")]
  public String? Hanging { get; set; }
  
  
  /// <summary>
  ///   Indentation Removed From First Line in Character Units
  /// </summary>
  [SchemaAttr("w:hangingChars")]
  public Int32? HangingChars { get; set; }
  
  
  /// <summary>
  ///   Additional First Line Indentation
  /// </summary>
  [SchemaAttr("w:firstLine")]
  public String? FirstLine { get; set; }
  
  
  /// <summary>
  ///   Additional First Line Indentation in Character Units
  /// </summary>
  [SchemaAttr("w:firstLineChars")]
  public Int32? FirstLineChars { get; set; }
  
}
