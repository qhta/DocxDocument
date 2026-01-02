namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the n-ary object.
///  These include the n-ary operator character that is used (using the chr element), 
///  the shape and height of the operator (using the grow element), 
///  the location of limits (using the limLoc element) 
///  and whether empty limits display a placeholder character or are hidden (using the subHide and supHide elements). 
/// </summary>
public class NaryProperties: ModelElement
{
  /// <summary>
  ///   Specifies n-ary Operator Character.
  /// </summary>
  public string? Operator { get; set; }
  /// <summary>
  ///   Specifies the location of limits in n-ary operators. 
  ///   Limits can be either centered above and below the n-ary operator
  ///   or positioned just to the right of the operator.
  /// </summary>
  public LimitLocationKind? LimitLocation { get; set; }
  /// <summary>
  ///   Specifies the growth property of n-ary operators. 
  ///   When 0 or false, n-ary operators such as integrals and summations do not grow to match the size of their operand height. 
  ///   When 1 or true, the n-ary operator grows vertically to match its operand height. 
  ///   If this property is omitted, grow is set to 0.
  /// </summary>
  public bool? GrowOperators { get; set; }
  /// <summary>
  ///   Specifies the n-ary Hide Subscript property. 
  ///   When 1 or true, the lower limit does not appear. If this element is omitted, the lower limit appears.
  /// </summary>
  public bool? HideSubArgument { get; set; }
  /// <summary>
  ///   Specifies the n-ary Hide Superscript property. 
  ///   When 1 or true, the upper limit does not appear. If this element is omitted, the upper limit appears.
  /// </summary>
  public bool? HideSuperArgument { get; set; }
  /// <summary>
  ///   Specifies formatting of n-ary object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}