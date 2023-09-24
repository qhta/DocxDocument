namespace DocumentModel;


/// <summary>
///   Defines the MenuSeparator Class.
/// </summary>
public partial class MenuSeparator
{
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? Id { get; set; }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? QualifiedId { get; set; }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }
  
  
  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterMso { get; set; }
  
  
  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeMso { get; set; }
  
  
  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? InsertAfterQulifiedId { get; set; }
  
  
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? InsertBeforeQulifiedId { get; set; }
  
  
  /// <summary>
  ///   title, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetTitle { get; set; }
  
}
