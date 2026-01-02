namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Array object (sometimes referred to as "Equation Array", 
///   despite its ability to hold mathematical text other than equations), 
///   an object consisting of one or more equations, expressions, or other mathematical text runs 
///   that can be vertically justified as a unit with respect to surrounding text on the line. 
///   Alignment of multiple points within each run of mathematical text can occur within the array 
///   through the use of align values and spacer values. An align value is an ampersand within the array 
///   which acts as an alignment point (as described in §22.1.2.3). A spacer value is an ampersand within the array 
///   which designates where space can be added in order to align the align values on different rows of the array. 
///   Within each argument in the array, every odd ampersand is an align value and every even ampersand is a spacer value 
///   (as well, the beginning of each argument provides an implied spacer value).
/// </summary>
public class EquationArray: ElementCollection<Argument>, ICommonMathContent
{
  /// <summary>
  ///   Specifies Equation Array properties.
  /// </summary>
  public EquationArrayProperties? EquationArrayProperties { get; set; }
}