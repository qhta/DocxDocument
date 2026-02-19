namespace DocumentModel.BaseTypes.Interfaces;

/// <summary>
/// Represents a length measurement that can be converted to various units (twips, points, millimeters, centimeters, inches).
/// </summary>
public interface ILengthMeasure//: IComparable<ILength>
{
  //public void Parse(string value);

  //public bool TryParse(string value, out ILength result);

  //public string ToString();

  ///// <summary>
  ///// Specifies how many units of the length are in one point
  ///// </summary>
  //public double InPoint { get; }

  /// <summary>
  /// Value of the length in twips (1/20 of a point). This is the base unit for internal calculations.
  /// </summary>
  public double ToTwips();

  /// <summary>
  /// Value of the length in points (1/72 of an inch).
  /// </summary>
  public double ToPT();

  /// <summary>
  /// Converts the current measurement to millimeters.
  /// </summary>
  public double ToMM();
  
  /// <summary>
  /// Converts the current measurement to centimeters.
  /// </summary>
  public double ToCM();
  
  /// <summary>
  /// Converts the current measurement to inches.
  /// </summary>  
  public double ToInch();
}