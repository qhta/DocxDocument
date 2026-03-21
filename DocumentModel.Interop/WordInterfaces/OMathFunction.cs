namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mathematical function or structure that Microsoft Office Word supports, such as fractions, integrals, sums, and radicals. The OMathFunction object is a member of the OMathFunctions collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction?view=word-pia"/>
public partial interface OMathFunction : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.type?view=word-pia"/>
  public WdOMathFunctionType Type { get; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The args.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.args?view=word-pia"/>
  public OMathArgs Args { get; }

  /// <summary>
  /// The acc.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.acc?view=word-pia"/>
  public OMathAcc Acc { get; }

  /// <summary>
  /// The bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.bar?view=word-pia"/>
  public OMathBar Bar { get; }

  /// <summary>
  /// The box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.box?view=word-pia"/>
  public OMathBox Box { get; }

  /// <summary>
  /// The border box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.borderbox?view=word-pia"/>
  public OMathBorderBox BorderBox { get; }

  /// <summary>
  /// The delim.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.delim?view=word-pia"/>
  public OMathDelim Delim { get; }

  /// <summary>
  /// The eq array.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.eqarray?view=word-pia"/>
  public OMathEqArray EqArray { get; }

  /// <summary>
  /// The frac.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.frac?view=word-pia"/>
  public OMathFrac Frac { get; }

  /// <summary>
  /// The func.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.func?view=word-pia"/>
  public OMathFunc Func { get; }

  /// <summary>
  /// The group char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.groupchar?view=word-pia"/>
  public OMathGroupChar GroupChar { get; }

  /// <summary>
  /// The lim low.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.limlow?view=word-pia"/>
  public OMathLimLow LimLow { get; }

  /// <summary>
  /// The lim upp.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.limupp?view=word-pia"/>
  public OMathLimUpp LimUpp { get; }

  /// <summary>
  /// The mat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.mat?view=word-pia"/>
  public OMathMat Mat { get; }

  /// <summary>
  /// The nary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.nary?view=word-pia"/>
  public OMathNary Nary { get; }

  /// <summary>
  /// The phantom.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.phantom?view=word-pia"/>
  public OMathPhantom Phantom { get; }

  /// <summary>
  /// The scr pre.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.scrpre?view=word-pia"/>
  public OMathScrPre ScrPre { get; }

  /// <summary>
  /// The rad.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.rad?view=word-pia"/>
  public OMathRad Rad { get; }

  /// <summary>
  /// The scr sub.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.scrsub?view=word-pia"/>
  public OMathScrSub ScrSub { get; }

  /// <summary>
  /// The scr sub sup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.scrsubsup?view=word-pia"/>
  public OMathScrSubSup ScrSubSup { get; }

  /// <summary>
  /// The scr sup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.scrsup?view=word-pia"/>
  public OMathScrSup ScrSup { get; }

  /// <summary>
  /// The omath.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.omath?view=word-pia"/>
  public OMath OMath { get; }
}
