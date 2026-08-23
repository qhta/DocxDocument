namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the n-ary object.
///  These include the n-ary operator character that is used (using the chr element), 
///  the shape and height of the operator (using the grow element), 
///  the location of limits (using the limLoc element) 
///  and whether empty limits display a placeholder character or are hidden (using the subHide and supHide elements). 
/// </summary>
[OpenXmlType(typeof(DXM.NaryProperties))]
[DataContract]
[XmlRoot("NaryProperties", Namespace = "DocumentModel.Math")]
public partial class NaryProperties : ModelElement<DXM.NaryProperties>
{
  /// <summary>
  ///   Specifies n-ary Operator Character.
  /// </summary>
  public string? Operator { get => _Operator; set => UpdateField(ref _Operator, value, nameof(Operator)); }
  private string? _Operator;

  /// <summary>
  ///   Specifies the location of limits in n-ary operators. 
  ///   Limits can be either centered above and below the n-ary operator
  ///   or positioned just to the right of the operator.
  /// </summary>
  public LimitLocation? LimitLocation { get => _LimitLocation; set => UpdateField(ref _LimitLocation, value, nameof(LimitLocation)); }
  private LimitLocation? _LimitLocation;

  /// <summary>
  ///   Specifies the growth property of n-ary operators. 
  ///   When 0 or false, n-ary operators such as integrals and summations do not grow to match the size of their operand height. 
  ///   When 1 or true, the n-ary operator grows vertically to match its operand height. 
  ///   If this property is omitted, grow is set to 0.
  /// </summary>
  public bool? GrowOperators { get => _GrowOperators; set => UpdateField(ref _GrowOperators, value, nameof(GrowOperators)); }
  private bool? _GrowOperators;

  /// <summary>
  ///   Specifies the n-ary Hide Subscript property. 
  ///   When 1 or true, the lower limit does not appear. If this element is omitted, the lower limit appears.
  /// </summary>
  public bool? HideSubArgument { get => _HideSubArgument; set => UpdateField(ref _HideSubArgument, value, nameof(HideSubArgument)); }
  private bool? _HideSubArgument;

  /// <summary>
  ///   Specifies the n-ary Hide Superscript property. 
  ///   When 1 or true, the upper limit does not appear. If this element is omitted, the upper limit appears.
  /// </summary>
  public bool? HideSuperArgument { get => _HideSuperArgument; set => UpdateField(ref _HideSuperArgument, value, nameof(HideSuperArgument)); }
  private bool? _HideSuperArgument;

  /// <summary>
  ///   Specifies formatting of n-ary object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }
  private ControlProperties? _ControlProperties;
}