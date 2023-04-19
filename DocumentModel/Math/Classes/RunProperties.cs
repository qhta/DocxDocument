namespace DocumentModel.Math;

/// <summary>
///   This element specifies the properties of the math run r.
/// </summary>
public class RunProperties: ModelElement
{
  /// <summary>
  ///   Specifies that the characters in the run are literal; that is, they are to be interpreted literally 
  ///   and not be built up based on any implied mathematical meaning. 
  ///   This is especially useful for operators or other special characters that signal a need for build up to an OMML reader. 
  ///   These characters are often encountered during a given instance of mathematical text 
  ///   when presented in a1-dimensional linear format, such as the linear format defined by Unicode Technical Note #28 (Sargent 2006).
  /// </summary>
  public bool? Literal { get; set; }

  /// <summary>
  ///   Specifies that the run is normal text, i.e., math italics and math spacing are not applied. 
  ///   In a normal text run, no characters will trigger reformatting of a linear expression into a two-dimensional expression.
  /// </summary>
  public bool? NormalText { get; set; }

  /// <summary>
  ///  Describes the script applied to the characters in the run.
  /// </summary>
  public ScriptKind? Script { get; set; }

  /// <summary>
  /// Describes the font style applied to the characters in the run. 
  /// </summary>
  public StyleKind? Style { get; set; }

  /// <summary>
  /// Specifies whether there is a line break at the start of a run, or at the start of the Box object, 
  /// such that the line wraps at the start of the run or box object. 
  /// </summary>
  public Break? Break { get; set; }

  /// <summary>
  /// Specifies the alignment property on the box object. 
  /// It is utilized only when the box is designated as an operator emulator. 
  /// When 1 or true, this operator emulator serves as an alignment point; 
  /// that is, designated alignment points in other equations can be aligned with it.
  /// </summary>
  public bool? Alignment { get; set; }
}