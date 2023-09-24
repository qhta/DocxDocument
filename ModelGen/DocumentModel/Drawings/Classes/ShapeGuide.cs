namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the precense of a shape guide that is used to govern the geometry of the specified shape. A shape guide consists of a formula and a name that the result of the formula is assigned to. Recognized formulas are listed with the fmla attribute documentation for this element.
/// </summary>
public partial class ShapeGuide
{
  
  /// <summary>
  ///   Specifies the name that is used to reference to this guide. This name can be used just as a variable would within an equation. That is this name can be substituted for literal values within other guides or the specification of the shape path.
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Specifies the formula that is used to calculate the value for a guide. Each formula has a certain number of arguments and a specific set of operations to perform on these arguments in order to generate a value for a guide. There are a total of 17 different formulas available. These are shown below with the usage for each defined.
  /// </summary>
  public String? Formula { get; set; }
  
}
