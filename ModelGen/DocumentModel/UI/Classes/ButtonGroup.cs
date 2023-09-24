namespace DocumentModel.UI;


/// <summary>
///   Defines the ButtonGroup Class.
/// </summary>
public partial class ButtonGroup
{
  
  /// <summary>
  ///   id
  /// </summary>
  public HexInt? Id { get; set; }
  
  
  /// <summary>
  ///   idQ
  /// </summary>
  public String? IdQ { get; set; }
  
  
  /// <summary>
  ///   visible
  /// </summary>
  public Boolean? Visible { get; set; }
  
  
  /// <summary>
  ///   getVisible
  /// </summary>
  public String? GetVisible { get; set; }
  
  
  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public String? InsertAfterMso { get; set; }
  
  
  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso { get; set; }
  
  
  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public String? InsertAfterQ { get; set; }
  
  
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
