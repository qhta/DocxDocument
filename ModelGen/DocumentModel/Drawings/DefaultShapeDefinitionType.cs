namespace DocumentModel.Drawings;


/// <summary>
///   Defines the DefaultShapeDefinitionType Class.
/// </summary>
public partial class DefaultShapeDefinitionType
{
  
  /// <summary>
  ///   Visual Properties.
  /// </summary>
  public DMD.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   BodyProperties.
  /// </summary>
  public DMD.BodyProperties? BodyProperties { get; set; }
  
  
  /// <summary>
  ///   ListStyle.
  /// </summary>
  public DMD.ListStyle? ListStyle { get; set; }
  
  
  /// <summary>
  ///   ShapeStyle.
  /// </summary>
  public DMD.ShapeStyle? ShapeStyle { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
