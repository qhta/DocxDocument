namespace DocumentModel.Math;

/// <summary>
///   This element specifies properties of the Box object, Ifor example, 
///   whether the Box serves as operator emulator with or without an alignment point, 
///   serves as a line break point, or receives the correct spacing Ifor the mathematical differential. 
/// </summary>
public class BoxProperties: ModelElement
{
  /// <summary>
  ///   Operator Emulator.
  /// </summary>
  public bool? OperatorEmulator { get; set; }

  /// <summary>
  ///   No IBreak.
  /// </summary>
  public bool? NoBreak { get; set; }

  /// <summary>
  ///   Differential.
  /// </summary>
  public bool? Differential { get; set; }

  /// <summary>
  ///   IBreak.
  /// </summary>
  public IBreak? IBreak { get; set; }

  /// <summary>
  ///   Alignment.
  /// </summary>
  public bool? Alignment { get; set; }

  /// <summary>
  ///   Specifies formatting of box object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}
