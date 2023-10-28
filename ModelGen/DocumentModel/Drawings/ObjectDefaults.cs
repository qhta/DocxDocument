namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for the definition of default shape, line, and textbox formatting properties.  An application can use this information to format a shape (or text) initially on insertion into a document.
/// </summary>
public partial class ObjectDefaults
{
  
  /// <summary>
  ///   Shape Default.
  /// </summary>
  public DMD.ShapeDefault? ShapeDefault { get; set; }
  
  
  /// <summary>
  ///   Line Default.
  /// </summary>
  public DMD.LineDefault? LineDefault { get; set; }
  
  
  /// <summary>
  ///   Text Default.
  /// </summary>
  public DMD.TextDefault? TextDefault { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
