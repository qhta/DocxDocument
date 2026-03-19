namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mathematical function or structure that Microsoft Office Word supports, such as fractions, integrals, sums, and radicals. The OMathFunction object is a member of the OMathFunctions collection.
/// </summary>
public partial interface OMathFunction : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  public WdOMathFunctionType Type { get; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The args.
  /// </summary>
  public OMathArgs Args { get; }

  /// <summary>
  /// The acc.
  /// </summary>
  public OMathAcc Acc { get; }

  /// <summary>
  /// The bar.
  /// </summary>
  public OMathBar Bar { get; }

  /// <summary>
  /// The box.
  /// </summary>
  public OMathBox Box { get; }

  /// <summary>
  /// The border box.
  /// </summary>
  public OMathBorderBox BorderBox { get; }

  /// <summary>
  /// The delim.
  /// </summary>
  public OMathDelim Delim { get; }

  /// <summary>
  /// The eq array.
  /// </summary>
  public OMathEqArray EqArray { get; }

  /// <summary>
  /// The frac.
  /// </summary>
  public OMathFrac Frac { get; }

  /// <summary>
  /// The func.
  /// </summary>
  public OMathFunc Func { get; }

  /// <summary>
  /// The group char.
  /// </summary>
  public OMathGroupChar GroupChar { get; }

  /// <summary>
  /// The lim low.
  /// </summary>
  public OMathLimLow LimLow { get; }

  /// <summary>
  /// The lim upp.
  /// </summary>
  public OMathLimUpp LimUpp { get; }

  /// <summary>
  /// The mat.
  /// </summary>
  public OMathMat Mat { get; }

  /// <summary>
  /// The nary.
  /// </summary>
  public OMathNary Nary { get; }

  /// <summary>
  /// The phantom.
  /// </summary>
  public OMathPhantom Phantom { get; }

  /// <summary>
  /// The scr pre.
  /// </summary>
  public OMathScrPre ScrPre { get; }

  /// <summary>
  /// The rad.
  /// </summary>
  public OMathRad Rad { get; }

  /// <summary>
  /// The scr sub.
  /// </summary>
  public OMathScrSub ScrSub { get; }

  /// <summary>
  /// The scr sub sup.
  /// </summary>
  public OMathScrSubSup ScrSubSup { get; }

  /// <summary>
  /// The scr sup.
  /// </summary>
  public OMathScrSup ScrSup { get; }

  /// <summary>
  /// The omath.
  /// </summary>
  public OMath OMath { get; }
}
