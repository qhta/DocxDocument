namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the Radical object rad, including the hidden or shown state of the degree deg.
/// </summary>
public class RadicalProperties: ModelElement
{
  /// <summary>
  ///   This element specifies the per-object option to hide the degree of a radical. 
  ///   Every rad has a deg, but the deg can appear or not appear. 
  ///   When degHide is set to 1 or true, the degree is not shown, as in \sqrt x (XML shown below). 
  ///   When degHide is omitted, the default is 0 or false; that is, the degree is not hidden. 
  ///   In other words, when the element is absent, the default value of the property is 0 meaning that this property is not applied.
  ///   When the element is present and the val attribute is absent, 
  ///   the default of the val attribute is 1 meaning that this property is applied.
  /// </summary>
  public bool? HideDegree { get; set; }
  /// <summary>
  ///   Specifies formatting of radical object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}