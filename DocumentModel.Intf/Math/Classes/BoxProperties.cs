namespace DocumentModel.Math;

/// <summary>
///   This element specifies properties of the Box object, for example, 
///   whether the Box serves as operator emulator with or without an alignment point, 
///   serves as a line break point, or receives the correct spacing for the mathematical differential. 
/// </summary>
public class BoxProperties: ModelElement
{
  /// <summary>
  ///   Operator Emulator.
  /// </summary>
  public bool? OperatorEmulator { get; set; }

  /// <summary>
  ///   No Break.
  /// </summary>
  public bool? NoBreak { get; set; }

  /// <summary>
  ///   Differential.
  /// </summary>
  public bool? Differential { get; set; }

  /// <summary>
  ///   Break.
  /// </summary>
  public Break? Break { get; set; }

  /// <summary>
  ///   Alignment.
  /// </summary>
  public bool? Alignment { get; set; }

  /// <summary>
  ///   Specifies formatting of box object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}